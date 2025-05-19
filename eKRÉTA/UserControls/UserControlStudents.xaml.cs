using eKRÉTA.Models;
using System.Windows.Controls;

namespace eKRÉTA.UserControls
{
    /// <summary>
    /// Interaction logic for UserControlStudents.xaml
    /// </summary>
    public partial class UserControlStudents : UserControl
    {
        public UserControlStudents()
        {
            InitializeComponent();
            ReadDatabase();

        }

        private void ReadDatabase()
        {
            var studentRepo = new GenericRepository<Student>(App.databasePath);
            var students = studentRepo.GetAll();
            datagridStudents.ItemsSource = students;
        }

        private void studentSave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Student student = new Student(vnev.Text, unev.Text, szuldate.Text, anev.Text, cim.Text);

            var studentRepo = new GenericRepository<Student>(App.databasePath);
            studentRepo.Insert(student);


            ReadDatabase();


        }
    }
}
