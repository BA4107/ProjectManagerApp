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
    /// Interaction logic for Add_Project_Screen.xaml
    /// </summary>
    public partial class Add_Project_Screen : Window
    {
        //Variables
        public Add_Project_Screen()
        {
            InitializeComponent();
            
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            txtProjectName.Focus();
        }
        //Butoane
        private void btnSaveProject_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Project project = new Project()
                {
                    name_Project = txtProjectName.Text,
                    start_Date = txtProjectStartDate.DisplayDate,
                    description_Project = txtProjectDescription.Text,
                    deadlineExists = "Something didn't work.",
                    state = "Active"
                };
                if (!txtProjectDeadline.SelectedDate.Equals(null))
                {
                    project.deadline = (DateTime)txtProjectDeadline.SelectedDate;
                    project.deadlineExists = "Yes deadline";
                }
                else
                {
                    project.deadlineExists = "No deadline";
                }

                if (txtProjectName.Text.Equals(""))
                {
                    Empty_Name_Error errorPopup = new Empty_Name_Error();
                    errorPopup.ShowDialog();
                }
                else
                {
                    using (SQLiteConnection connection = new SQLiteConnection(App.projectsDatabasePath))
                    {
                        connection.CreateTable<Project>();
                        connection.Insert(project);
                    }

                    this.Close();
                }
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }
        private void btnNoDeadline_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtProjectDeadline.SelectedDate = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }
    }
}
