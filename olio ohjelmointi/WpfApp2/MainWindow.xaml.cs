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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        float KmToMilesValue = 0.61283f;
        float MilesToKmValue = 1.67284f;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MilesToKm_Click(object sender, RoutedEventArgs e)
        {
            float value = float.Parse(txt_input.Text);
            float muunettuArvo = value * KmToMilesValue;
            tb_lopputulos.Text = value + "km on" + muunettuArvo+ "mailia";
        }

        private void btn_MilesToKm_Click(object sender, RoutedEventArgs e)
        {
            float value = float.Parse(txt_input.Text);
            float muunettuArvo = value * MilesToKmValue;
            tb_lopputulos.Text = value + "mailia on" + muunettuArvo + "km";
        }
    }
}
