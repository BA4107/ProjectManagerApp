using Project_Management_App_2.Classes;
using Project_Management_App_2.Windows;
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
    /// Interaction logic for Edit_ProjectName_Popup.xaml
    /// </summary>
    public partial class Edit_Project_Popup : Window
    {
        //Variabile
        Project project;
        public Edit_Project_Popup(Project project)
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            txtEditProjectName.Focus();

            this.project = project;

            txtEditProjectName.Text = project.name_Project;
            if (project.deadlineExists.Contains("Yes deadline"))
            {
                txtEditProjectDeadline.SelectedDate = project.deadline;
            }
            else
            {
                txtEditProjectDeadline.SelectedDate = null;
                project.deadlineExists = "No deadline";
            }
            txtEditProjectState.Text = project.state;
            txtEditProjectDescription.Text = project.description_Project;
        }

        //Butoane
        private void btnChange_ProjectDetails_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                project.name_Project = txtEditProjectName.Text;
                if (!txtEditProjectDeadline.SelectedDate.Equals(null))
                {
                    project.deadline = (DateTime)txtEditProjectDeadline.SelectedDate;
                    project.deadlineExists = "Yes deadline";
                }
                else
                {
                    project.deadlineExists = "No deadline";
                }
                project.state = txtEditProjectState.Text;
                project.description_Project = txtEditProjectDescription.Text;

                using (SQLiteConnection conn = new SQLiteConnection(App.projectsDatabasePath))
                {
                    conn.CreateTable<Project>();
                    conn.Update(project);
                }
                this.Close();
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

        private void btnNoDeadline_Click(object sender, RoutedEventArgs e)
        {
            txtEditProjectDeadline.SelectedDate = null;
        }
    }
}
