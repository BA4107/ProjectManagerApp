using Project_Management_App_2.Classes;
using Project_Management_App_2.Pop_ups;
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
    /// Interaction logic for Starting_Screen.xaml
    /// </summary>
    public partial class Starting_Screen : Window
    {
        //Variabile
        List<Project> projects;

        public Starting_Screen()
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            projects = new List<Project>();

            ReadDataBase();
        }

        //Deschiderea unui proiect
        private void projectsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Project selectedProject = (Project)projectsListView.SelectedItem;

                if (selectedProject != null)
                {
                    Current_Project_Screen currentProject_Screen = new Current_Project_Screen(selectedProject);
                    currentProject_Screen.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        //Butoane
        private void btnAddProject_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Add_Project_Screen addProject = new Add_Project_Screen();
                addProject.ShowDialog();
                ReadDataBase();
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

        //Sortarea proiectelor afisate
        private void menuSortByActive_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.projectsDatabasePath))
                {
                    conn.CreateTable<Project>();
                    projects = conn.Table<Project>().ToList().Where(p => p.state.Contains("Active")).OrderBy(p => p.name_Project).ToList();
                }
                if (projects != null)
                {
                    projectsListView.ItemsSource = projects;
                }

                AllButton.FontWeight = FontWeights.Normal;
                ActiveButton.FontWeight = FontWeights.Bold;
                StalledButton.FontWeight = FontWeights.Normal;
                FinishedButton.FontWeight = FontWeights.Normal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        private void menuSortByStalled_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.projectsDatabasePath))
                {
                    conn.CreateTable<Project>();
                    projects = conn.Table<Project>().ToList().Where(p => p.state.Contains("Stalled")).OrderBy(p => p.name_Project).ToList();
                }
                if (projects != null)
                {
                    projectsListView.ItemsSource = projects;
                }

                AllButton.FontWeight = FontWeights.Normal;
                ActiveButton.FontWeight = FontWeights.Normal;
                StalledButton.FontWeight = FontWeights.Bold;
                FinishedButton.FontWeight = FontWeights.Normal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        private void menuSortByFinished_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.projectsDatabasePath))
                {
                    conn.CreateTable<Project>();
                    projects = conn.Table<Project>().ToList().Where(p => p.state.Contains("Finished")).OrderBy(p => p.name_Project).ToList();
                }
                if (projects != null)
                {
                    projectsListView.ItemsSource = projects;
                }

                AllButton.FontWeight = FontWeights.Normal;
                ActiveButton.FontWeight = FontWeights.Normal;
                StalledButton.FontWeight = FontWeights.Normal;
                FinishedButton.FontWeight = FontWeights.Bold;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        private void menuSortByAll_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ReadDataBase();

                AllButton.FontWeight = FontWeights.Bold;
                ActiveButton.FontWeight = FontWeights.Normal;
                StalledButton.FontWeight = FontWeights.Normal;
                FinishedButton.FontWeight = FontWeights.Normal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        //Metode
        //Stabileste conexiunea si afiseaza proiectele din baza de date
        private void ReadDataBase()
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.projectsDatabasePath))
            {
                conn.CreateTable<Project>();
                projects = conn.Table<Project>().ToList().OrderBy(p => p.name_Project).ToList();
            }
            if (projects != null)
            {
                projectsListView.ItemsSource = projects;
            }
        }
        //TODO STERGE ASTA LA FINAL
        private void menuDELETELATER_click(object sender, RoutedEventArgs e)
        {
            delet_test win1 = new delet_test();
            win1.ShowDialog();
        }
    }
}
