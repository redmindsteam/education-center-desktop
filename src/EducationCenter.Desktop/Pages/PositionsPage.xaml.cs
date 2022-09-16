using EducationCenter.Desktop.Windows.Positions;
using EducationCenter.Desktop.Windows.Students;
using EducationCenter.Service.Common.Utils;
using EducationCenter.Service.Services.Positions;
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
        private readonly PositionService _positionService;
        public PositionsPage()
        {
            InitializeComponent();
            this._positionService = new PositionService();
        }

        private async void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            List<PositionViewModel> positionViewModels = new List<PositionViewModel>()
            {
                new PositionViewModel(){ Id = 110101, Name="Teacher", CountStaffsOfPosition = 20, Status="Active"},
                new PositionViewModel(){ Id = 110102, Name="Accountent", CountStaffsOfPosition = 4, Status="Active"},
                new PositionViewModel(){ Id = 110103, Name="Head", CountStaffsOfPosition = 2, Status="Deleted"}
            };
            //PaginationParams @params = new PaginationParams(1, 50);
            //var positionViewModels = await _positionService.GetAllAsync(@params);
            dgData.ItemsSource = positionViewModels;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CreatePositionWindow positionWindow = new CreatePositionWindow();
            positionWindow.ShowDialog();
        }
    }
}
