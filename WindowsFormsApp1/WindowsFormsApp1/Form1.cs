using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //testando gitremover
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxDolar_Leave(object sender, EventArgs e)
        {
            //variavel
            decimal resultado;

            if(txbCota.Text != "" && txbDolar.Text != "")
            {
                resultado = Convert.ToDecimal(txbDolar.Text) * Convert.ToDecimal(txbDolar.Text);

                lblReais.Text = resultado.ToString("C");
            }
            else
            {
                MessageBox.Show("digite algo");
            }
        }
    }
}
