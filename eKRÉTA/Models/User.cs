using Microsoft.VisualBasic;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKRÉTA.Models
{
    public class User
    {
<<<<<<< HEAD
=======

>>>>>>> f1cc206cb3198b051357d65727294d835ce402c8
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FelhasznaloNev { get; set; }
        public string TeljesNev { get; set; }
<<<<<<< HEAD
        public string Jelszo { get; set; }

        public User()
        {
        }

        public User(string felhasznaloNev, string teljesNev)
        {
            FelhasznaloNev = felhasznaloNev;
            TeljesNev = teljesNev;
        }

        public User(string felhasznaloNev, string teljesNev, string jelszo)
        {
            FelhasznaloNev = felhasznaloNev;
            TeljesNev = teljesNev;
            Jelszo = jelszo;
        }
=======

>>>>>>> f1cc206cb3198b051357d65727294d835ce402c8
    }
}
