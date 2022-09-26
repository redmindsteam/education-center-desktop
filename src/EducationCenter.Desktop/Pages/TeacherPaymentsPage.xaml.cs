using EducationCenter.Service.ViewModels.Teachers;
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
    /// Interaction logic for TeacherPaymentsPage.xaml
    /// </summary>
    public partial class TeacherPaymentsPage : Page
    {
        public TeacherPaymentsPage()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var teacherPayments = new List<TeacherPaymentViewModel>()
            {
                new TeacherPaymentViewModel()
                {
                    Id=1,
                    TeacherName = "O'tkirbek Sobirjonov",
                    CourseName = ".Net bootcamp #4",
                    Amount=1000000,
                    ForMonth = "2022, July",
                    PaymentDate = DateTime.Now.ToString("12.12.2020 12:34")
                },
                new TeacherPaymentViewModel()
                {
                    Id=2,
                    TeacherName = "Muhammad Abdulloh Komilov",
                    CourseName = ".Net bootcamp #3",
                    Amount=1000000,
                    ForMonth = "2022, July",
                    PaymentDate = DateTime.Now.ToString("12.12.2020 12:35")
                }
            };
            dgData.ItemsSource = teacherPayments;
        }
    }
}
