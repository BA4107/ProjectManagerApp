using Project_Management_App_2.Classes;
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
using System.Windows.Shapes;

namespace Project_Management_App_2.Pop_ups
{
    /// <summary>
    /// Interaction logic for delet_test.xaml
    /// </summary>
    public partial class delet_test : Window
    {

        //TODO STERGE ASTA LA FINAL
        List<Project> projects;
        List<Classes.Task> tasks;
        List<Subtask> subtasks;
        public delet_test()
        {
            InitializeComponent();

            projects = new List<Project>();
            tasks = new List<Classes.Task>();
            subtasks = new List<Subtask>();

            ReadDataBase();
        }

        private void ReadDataBase()
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.projectsDatabasePath))
            {
                conn.CreateTable<Project>();
                projects = conn.Table<Project>().ToList().OrderBy(p => p.name_Project).ToList();
                conn.CreateTable<Classes.Task>();
                tasks = conn.Table<Classes.Task>().ToList().OrderBy(t => t.name_Task).ToList();
                conn.CreateTable<Subtask>();
                subtasks = conn.Table<Subtask>().ToList().OrderBy(s => s.name_Subtask).ToList();
            }
            if (projects != null)
            {
                projectsListView.ItemsSource = projects;
            }
            if (tasks != null)
            {
                tasksListView.ItemsSource = tasks;

            }
            if (subtasks != null)
            {
                subtasksListView.ItemsSource = subtasks;
            }
        }
    }
}
