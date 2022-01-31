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

namespace Tehtävä_26
{
    public partial class MainWindow : Window
    {
        private bool Onkokirjauduttu = false;

        Dictionary<string, string> käyttäjät = new Dictionary<string, string>();


        public int NykyinenLämpötila = 20;
        public MainWindow()
        {
            InitializeComponent();
            käyttäjät.Add("Datanomi12", "asd");
            käyttäjät.Add("opiskelija", "12345");
            käyttäjät.Add("Opettaja", "Koira71");

        }


        private void btn_Läpmötilaup_Click(object sender, RoutedEventArgs e)
        {
            if (Onkokirjauduttu)
            {
                NykyinenLämpötila++;
                tb_Lämpötila.Text = NykyinenLämpötila.ToString();
            }
        }

        private void btn_Lämpötiladown_Click(object sender, RoutedEventArgs e)
        {
            if (Onkokirjauduttu)
            {
                NykyinenLämpötila--;
                tb_Lämpötila.Text = NykyinenLämpötila.ToString();

            }
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in käyttäjät)
            {
                if (tb_Username.Text == item.Key && tb_Password.Password == item.Value)
                {
                    MessageBox.Show("Login successful");
                    Onkokirjauduttu = true;

                }

            }
        }


    }
}
