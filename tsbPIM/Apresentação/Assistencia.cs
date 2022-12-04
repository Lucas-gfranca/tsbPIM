using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tsbPIM.DAL;


namespace tsbPIM.Apresentação
{
    public partial class Assistencia : Form
    {
        public Assistencia()
        {
            InitializeComponent();
        }

        private void btnBuscarSeguradora_Click(object sender, EventArgs e)
        {
            TelaBuscaSeguradora BuscaSeg = new TelaBuscaSeguradora();
            this.Hide();
            BuscaSeg.Show();
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            menuTSB men = new menuTSB();
            this.Hide();
            men.Show();
        }

        private void btnCadastrarSeguradora_Click(object sender, EventArgs e)
        {
            LoginDaoComandos ldco = new LoginDaoComandos();
            ldco.cadSeguradadora(int.Parse(txtIdSeguradora.Text), cbTipoServico.Text, txtSeguradoraNome.Text, txtSeguradoraEmail.Text, mktClienteFone.Text, mktSeguradoraCnpj.Text, txtRuaSeguradora.Text, int.Parse(txtNumeroSeguradora.Text), txtBairroSeguradora.Text, txtCidadeSeguradora.Text, cbUfSeguradora.Text, txtComplementoSeguradora.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
