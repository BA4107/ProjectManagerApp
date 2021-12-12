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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_Management_App_2.Windows
{
    /// <summary>
    /// Interaction logic for Add_Task_Screen.xaml
    /// </summary>
    public partial class Add_Task_Screen : Window
    {
        //Variabile
        Project project;

        public Add_Task_Screen(Project currentProject)
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            txtTaskName.Focus();

            this.project = currentProject;
        }

        //Butoane
        private void btnSaveTask_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Classes.Task task = new Classes.Task()
                {
                    name_Task = txtTaskName.Text,
                    description_Task = txtTaskDescription.Text,
                    Project_ID = project.ID_Project
                };

                if (txtTaskName.Text.Equals(""))
                {
                    Empty_Name_Error errorPopup = new Empty_Name_Error();
                    errorPopup.ShowDialog();
                }
                else
                {
                    using (SQLiteConnection connection = new SQLiteConnection(App.projectsDatabasePath))
                    {
                        connection.CreateTable<Classes.Task>();
                        connection.Insert(task);
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        private void btnBack_CurrentProject_Click(object sender, RoutedEventArgs e)
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
