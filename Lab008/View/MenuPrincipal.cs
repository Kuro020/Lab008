using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab008.View;

namespace Lab008.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabuada.TelaTabuada Tabuada = new Tabuada.TelaTabuada();
            Tabuada.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CPF.lblCpf cpf = new CPF.lblCpf();
            cpf.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
