/* Evin Park
 * Feb 12, 2020
 * names and calculates the cost of computer parts
 *
 */
 
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
using System.Web;

namespace _317324Assignment1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Redirect Links for the Websites
        private void btnCPULink_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.canadacomputers.com/product_info.php?cPath=4_65&item_id=161102");
        }

        private void btnMotherboardLink_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.canadacomputers.com/product_info.php?cPath=26_1842_1844&item_id=114128");
        }

        private void btnCaseLink_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.canadacomputers.com/product_info.php?cPath=6_113&item_id=136034");
        }

        private void btnPowerSupplyLink_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.canadacomputers.com/product_info.php?cPath=33_442&item_id=094360");
        }

        private void btnRAMLink_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.canadacomputers.com/product_info.php?cPath=24_311_1326&item_id=090226");
        }

        private void btnGPULink_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.canadacomputers.com/product_info.php?cPath=43_557_558&item_id=160913");
        }

        private void btnHardDriveLink_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.canadacomputers.com/product_info.php?cPath=15_1086_210_212&item_id=132494");
        }

        private void btnOpticalDriveLink_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.canadacomputers.com/product_info.php?cPath=3_61&item_id=060114");
        }

        //finds values in the int startOfItem
        private void imgSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            string theItem= imgSelector.SelectedValue.ToString();
            int startOfItem;
            startOfItem = theItem.IndexOf("ComboBoxItem: ");
            string comboBox;
            comboBox = theItem.Substring(startOfItem + 14);

            //Changes photo based on user input
            if (comboBox == "CPU")
            {
                imgPicSelection.Source = new BitmapImage(new Uri("CPU.jpg",UriKind.Relative));
            }

            if (comboBox == "Motherboard")
            {
                imgPicSelection.Source = new BitmapImage(new Uri("Motherboard.jpg", UriKind.Relative));
            }

            if (comboBox == "Case")
            {
                imgPicSelection.Source = new BitmapImage(new Uri("Case.jpg", UriKind.Relative));
            }

            if (comboBox == "Power Supply")
            {
                imgPicSelection.Source = new BitmapImage(new Uri("PowerSupply.jpg", UriKind.Relative));
            }

            if (comboBox == "RAM")
            {
                imgPicSelection.Source = new BitmapImage(new Uri("RAM.jpg", UriKind.Relative));
            }

            if (comboBox == "GPU")
            {
                imgPicSelection.Source = new BitmapImage(new Uri("GPU.jpg", UriKind.Relative));
            }

            if (comboBox == "Hard Drive")
            {
                imgPicSelection.Source = new BitmapImage(new Uri("HardDrive.jpg", UriKind.Relative));
            }

            if (comboBox == "Optical Drive")
            {
                imgPicSelection.Source = new BitmapImage(new Uri("OpticalDrive.jpg", UriKind.Relative ));
            }
        }
    }
}
