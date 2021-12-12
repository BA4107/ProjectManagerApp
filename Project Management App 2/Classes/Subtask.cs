using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_App_2.Classes
{
    public class Subtask
    {
        [PrimaryKey, AutoIncrement]
        public int ID_Subtask { get; set; }
        [MaxLength(30)]
        public string name_Subtask { get; set; }
        public bool isDone_Subtask { get; set; }
        public int Task_ID { get; set; }        //Realizeaza legatura dintre task și subtask
    }
}
