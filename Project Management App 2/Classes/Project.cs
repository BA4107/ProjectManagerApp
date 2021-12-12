using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_App_2.Classes
{
    public class Project
    {
        [PrimaryKey, AutoIncrement]
        public int ID_Project { get; set; }
        [MaxLength(30)]
        public string name_Project { get; set; }
        public DateTime start_Date { get; set; }
        public DateTime deadline { get; set; }
        public string description_Project { get; set; }
        public string state { get; set; }         // Active/Stalled/Complete
        public double completion_Project { get; set; }     //Bazat pe task-urile complete
        public string deadlineExists { get;set; }            
    }
}
