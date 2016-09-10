using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        //se a opcao estiver checada (checked) ira converter para inteiro (convert.toint32tb1) (operador+) (convert.toint32tb2) e volta ser string (.tostring)
        {
            if (rbsoma.Checked == true)
            {
                tbresultado.Text = (Convert.ToDecimal(tb1.Text) + Convert.ToDecimal(tb2.Text)).ToString();
            }
           
            else if (rbmultiplica.Checked == true)
            {
                tbresultado.Text = (Convert.ToDecimal(tb1.Text) * Convert.ToDecimal(tb2.Text)).ToString();
            }
            else if (rbdivisao.Checked == true)
            {
                tbresultado.Text = (Convert.ToDecimal(tb1.Text) / Convert.ToDecimal(tb2.Text)).ToString();
            }
            else if (rbsubtrair.Checked == true)
            {
                tbresultado.Text = (Convert.ToDecimal(tb1.Text) - Convert.ToDecimal(tb2.Text)).ToString();
            }
        }
        // no evento checkedchanged: depois de realizar o calculo realiza a limpeza dos text box
        private void rbsoma_CheckedChanged(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            tbresultado.Text = "";
        }

        private void rbsubtrair_CheckedChanged(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            tbresultado.Text = "";
        }

        private void rbdivisao_CheckedChanged(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            tbresultado.Text = "";
        }

        private void rbmultiplica_CheckedChanged(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            tbresultado.Text = "";
        }
    }
}





