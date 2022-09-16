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
    /// Interaction logic for TeachersPage.xaml
    /// </summary>
    public partial class TeachersPage : Page
    {
        public TeachersPage()
        {
            InitializeComponent();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            List<TeacherViewModel> teacherViewModels = new List<TeacherViewModel>()
            {
                new TeacherViewModel{ Id = 1001, FullName = "Jabbaraliyev Ibrohim", CountOfCourses=56, Level="Senior", Age=34, PhoneNumber="+998976567861", Status=Domain.Enums.StaffStatus.InVocation},
                new TeacherViewModel{ Id = 1002, FullName = "Komilov Toxir", CountOfCourses=14, Level="Senior", Age=56, PhoneNumber="+998976567880", Status=Domain.Enums.StaffStatus.Active},
                new TeacherViewModel{ Id = 1003, FullName = "Karimulloyev Sardor", CountOfCourses=34, Level="Senior", Age=23, PhoneNumber="+998976557867", Status=Domain.Enums.StaffStatus.Deleted},
                new TeacherViewModel{ Id = 1004, FullName = "Aliyev Jobir", CountOfCourses=33, Level="Senior", Age=45, PhoneNumber="+998976567800", Status=Domain.Enums.StaffStatus.InVocation},
                new TeacherViewModel{ Id = 1005, FullName = "Sattorov Komil", CountOfCourses=11, Level="Senior", Age=34, PhoneNumber="+998976569967", Status=Domain.Enums.StaffStatus.Freeze},
            };

            dgData.ItemsSource = teacherViewModels;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
