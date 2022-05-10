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

            lblResultado.Text = cpfInformado;

            if(cpfInformado.Length != 11)
            {
                lblResultado.Text = "Informe um CPF com 11 digitos.";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            string cpf = cpfInformado.Substring(0, 9);

            int soma = 0;
            int valorRef = 10;


        }

        private void btnCpf_Click(object sender, EventArgs e)
        {
            validaCpf();
        }
    }
}
