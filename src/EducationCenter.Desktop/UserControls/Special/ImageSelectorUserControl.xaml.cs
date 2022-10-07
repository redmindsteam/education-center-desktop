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

namespace EducationCenter.Desktop.UserControls.Special
{
    /// <summary>
    /// Interaction logic for ImageSelectorUserControl.xaml
    /// </summary>
    public partial class ImageSelectorUserControl : UserControl
    {
        public ImageSelectorUserControl()
        {
            InitializeComponent();
        }

        private void Border_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.DefaultExt = ".jpg";
            dialog.Filter = "JPG Files(*jpg)|*.jpg";
            Nullable<bool> result = dialog.ShowDialog();
            if (result == true) tbImage.Text = dialog.FileName;
        }
    }
}
