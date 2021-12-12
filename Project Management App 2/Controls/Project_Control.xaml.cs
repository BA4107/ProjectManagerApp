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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_Management_App_2.Controls
{
    /// <summary>
    /// Interaction logic for Project_Control.xaml
    /// </summary>
    public partial class Project_Control : UserControl
    {
       //Variabile
        public Project Project
        {
            get { return (Project)GetValue(ProjectProperty); }
            set { SetValue(ProjectProperty, value); }
        }

        //DependencyProperty 
        public static readonly DependencyProperty ProjectProperty =
            DependencyProperty.Register("Project", typeof(Project), typeof(Project_Control),
                new PropertyMetadata(new Project() { name_Project = "Project Name",deadlineExists="Days left", state="State" }, SetText));

        public Project_Control()
        {
            InitializeComponent();
        }

        //Metode
        private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                Project_Control control = d as Project_Control;
                if (control != null)
                {
                    control.lblProjectName.Text = (e.NewValue as Project).name_Project;
                    control.lblState.Text = (e.NewValue as Project).state;
                    control.lblDaysLeft.Text = DaysLeft_String(e.NewValue as Project);
                    control.prgsProjectBar.Value = (e.NewValue as Project).completion_Project;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        private static String DaysLeft_String(Project project)
        {
            TimeSpan daysLeft;
            String daysLeft_String = "The deadline couldn't be fetched.";
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
    }
}
