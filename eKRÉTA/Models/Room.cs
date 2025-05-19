using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKRÉTA.Models
{
    internal class Room
    {
        public Room()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string TeremNev { get; set; }



    }
}
