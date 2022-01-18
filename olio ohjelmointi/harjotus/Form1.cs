using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harjotus
{
    public partial class Form1 : Form
    {

        int autot = 0;
        int kuormaAuto = 0;
        
        
        public Form1()
        {
            InitializeComponent();
            TB_Auto.Text = autot.ToString();
            TB_KuormaAuto = kuormaAutot.ToString();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
