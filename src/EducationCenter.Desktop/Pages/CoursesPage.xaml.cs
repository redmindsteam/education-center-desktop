using EducationCenter.Domain.Enums;
using EducationCenter.Service.ViewModels.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EducationCenter.Desktop.Pages
{
    /// <summary>
    /// Interaction logic for CoursesPage.xaml
    /// </summary>
    public partial class CoursesPage : Page
    {
        public CoursesPage()
        {
            InitializeComponent();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            List<CourseViewModel> courses = new List<CourseViewModel>()
            {
                new CourseViewModel(){ Id = 12, Name = ".Net bootcamp 4", Language="Uz", Level="Pre Ielts", Price=2200000, SubjectName="Ingliz tili", Status=CourseStatus.Active}
            };
            dgData.ItemsSource = courses;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
