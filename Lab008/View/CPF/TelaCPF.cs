using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab008.View.CPF
{
    public partial class lblCpf : Form
    {
        public lblCpf()
        {
            InitializeComponent();
        }

        private void validaCpf()
        {
            if (string.IsNullOrWhiteSpace(tbxCpf.Text))
            {
                MessageBox.Show("CPF é obrigatório.","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                tbxCpf.Focus();
                tbxCpf.SelectAll();
                return;
            }
            string cpfInformado = tbxCpf.Text.Replace(".", "").Replace("-", "");

          //  lblResultado.Text = cpfInformado;

            if(cpfInformado.Length != 11)
            {
                lblResultado.Text = "Informe um CPF com 11 digitos.";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            string cpf = cpfInformado.Substring(0, 9);

            int soma = 0;
            int valorRef = 10;

            for (int i = 0; i <= 8; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
            }
            int dv1 = (int) soma % 11;

            if (dv1 < 2)
            {
                dv1 = 0;
            }
            else
            {
                dv1 = 11 - dv1;
            }

            if (!cpfInformado.Substring(9, 1).Equals(dv1.ToString()))
            {
                lblResultado.Text = "Informe um CPF válido.";
                lblResultado.ForeColor = Color.Red;
                return;
            }
            cpf = cpf + dv1.ToString();
            valorRef = 11;
            soma = 0;

            for (int i = 9; i >= 0; i--)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
            }
            int dv2 = (int)soma % 11;

            if (dv2 < 2)
            {
                dv2 = 0;
            }
            else
            {
                dv2 = 11 - dv2;
            }
            cpf = cpf + dv2.ToString();

            if (!cpfInformado.Substring(10, 1).Equals(dv2.ToString()))
            {
                lblResultado.Text = "Informe um CPF válido.";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            lblResultado.Text = "CPF Válido";
            lblResultado.ForeColor = Color.Green;
        }

        private void btnCpf_Click(object sender, EventArgs e)
        {
            validaCpf();
        }
    }
}
