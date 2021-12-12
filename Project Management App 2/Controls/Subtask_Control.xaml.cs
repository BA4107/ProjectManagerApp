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

namespace Project_Management_App_2.Controls
{
    /// <summary>
    /// Interaction logic for Subtask_Control.xaml
    /// </summary>
    public partial class Subtask_Control
    {
        //Variabile
        public Subtask Subtask
        {
            get { return (Subtask)GetValue(SubtaskProperty); }
            set { SetValue(SubtaskProperty, value); }
        }

        Classes.Task Task;

        //DependencyProperty 
        public static readonly DependencyProperty SubtaskProperty =
            DependencyProperty.Register("Subtask", typeof(Subtask), typeof(Subtask_Control),
                new PropertyMetadata(new Subtask() { name_Subtask = "SubTask name" }, SetText));

        public Subtask_Control()
        {
            InitializeComponent();
        }
        //Checkmark
        private void chkSubTaskDone_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                ReadDataBase();
                Subtask.isDone_Subtask = true;
                txtSubTaskName.TextDecorations = TextDecorations.Strikethrough;
                Updating_Check_Subtask();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        private void chkSubTaskDone_Unchecked(object sender, RoutedEventArgs e)
        {
            try
            {
                ReadDataBase();
                Subtask.isDone_Subtask = false;
                Task.isDone_Task = false;
                txtSubTaskName.TextDecorations = null;
                Updating_Check_Subtask();
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
                Subtask_Control control = d as Subtask_Control;
                if (control != null)
                {
                    control.txtSubTaskName.Text = (e.NewValue as Subtask).name_Subtask;
                    control.chkSubTaskDone.IsChecked = (e.NewValue as Subtask).isDone_Subtask;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButton.OK);
            }
        }

        private void Updating_Check_Subtask()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.projectsDatabasePath))
            {
                conn.CreateTable<Subtask>();
                conn.CreateTable<Classes.Task>();
                conn.Update(Subtask);
                conn.Update(Task);
            }
            //Pentru realizarea relatiei parent-child
            var newEventArgs = new RoutedEventArgs(ParentChildEvent);
            RaiseEvent(newEventArgs);
        }

        private void ReadDataBase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.projectsDatabasePath))
            {
                conn.CreateTable<Classes.Task>();
                Task = conn.Table<Classes.Task>().Where(t => t.ID_Task.Equals(Subtask.Task_ID)).First();
            }
        }
    }
}
