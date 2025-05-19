using eKRÉTA.Models;
using System.Windows;
using System.Windows.Controls;

namespace eKRÉTA.UserControls
{
    /// <summary>
    /// Interaction logic for UserControlUsers.xaml
    /// </summary>
    public partial class UserControlUsers : UserControl
    {
        List<User> users;
        User selectedUser;
        public UserControlUsers()
        {
            InitializeComponent();
            users = new List<User>();
            //Test();
            ReadDatabase();

            saveBtn.Visibility = Visibility.Visible;
            modBtn.Visibility = Visibility.Hidden;
            deleteBtn.Visibility = Visibility.Hidden;
        }

        private void Test()
        {
            var userRepo = new GenericRepository<User>(App.databasePath);

            // Adatok lekérdezése
            var users = userRepo.GetAll();

            // Új beszúrás
            //userRepo.Insert(new User(...));

            // Módosítás
            //userRepo.Update(selectedUser);

            // Törlés
            //userRepo.Delete(selectedUser);
        }

        private void ReadDatabase()
        {
            fullnameTextBox.Text = "";
            usernameTextBox.Text = "";
            //NEW!
            passwordBox.Password = "";


            //NEW2 generic CRUD 
            var userRepo = new GenericRepository<User>(App.databasePath);
            var users = userRepo.GetAll();
            datagridUsers.ItemsSource = users;

            //using (SQLite.SQLiteConnection sQLiteConnection = new SQLite.SQLiteConnection(App.databasePath))
            //{
            //    sQLiteConnection.CreateTable<User>();
            //    var query = sQLiteConnection.Table<User>().ToList();
            //    if (query != null)
            //    {
            //        datagridUsers.ItemsSource = query;
            //    }
            //}
            saveBtn.Visibility = Visibility.Visible;
            modBtn.Visibility = Visibility.Hidden;
            deleteBtn.Visibility = Visibility.Hidden;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            //MODIFIED
            User user = new User(usernameTextBox.Text, fullnameTextBox.Text, PasswordHelper.HashPassword(passwordBox.Password));

            //User user = new User()
            //{
            //    FelhasznaloNev = usernameTextBox.Text,
            //    TeljesNev = fullnameTextBox.Text
            //};


            //NEW2 generic CRUD 
            var userRepo = new GenericRepository<User>(App.databasePath);
            userRepo.Insert(user);

            //using (SQLite.SQLiteConnection sQLiteConnection = new SQLite.SQLiteConnection(App.databasePath))
            //{
            //    sQLiteConnection.CreateTable<User>();
            //    sQLiteConnection.Insert(user);
            //}
            ReadDatabase();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            // NEW 2 generic CRUD
            var userRepo = new GenericRepository<User>(App.databasePath);
            userRepo.Delete(selectedUser);

            //using (SQLite.SQLiteConnection sQLiteConnection = new SQLite.SQLiteConnection(App.databasePath))
            //{
            //    sQLiteConnection.CreateTable<User>();
            //    sQLiteConnection.Delete(selectedUser);
            //}
            ReadDatabase();

        }

        private void datagridUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            saveBtn.Visibility = Visibility.Collapsed;
            modBtn.Visibility = Visibility.Visible;
            deleteBtn.Visibility = Visibility.Visible;

            if (datagridUsers.SelectedItem != null)
            {
                selectedUser = (User)datagridUsers.SelectedItem;
                fullnameTextBox.Text = selectedUser.TeljesNev;
                usernameTextBox.Text = selectedUser.FelhasznaloNev;
            }
        }

        private void modBtn_Click(object sender, RoutedEventArgs e)
        {
            selectedUser.FelhasznaloNev = usernameTextBox.Text;
            selectedUser.TeljesNev = fullnameTextBox.Text;

            // NEW!
            if (passwordBox.Password != "")
            {
                selectedUser.Jelszo = PasswordHelper.HashPassword(passwordBox.Password);
            }

            //NEW2 generic CRUD
            var userRepo = new GenericRepository<User>(App.databasePath);
            userRepo.Update(selectedUser);

            //using (SQLite.SQLiteConnection sQLiteConnection = new SQLite.SQLiteConnection(App.databasePath))
            //{
            //    sQLiteConnection.CreateTable<User>();
            //    sQLiteConnection.Update(selectedUser);
            //}

            ReadDatabase();

        }


    }
}
