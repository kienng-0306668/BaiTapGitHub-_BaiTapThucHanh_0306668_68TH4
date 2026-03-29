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

namespace DoAnLapTrinhXayDung.View
{
    /// <summary>
    /// Interaction logic for UC_Ribbon.xaml
    /// </summary>
    public partial class UC_Ribbon : UserControl
    {
        public UC_Ribbon()
        {
            InitializeComponent();
        }
        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            // Code xử lý mở file (OpenFileDialog)
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // Code xử lý lưu file (SaveFileDialog)
        }

        private async void btnEtabs_Click(object sender, RoutedEventArgs e)
        {
            // Bật thanh loading
            pbLoading.Visibility = Visibility.Visible;
            txtLoadingStatus.Visibility = Visibility.Visible;

            try
            {
                // Chạy ngầm việc kết nối
                await Task.Run(() =>
                {
                    // Tạm thời cho phần mềm ngủ 3 giây để test hiệu ứng loading
                    System.Threading.Thread.Sleep(5000);
                });

                // Thông báo thành công
                MessageBox.Show("Đã kết nối thành công với Etabs!", "ETABS API", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                // Thông báo lỗi
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                // Tắt thanh loading
                pbLoading.Visibility = Visibility.Collapsed;
                txtLoadingStatus.Visibility = Visibility.Collapsed;

            }

        }

        private void btnVatLieu_Click(object sender, RoutedEventArgs e)
        {

            DoAnLapTrinhXayDung.view.VatLieuWindow1 window1 = new DoAnLapTrinhXayDung.view.VatLieuWindow1();
            window1.ShowDialog();
        }

        private void btnThongSo_Click(object sender, RoutedEventArgs e)
        {
            DoAnLapTrinhXayDung.view.ThongSoWindow win = new DoAnLapTrinhXayDung.view.ThongSoWindow();
            win.ShowDialog();
        }
        
        private void btnMatBang_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đang chuyển sang chế độ xem Mặt Bằng.");
        }

        private void btn3D_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đang chuyển sang chế độ xem 3D.");
        }

        private void btnZoomIn_Click(object sender, RoutedEventArgs e)
        {
            // Code xử lý phóng to
        }

        private void btnZoomOut_Click(object sender, RoutedEventArgs e)
        {
            // Code xử lý thu nhỏ
        }
    }
}
