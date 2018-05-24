using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace BMPViewer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            }

        private void Image_Drop(object sender, DragEventArgs e)
        {

        }

        private void Window_Drop(object sender, DragEventArgs e)
        {
            try
            {
                var e1 = e.Data.GetData(DataFormats.FileDrop) as string[];
                var bmpStream = System.IO.File.ReadAllBytes(e1[0]);

                var info = BmpParser.Parse(bmpStream);
                bmpInfo.DataContext = info;

                var s = new BitmapImage();
                s.BeginInit();
                s.StreamSource = new System.IO.MemoryStream(bmpStream);
                s.EndInit();
                image.Source = s;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
