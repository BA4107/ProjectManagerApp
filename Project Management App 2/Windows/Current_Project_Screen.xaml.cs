using Project_Management_App_2.Classes;
using Project_Management_App_2.Pop_ups;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Project_Management_App_2.Windows
{
    /// <summary>
    /// Interaction logic for Current_Project_Screen.xaml
    /// </summary>
    

    public partial class Current_Project_Screen : Window
    {
        //Variabile
        Project project;
        List<Classes.Task> tasks;
        List<Subtask> subtasks;
        //TODO ReadDataBase after closing project
        public Current_Project_Screen(Classes.Project selectedProject)
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.project = selectedProject;

            tasks = new List<Classes.Task>();
            subtasks = new List<Subtask>();

            Refresh_Project();
        }

        //Butoane
        private void btnAddTask_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Add_Task_Screen addTask = new Add_Task_Screen(project);
                addTask.ShowDialog();
                Refresh_Project();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        private void btnBack_Projects_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                    project.completion_Project = ProgressBar_Value();
                    using (SQLiteConnection conn = new SQLiteConnection(App.projectsDatabasePath))
                    {
                        conn.CreateTable<Project>();
                        conn.Update(project);
                    }
                
                Go_back();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MinimizeApp_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        //Meniu
        private void menuEditProject_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Edit_Project_Popup popup = new Edit_Project_Popup(project);
                popup.ShowDialog();
                Project_Details();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        private void menuDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(App.projectsDatabasePath))
                {
                    conn.CreateTable<Project>();
                    conn.Delete(project);
                    conn.CreateTable<Classes.Task>();
                    conn.CreateTable<Subtask>();
                    foreach (var taskDelete in tasks)
                    {
                        subtasks = conn.Table<Subtask>().ToList().Where(s => s.Task_ID.Equals(taskDelete.ID_Task)).ToList();
                        foreach (var subtaskDelete in subtasks)
                        {
                            conn.Delete(subtaskDelete);
                        }
                        conn.Delete(taskDelete);
                    }

                    Go_back();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        //Deschiderea unui task
        private void tasksListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Classes.Task selectedTask = (Classes.Task)tasksListView.SelectedItem;

                if (selectedTask != null)
                {
                    Current_Task_Screen currentTask_Screen = new Current_Task_Screen(selectedTask, project);
                    currentTask_Screen.Show();
                    ReadDataBase();
                    project.completion_Project = ProgressBar_Value();
                    ReadDataBase();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        //Metode
        private void Go_back()
        {
            Starting_Screen startScreen = new Starting_Screen();
            startScreen.Show();
            this.Close();
        }

        private void Project_Details()
        {
            lblProjectName.Text = project.name_Project;
            project.completion_Project = ProgressBar_Value();
            prgProjectBar.Value = project.completion_Project;
            lblStartDate.Text = project.start_Date.ToString("dd-MM-yyyy");
            if (project.deadlineExists.Contains("No deadline"))
            {
                lblDeadline.Text = "No deadline.";
            }
            else
            {
                lblDeadline.Text = project.deadline.ToString("dd-MM-yyyy");
            }
            lblDaysLeft.Text = DaysLeft_String(project);
            lblState.Text = project.state;
            if (project.description_Project.Equals("")) 
            {
                lblDescriptionProject.Text = "This project doesn't have a description yet.";
            }
            else
            {
                lblDescriptionProject.Text = project.description_Project;
            }
        }

        private String DaysLeft_String(Project project)
        {
            TimeSpan daysLeft;
            String daysLeft_String = "The deadline coudn't be fetched.";
            if (project.deadlineExists.Contains("Yes deadline"))
            {
                daysLeft = (DateTime)project.deadline.Date - DateTime.Now.Date;
                double daysLeft_Double = daysLeft.TotalDays;

                if (daysLeft.TotalDays > 1)
                {
                    daysLeft_String = daysLeft_Double.ToString() + " Days left";
                }
                else if (daysLeft.TotalDays.Equals(1))
                {
                    daysLeft_String = daysLeft_Double.ToString() + " Day left";
                }
                else if (daysLeft.TotalDays.Equals(0))
                {
                    daysLeft_String = "The deadline is today";
                }
                else
                {
                    daysLeft_Double = daysLeft_Double * -1;
                    daysLeft_String = daysLeft_Double.ToString() + " days ago";
                }
            }
            else
            {
                daysLeft_String = "No deadline";
            }
            return daysLeft_String;
        }

        private void Refresh_Project()
        {
            ReadDataBase();
            project.completion_Project = ProgressBar_Value();
            ReadDataBase();
            Project_Details();
        }

        private double ProgressBar_Value()
        {
            if (tasks.Count() != 0)
            {
                double taskPercentage = (100 / tasks.Count());
                double completionTask_Sum = 0;
                foreach (var task in tasks)
                {
                    completionTask_Sum = task.completion_task / 100 + completionTask_Sum;
                }
                double result = (completionTask_Sum * taskPercentage);
                return result;
            }
            return 0;
        }
        private double CheckedTasks()
        {
            double checkedTasks = 0;
            if (tasks != null)
            {
                foreach (var task in tasks)
                {
                    if (task.isDone_Task)
                    {
                        checkedTasks++;
                    }
                }
            }
            return checkedTasks;
        }
        //Stabilirea conexiunii si afisarea task-urilor proiectului curent
        private void ReadDataBase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.projectsDatabasePath))
            {
                conn.CreateTable<Classes.Task>();
                tasks = conn.Table<Classes.Task>().ToList().Where(t => t.Project_ID.Equals(project.ID_Project)).OrderBy(t => t.name_Task).ToList();
            }
            if(tasks != null)
            {
                tasksListView.ItemsSource = tasks;
            }
        }

        //Metoda pentru realizarea relatiei parent-child
        private void HandleChildEvent(object sender, RoutedEventArgs e)
        {
            Project_Details();
            e.Handled = true;
        }
    }
}
