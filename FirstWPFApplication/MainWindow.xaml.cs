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

namespace FirstWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClickMe_MouseEnter(object sender, MouseEventArgs e)
        {
            float left = rnd.Next(0, (int)myWindow.Width - (int)btnClickMe.Width);
            float top = rnd.Next(0, (int)myWindow.Height - (int)btnClickMe.Height);
            //MessageBox.Show("Mouse Hover");

            btnClickMe.Margin = new Thickness(left, top, 0, 0);

        }
    }
}
