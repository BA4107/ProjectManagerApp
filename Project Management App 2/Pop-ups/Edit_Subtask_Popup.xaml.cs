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
using System.Windows.Shapes;

namespace Project_Management_App_2.Pop_ups
{
    /// <summary>
    /// Interaction logic for Edit_Subtask_Popup.xaml
    /// </summary>
    public partial class Edit_Subtask_Popup : Window
    {
        //Variabile
        Subtask subtask;

        public Edit_Subtask_Popup(Subtask subtask)
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            txtEditSubtaskName.Focus();

            this.subtask = subtask;

            txtEditSubtaskName.Text = subtask.name_Subtask;
        }

        //Butoane
        private void btnChange_SubtaskDetails_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                subtask.name_Subtask = txtEditSubtaskName.Text;

                using (SQLiteConnection conn = new SQLiteConnection(App.projectsDatabasePath))
                {
                    conn.CreateTable<Subtask>();
                    conn.Update(subtask);
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

        private void btnDelete_Subtask_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(App.projectsDatabasePath))
                {
                    conn.CreateTable<Subtask>();
                    conn.Delete(subtask);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }
    }
}
