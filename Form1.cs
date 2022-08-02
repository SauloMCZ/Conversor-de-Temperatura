using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double c, f, k;
       
       

        private void button1_Click(object sender, EventArgs e)
        {
            c = double.Parse(tbCelsius.Text);
            f = (c * 9 / 5 ) + 32;
            k = c + 273.15;

            tbFarenheit.Text = ("O valor convertido é  " + f + " º f");
            tbKelvin.Text = ("O valor Convertido é  " + k + " º k");

            tbCelsius.Text = "";
        }
    }
}
