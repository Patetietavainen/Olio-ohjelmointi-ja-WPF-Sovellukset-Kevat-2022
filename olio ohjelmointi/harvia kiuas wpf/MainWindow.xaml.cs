using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace harvia_kiuas_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>



    public partial class MainWindow : Window

    {
        kiuas kiuas = new kiuas();

        public MainWindow()
        {
            InitializeComponent();

            kiuas.VaihdaLämpötila(10);
            kiuas.VaihdaLämpötila(10);
            kiuas.OnkoPäällä = false;
        }


        private void btn_Lämpötilaup_Click(object sender, RoutedEventArgs e)
        {
            int uusiLämpötila = kiuas.Lämpötila + 5;
            kiuas.VaihdaLämpötila(uusiLämpötila);
            tb_Lämpötila.Text = kiuas.Lämpötila.ToString();
        }

        private void btn_Lämpötiladown_Click(object sender, RoutedEventArgs e)
        {
            int uusiLämpötila = kiuas.Lämpötila - 5;
            kiuas.VaihdaLämpötila(uusiLämpötila);
            tb_Lämpötila.Text = kiuas.Lämpötila.ToString();
        }

        private void input_Kosteus_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("0-9 +");
            e.Handled = regex.IsMatch(e.Text);
        }


        private void input_Kosteus_TextChanged(object sender, TextChangedEventArgs e)
        { 
        
        {
                kiuas.VaihdaKosteutta(int.Parse(input_Kosteus.Text));
                tb_Kosteus.Text = kiuas.Kosteus.ToString();
        }
    }
}
