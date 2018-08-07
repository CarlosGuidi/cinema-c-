using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        Cinema cinema = new Cinema();

        public Form1()
        {
            InitializeComponent();
            cinema.setPreco(Convert.ToDouble(txtprecoNormal.Text));
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDesconto.Text = "";
            txtFilme.Text = "";
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txtFilme.Text.Equals("") || cmbData.Text.Equals(""))
            {
                MessageBox.Show("Insira os valores", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                cinema.setFilme(txtFilme.Text);
                cinema.setDiaDaSemana(cmbData.Text);
                txtDesconto.Text = Convert.ToString(cinema.calcularDesconto());
            }
        }
    }
}
