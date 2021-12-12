using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Project_Management_App_2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Stabileste unda va fi creata baza de date
        static string projectsDatabaseName = "Projects.db";
        static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string projectsDatabasePath = System.IO.Path.Combine(folderPath, projectsDatabaseName);
    }
}
