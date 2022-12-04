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
    public partial class TelaBuscaSeguradora : Form
    {
        public TelaBuscaSeguradora()
        {
            InitializeComponent();
        }

        private void TelaBuscaSeguradora_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pIM4DataSet4.seguradora'. Você pode movê-la ou removê-la conforme necessário.
            this.seguradoraTableAdapter.Fill(this.pIM4DataSet4.seguradora);

        }

        private void dgvFuncionario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dgvFuncionario.Rows[e.RowIndex];
            txtBuscaSegId.Text = linha.Cells[0].Value.ToString();
            txtBuscaSegNome.Text = linha.Cells[1].Value.ToString();
            mktBuscaSegCnpj.Text = linha.Cells[2].Value.ToString();
            txtBuscaSegFone.Text = linha.Cells[3].Value.ToString();
            txtBuscaSegEmail.Text = linha.Cells[4].Value.ToString();
            cbBuscaTipoServico.Text = linha.Cells[5].Value.ToString();
            txtBuscaSegRua.Text = linha.Cells[6].Value.ToString();
            txtBuscaSegNum.Text = linha.Cells[7].Value.ToString();
            txtBuscaSegBairro.Text = linha.Cells[8].Value.ToString();
            txtBuscaSegCidade.Text = linha.Cells[9].Value.ToString();
            cbBuscaUfSeguradora.Text = linha.Cells[10].Value.ToString();
            txtBuscaSegComp.Text = linha.Cells[11].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LoginDaoComandos ldco = new LoginDaoComandos();
            ldco.alterarDadosSeguradadora(int.Parse(txtBuscaSegId.Text), cbBuscaTipoServico.Text, txtBuscaSegNome.Text, txtBuscaSegEmail.Text, txtBuscaSegFone.Text, mktBuscaSegCnpj.Text, txtBuscaSegRua.Text, int.Parse(txtBuscaSegNum.Text), txtBuscaSegBairro.Text, txtBuscaSegCidade.Text, cbBuscaUfSeguradora.Text, txtBuscaSegComp.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            LoginDaoComandos ldco = new LoginDaoComandos();
            ldco.deletaDadosSeguradadora(int.Parse(txtBuscaSegId.Text), cbBuscaTipoServico.Text, txtBuscaSegNome.Text, txtBuscaSegEmail.Text, txtBuscaSegFone.Text, mktBuscaSegCnpj.Text, txtBuscaSegRua.Text, int.Parse(txtBuscaSegNum.Text), txtBuscaSegBairro.Text, txtBuscaSegCidade.Text, cbBuscaUfSeguradora.Text, txtBuscaSegComp.Text);
        }

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            Assistencia assist = new Assistencia();
            this.Hide();
            assist.Show();
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            menuTSB men = new menuTSB();
            this.Hide();
            men.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
