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
using System.Windows.Shapes;

namespace FirstWPFApplication
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        string name = "";
        public Window2()
        {
            InitializeComponent();

            txtInput.Text = "What is your name?";
            name = "";
            btnGetInput.IsEnabled = false;
        }

        private void txtInput_GotFocus(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Focused");
            if(name.Length == 0)
            {
                txtInput.Text = "";
            }
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            //MessageBox.Show("Text Change trigger");
            name = txtInput.Text;

            if(name.Length > 0)
                btnGetInput.IsEnabled = true;
            else
                btnGetInput.IsEnabled = false;
        }

        private void btnGetInput_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello there {name}!");
        }
    }
}
