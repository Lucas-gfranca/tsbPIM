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
    public partial class TelaBuscaVenda : Form
    {
        public TelaBuscaVenda()
        {
            InitializeComponent();
        }

        private void TelaBuscaVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pIM4DataSet11.vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.Fill(this.pIM4DataSet11.vendas);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            menuTSB men = new menuTSB();
            this.Hide();
            men.Show();
        }

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            this.Hide();
            vendas.Show();
        }
    }
}
