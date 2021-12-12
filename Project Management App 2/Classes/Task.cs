using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_App_2.Classes
{
    public class Task
    {
        [PrimaryKey, AutoIncrement]
        public int ID_Task { get; set; }
        [MaxLength(30)]
        public string name_Task { get; set; }
        public double completion_task { get; set; } //Bazat pe subtask-urile complete
        public bool isDone_Task { get; set; }
        public string description_Task { get; set; }
        public int Project_ID { get; set; }         //Realizează legătura dinte proiect și sarcina
    }
}
