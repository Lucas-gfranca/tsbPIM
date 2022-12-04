using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tsbPIM.Apresentação
{
    public partial class menuTSB : Form
    {
        public menuTSB()
        {
            InitializeComponent();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();
            this.Hide();
            func.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadCliente = new CadastrarCliente();
            this.Hide();
            cadCliente.Show();
        }

        private void btnAssistencia_Click(object sender, EventArgs e)
        {
            Assistencia assist = new Assistencia();
            this.Hide();
            assist.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        

        private void lblTSB_Click(object sender, EventArgs e)
        {

        }

        private void lblVersao_Click(object sender, EventArgs e)
        {

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            this.Hide();
            vendas.Show();
        }
    }
}
