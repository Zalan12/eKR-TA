using System.Configuration;
using System.Data;
using System.Windows;

namespace eKRÉTA
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string database = "eKRÉTA.db";
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string databasePath = System.IO.Path.Combine(path, database);
<<<<<<< HEAD
    }
=======







    }

>>>>>>> f1cc206cb3198b051357d65727294d835ce402c8
}
