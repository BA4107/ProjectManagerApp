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

namespace Project_Management_App_2.Pop_ups
{
    /// <summary>
    /// Interaction logic for Edit_Task_Popup.xaml
    /// </summary>
    public partial class Edit_Task_Popup : Window
    {
        //Variabile
        Classes.Task task;

        public Edit_Task_Popup(Classes.Task task)
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            txtEditTaskName.Focus();

            this.task = task;

            txtEditTaskName.Text = task.name_Task;
            txtEditTaskDescription.Text = task.description_Task;
        }

        //Butoane
        private void btnChange_TaskDetails_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                task.name_Task = txtEditTaskName.Text;
                task.description_Task = txtEditTaskDescription.Text;

                using (SQLiteConnection conn = new SQLiteConnection(App.projectsDatabasePath))
                {
                    conn.CreateTable<Classes.Task>();
                    conn.Update(task);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        private void btnCancelPopup_Click(object sender, RoutedEventArgs e)
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
