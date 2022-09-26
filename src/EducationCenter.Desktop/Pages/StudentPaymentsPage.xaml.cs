using EducationCenter.Service.ViewModels.Students;
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
    /// Interaction logic for StudentPaymentsPage.xaml
    /// </summary>
    public partial class StudentPaymentsPage : Page
    {
        public StudentPaymentsPage()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var studentpayments = new List<StudentPaymentViewModel>()
            {
                new StudentPaymentViewModel()
                {
                    Id=1,
                    StudentName = "Aliyev Jonibek",
                    CourseName = ".Net bootcamp #4",
                    Amount=1000000,
                    ForMonth = "2022, November",
                    PaymentDate = DateTime.Now.ToString("12.12.2020 12:34")
                },
                new StudentPaymentViewModel()
                {
                    Id=2,
                    StudentName = "Sayfullayev Aziz",
                    CourseName = ".Net bootcamp #3",
                    Amount=1000000,
                    ForMonth = "2022, February",
                    PaymentDate = DateTime.Now.ToString("12.12.2020 12:35")
                }
            };

            dgData.ItemsSource = studentpayments;
        }
    }
}
