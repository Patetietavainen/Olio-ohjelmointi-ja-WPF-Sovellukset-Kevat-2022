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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int autot = 0;
        int kuormaAuto = 0;


        public MainWindow()
        {
            InitializeComponent();
            tb_auto.Text = autot.ToString();
            tb_kuormaAuto.Text = kuormaAuto.ToString();

        }

        private void btn_kuormaAuto_Click(object sender, RoutedEventArgs e)

        {
            autot++;
            tb_auto.Text = autot.ToString();

        }

    }
}
