using Project_Management_App_2.Classes;
using SQLite;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_Management_App_2.Controls
{
    /// <summary>
    /// Interaction logic for Task_Control.xaml
    /// </summary>
    public partial class Task_Control
    {
        //Variabile
        public Classes.Task Task
        {
            get { return (Classes.Task)GetValue(TaskProperty); }
            set { SetValue(TaskProperty, value); }
     
        }
        List<Subtask> subtasksToCheck;

        //DependencyProperty 
        public static readonly DependencyProperty TaskProperty =
            DependencyProperty.Register("Task", typeof(Classes.Task), typeof(Task_Control),
                new PropertyMetadata(new Classes.Task() { name_Task = "Task name" }, SetText));

        public Task_Control()
        {
            InitializeComponent();

            subtasksToCheck = new List<Subtask>();
        }

        //Checkmark
        private void chkTaskDone_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (subtasksToCheck != null)
                {
                    ReadDataBase();
                    foreach (var subtask in subtasksToCheck)
                    {
                        subtask.isDone_Subtask = true;
                    }
                    Task.isDone_Task = true;
                    Task.completion_task = 100;
                    Updating_Check_Task();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        private void chkTaskDone_Unchecked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (subtasksToCheck != null)
                {
                    ReadDataBase();
                    foreach (var subtask in subtasksToCheck)
                    {
                        subtask.isDone_Subtask = false;
                    }
                    Task.isDone_Task = false;
                    Task.completion_task = 0;
                    Updating_Check_Task();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        //Metode
        private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                Task_Control control = d as Task_Control;

                if (control != null)
                {
                    control.chkTaskDone.IsChecked = (e.NewValue as Classes.Task).isDone_Task;
                    control.txtTaskName.Text = (e.NewValue as Classes.Task).name_Task;
                    control.prgsTaskBar.Value = (e.NewValue as Classes.Task).completion_task;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        private void Updating_Check_Task()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.projectsDatabasePath))
            {
                conn.CreateTable<Classes.Task>();
                conn.CreateTable<Subtask>();
                foreach (var subtask in subtasksToCheck)
                {
                    conn.Update(subtask);
                }
                conn.Update(Task);
                prgsTaskBar.Value = Task.completion_task;
            }
            //Pentru realizarea relatiei parent-child
            var newEventArgs = new RoutedEventArgs(ParentChildEvent);
            RaiseEvent(newEventArgs);
        }

        private void ReadDataBase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.projectsDatabasePath))
            {
                conn.CreateTable<Subtask>();
                subtasksToCheck = conn.Table<Subtask>().ToList().Where(s => s.Task_ID.Equals(Task.ID_Task)).OrderBy(s => s.name_Subtask).ToList();
            }
        }

    }
}
