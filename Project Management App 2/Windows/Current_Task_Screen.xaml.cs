using Project_Management_App_2.Classes;
using Project_Management_App_2.Pop_ups;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Project_Management_App_2.Windows
{
    /// <summary>
    /// Interaction logic for Current_Task_Screen.xaml
    /// </summary>
    public partial class Current_Task_Screen : Window
    {
        //Variabile
        Classes.Task task;
        Project project;
        List<Subtask> subtasks;
        public Current_Task_Screen(Classes.Task selectedTask, Project currentProject)
        {
            InitializeComponent();
            
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.task = selectedTask;
            this.project = currentProject;
            subtasks = new List<Subtask>();

            Refresh_Task();
        }

        //Butoane
        private void btnAddNewSubTask_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Add_Subtask_Screen addSubtask = new Add_Subtask_Screen(task);
                addSubtask.ShowDialog();
                Refresh_Task();
            }
            catch (Exception ex)
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

        private void btnBack_CurrentProject_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CheckedSubtasks() == subtasks.Count() && subtasks.Count() != 0)
                {
                    task.isDone_Task = true;
                    task.completion_task = ProgressBar_Value();
                    using (SQLiteConnection conn = new SQLiteConnection(App.projectsDatabasePath))
                    {
                        conn.CreateTable<Classes.Task>();
                        conn.Update(task);
                    }
                }
                else if (CheckedSubtasks() != subtasks.Count() && subtasks.Count() != 0)
                {
                    task.isDone_Task = false;
                    task.completion_task = ProgressBar_Value();
                    using (SQLiteConnection conn = new SQLiteConnection(App.projectsDatabasePath))
                    {
                        conn.CreateTable<Classes.Task>();
                        conn.Update(task);
                    }
                }
                    Go_Back_Current_Project();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        //Meniu
        private void menuEditTaskDetails_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Edit_Task_Popup popup = new Edit_Task_Popup(task);
                popup.ShowDialog();
                Refresh_Task();
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
                    conn.CreateTable<Classes.Task>();
                    conn.Delete(task);
                    conn.CreateTable<Subtask>();
                    foreach (var item in subtasks)
                    {
                        conn.Delete(item);
                    }
                    Go_Back_Current_Project();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }

        }

        //Deschiderea meniului de editare a subtask-ului
        private void subTasksListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Subtask selectedSubtask = (Subtask)subTasksListView.SelectedItem;

                if (selectedSubtask != null)
                {
                    Edit_Subtask_Popup currentSubtask = new Edit_Subtask_Popup(selectedSubtask);
                    currentSubtask.ShowDialog();
                    Refresh_Task();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }
        //Metode
        private void Go_Back_Current_Project()
        {
            try
            {
                Current_Project_Screen currentProject = new Current_Project_Screen(project);
                currentProject.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        private void Task_Details()
        {
            lblTaskName.Text = task.name_Task;
            prgTaskBar.Value = ProgressBar_Value();
            if (task.description_Task.Equals(""))
            {
                lblDescriptionProject.Text = "This task doesn't have a description yet.";
            }
            else
            {
                lblDescriptionProject.Text = task.description_Task;
            }
        }

        private double ProgressBar_Value()
        {
            if (subtasks.Count() != 0)
            {
                double result = (CheckedSubtasks() / subtasks.Count()) * 100;
                return result;
            }
            return task.completion_task;
        }

        private double CheckedSubtasks()
        {
            double checkedSubtasks = 0;
            if (subtasks != null)
            {
                foreach (var subtask in subtasks)
                {
                    if (subtask.isDone_Subtask)
                    {
                        checkedSubtasks++;
                    }
                }
            }
            return checkedSubtasks;
        }

        private void Refresh_Task()
        {
            ReadDataBase();
            task.completion_task = ProgressBar_Value();
            ReadDataBase();
            Task_Details();
        }

        //Stabilirea conexiunii si afisarea subtask-urilor tasku-ului current 
        private void ReadDataBase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.projectsDatabasePath))
            {
                conn.CreateTable<Subtask>();
                subtasks = conn.Table<Subtask>().ToList().Where(s => s.Task_ID.Equals(task.ID_Task)).OrderBy(s => s.name_Subtask).ToList();
            }
            if (subtasks != null)
            {
                subTasksListView.ItemsSource = subtasks;
            }
        }

        //Metoda pentru realizarea relatiei parent-child
        private void HandleChildEvent(object sender, RoutedEventArgs e)
        {
            Task_Details();
            e.Handled = true;
        }
    }
}
