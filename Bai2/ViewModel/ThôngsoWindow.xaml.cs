using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DoAnLapTrinhXayDung.view
{
    /// <summary>
    /// Interaction logic for ThongSoWindow.xaml
    /// </summary>
    public partial class ThongSoWindow : Window
    {
        public ThongSoWindow()
        {
            InitializeComponent();
        }
        private void btnXacNhan_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}