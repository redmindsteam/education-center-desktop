using EducationCenter.Desktop.Windows.Positions;
using EducationCenter.Desktop.Windows.Students;
using EducationCenter.Service.ViewModels.Positions;
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
    /// Interaction logic for PositionsPage.xaml
    /// </summary>
    public partial class PositionsPage : Page
    {
        public PositionsPage()
        {
            InitializeComponent();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            List<PositionViewModel> positionBaseViewModels = new List<PositionViewModel>()
            {
                new PositionViewModel(){ Id = 110101, Name="Teacher", CountStaffsOfPosition = 20, Status="Active"},
                new PositionViewModel(){ Id = 110102, Name="Accountent", CountStaffsOfPosition = 4, Status="Active"},
                new PositionViewModel(){ Id = 110103, Name="Head", CountStaffsOfPosition = 2, Status="Deleted"}
            };

            dgData.ItemsSource = positionBaseViewModels;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CreatePositionWindow positionWindow = new CreatePositionWindow();
            positionWindow.ShowDialog();
        }
    }
}
