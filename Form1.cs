using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Domingos_Ribeiro
{
    public partial class Form1 : Form
    {
        public int pisca = 0;
        public Form1()
        {
           
            InitializeComponent();
            label_erros.Visible = false;
            cmbConcelho.Text = "Escolha aqui --------->";
            txtNome.Text = "Shrek da Silva Coelho";
    }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label_erros.Visible = false;
            double valorbase = 0;
            double valorfinal = 0;
            try
            {
                int ano = Convert.ToInt16(txtAnoNascimento.Text);
                valorbase = Convert.ToDouble(txtValorBase.Text);
                valorfinal = valorbase;

                if (ano > 1999) valorfinal = valorfinal - valorbase * 0.1;

                if (chkboxEscalao.Checked == true) valorfinal = valorfinal - valorbase * 0.1;

                if (ano < 1900 )
                {
                    timer1.Start();
                }

                if (ano > 2020)
                {
                    timer1.Start();
                }

                if (chkboxSocio.Checked == true) valorfinal = valorfinal - valorbase * 0.05;
                if (chkboxAgravamento.Checked == true) valorfinal = valorfinal + 12;

                if (rdbSim.Checked == true) valorfinal = valorfinal - valorbase * 0.01;

                if (cmbConcelho.Text == "Amares") valorfinal = valorfinal - valorbase * 0.2;

                txtTotal.Text = Convert.ToString(valorfinal);
            }
            catch (Exception)
            {
                timer1.Start();
                label_erros.Visible = true;
                label_erros.Text = "Dados Inválidos";
                txtTotal.Text = "";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pisca++;

            if (pisca % 2 == 0)
            {
                label_erros.Hide();//Esta linha ESCONDE o texto colocado na label.
            }
            if (pisca % 2 != 0)
            {
                label_erros.Show();//Esta linha MOSTRA o texto colocado na label.

            }
        }

        private void label_erros_Click(object sender, EventArgs e)
        {

        }
    }
}
