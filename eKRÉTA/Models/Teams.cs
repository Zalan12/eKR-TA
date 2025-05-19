using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKRÉTA.Models
{
    internal class Teams //Ez lesz az osztályok class
    {
        public Teams()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string OsztalyNev { get; set; }
        public int TeremID { get; set; }


    }
}
