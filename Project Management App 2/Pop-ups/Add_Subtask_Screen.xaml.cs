using Project_Management_App_2.Classes;
using Project_Management_App_2.Pop_ups;
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
using System.Windows.Shapes;

namespace Project_Management_App_2.Windows
{
    /// <summary>
    /// Interaction logic for Add_Subtask_Screen.xaml
    /// </summary>
    public partial class Add_Subtask_Screen : Window
    {
        //Variabile
        Classes.Task task;

        public Add_Subtask_Screen(Classes.Task currentTask)
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            txtSubtaskName.Focus();

            this.task = currentTask;
        }

        //Butoane
        private void btnSaveSubtask_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Subtask subtask = new Subtask()
                {
                    name_Subtask = txtSubtaskName.Text,
                    Task_ID = task.ID_Task,
                };
                task.isDone_Task = false;
                if (txtSubtaskName.Text.Equals(""))
                {
                    Empty_Name_Error errorPopup = new Empty_Name_Error();
                    errorPopup.ShowDialog();
                }
                else
                {
                    using (SQLiteConnection conn = new SQLiteConnection(App.projectsDatabasePath))
                    {
                        conn.CreateTable<Subtask>();
                        conn.CreateTable<Classes.Task>();
                        conn.Insert(subtask);
                        conn.Update(task);
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        private void btnBack_CurrentTask_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }
    }
}
