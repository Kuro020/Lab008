using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab008.View.Tabuada
{
    public partial class TelaTabuada : Form
    {
        public TelaTabuada()
        {
            InitializeComponent();
        }
        private void CalcularTabuada()
        {
            int numero = 0;

            numero = Convert.ToInt32(tbxTabuada.Text);

            for (int i = 0; i <= 10; i++)
            {
               lbxResultado.Items.Add(numero + "x" + i + "=" + numero* i);
            }
            tbxTabuada.Focus();
            tbxTabuada.SelectAll();
        }
        private void LimparTela()
        {
            lbxResultado.Items.Clear();
            tbxTabuada.Clear();
            tbxTabuada.Focus();
        }

        private void TelaTabuada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                lbxResultado.Items.Clear();
                CalcularTabuada();
            }
            if(e.KeyChar == 27)
            {
                LimparTela();
            }
        }
    }
}
