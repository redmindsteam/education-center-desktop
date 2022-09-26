using EducationCenter.Domain.Entities;
using EducationCenter.Service.ViewModels.Employees;
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
    /// Interaction logic for EmployeePaymentsPage.xaml
    /// </summary>
    public partial class EmployeePaymentsPage : Page
    {
        public EmployeePaymentsPage()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var employeePayments = new List<EmployeePaymentViewModel>()
            {
                new EmployeePaymentViewModel()
                {
                    Id=1,
                    EmployeeName = "Karim Sattorov",
                    Position = "Director",
                    Amount=6000000,
                    ForMonth = "2022, February",
                    PaymentDate = DateTime.Now.ToString("1.1.2022 12:34")
                },
                new EmployeePaymentViewModel()
                {
                    Id=1,
                    EmployeeName = "Muhammad Abdulloh Muhammadqosimxo'jayev",
                    Position = "Accountent",
                    Amount=3000000,
                    ForMonth = "2022, July",
                    PaymentDate = DateTime.Now.ToString("12.12.2020 12:34")
                }
            };
            dgData.ItemsSource = employeePayments;
        }
    }
}
