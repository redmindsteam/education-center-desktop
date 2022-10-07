using EducationCenter.Desktop.Windows.Students;
using EducationCenter.Service.ViewModels.Students;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace EducationCenter.Desktop.Pages
{
    /// <summary>
    /// Interaction logic for StudentsPage.xaml
    /// </summary>
    public partial class StudentsPage : Page
    {
        public StudentsPage()
        {
            InitializeComponent();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            List<StudentViewModel> studentViewModels = new List<StudentViewModel>()
            {
                new StudentViewModel(){ Id = 1001, FullName = "Karimov Olim",Email = "Olim@gmail.com", CountOfCourses=4, PhoneNumber="+998954454312", Status=Domain.Enums.StudentStatus.Active},
                new StudentViewModel(){ Id = 1002, FullName = "Salimov Komil", Email = "Salim@gmail.com", CountOfCourses=4, PhoneNumber="+998954454312", Status=Domain.Enums.StudentStatus.Freeze},
                new StudentViewModel(){ Id = 1003, FullName = "Abdulkarimxo'jayev MuhammadAbdulloh", Email = "Salim@gmail.com", CountOfCourses=4, PhoneNumber="+998954454312", Status=Domain.Enums.StudentStatus.Deleted},
                new StudentViewModel(){ Id = 1004, FullName = "Saidkamolov Abdullaxo'ja", Email = "AbdullaKarimov@gmail.com", CountOfCourses=2, PhoneNumber="+998954454312", Status=Domain.Enums.StudentStatus.Finished},
            };

            dgData.ItemsSource = studentViewModels;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            StudentCreateWindow studentCreateWindow = new StudentCreateWindow();
            studentCreateWindow.ShowDialog();
        }
    }
}
