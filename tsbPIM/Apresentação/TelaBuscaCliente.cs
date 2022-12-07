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
    public partial class TelaBuscaCliente : Form
    {
        public TelaBuscaCliente()
        {
            InitializeComponent();
        }

        private void TelaBusca_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pIM4DataSet10.dadosCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.dadosClienteTableAdapter3.Fill(this.pIM4DataSet10.dadosCliente);

        }
        private void pesquisaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pesquisaClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pesquisaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = pesquisaClientes.Rows[e.RowIndex];
            txtBuscaId.Text = linha.Cells[0].Value.ToString();
            ckbBuscaClientePj.Text = linha.Cells[1].Value.ToString();
            txtBuscaNome.Text = linha.Cells[2].Value.ToString();
            txtBuscaFone.Text = linha.Cells[3].Value.ToString();
            txtBuscaEmail.Text = linha.Cells[4].Value.ToString();
            mktBuscaClienteCpf.Text = linha.Cells[5].Value.ToString();
            mktBuscaClienteRg.Text = linha.Cells[6].Value.ToString();
            mktBuscaClienteDataNasc.Text = linha.Cells[7].Value.ToString();
            cbBuscaClienteSexo.Text = linha.Cells[8].Value.ToString();
            cbBuscaEstCiv.Text = linha.Cells[9].Value.ToString();
            txtBuscaAltura.Text = linha.Cells[10].Value.ToString();
            txtBuscaPeso.Text = linha.Cells[11].Value.ToString();
            cbkBuscaFumante.Text = linha.Cells[12].Value.ToString();
            cbkBuscaCirurgia.Text = linha.Cells[13].Value.ToString();
            cbkBuscaDoenca.Text = linha.Cells[14].Value.ToString();
            txtBuscaRua.Text = linha.Cells[15].Value.ToString();
            txtBuscaNumero.Text = linha.Cells[16].Value.ToString();
            txtBuscaCidade.Text = linha.Cells[17].Value.ToString();
            cbBuscaUf.Text = linha.Cells[18].Value.ToString();
            txtBuscaBairro.Text = linha.Cells[19].Value.ToString();
            txtBuscaComplemento.Text = linha.Cells[20].Value.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LoginDaoComandos ldco = new LoginDaoComandos();
            ldco.alterarDadosCliente(int.Parse(txtBuscaId.Text), ckbBuscaClientePj.Checked, txtBuscaNome.Text, txtBuscaFone.Text, txtBuscaEmail.Text, mktBuscaClienteCpf.Text, mktBuscaClienteRg.Text, Convert.ToDateTime(mktBuscaClienteDataNasc.Text), cbBuscaClienteSexo.Text, cbBuscaEstCiv.Text, float.Parse(txtBuscaAltura.Text), float.Parse(txtBuscaPeso.Text), cbkBuscaFumante.Checked, cbkBuscaCirurgia.Checked, cbkBuscaDoenca.Checked, txtBuscaRua.Text, int.Parse(txtBuscaNumero.Text), txtBuscaBairro.Text, txtBuscaCidade.Text, cbBuscaUf.Text, txtBuscaComplemento.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            LoginDaoComandos ldco = new LoginDaoComandos();
            ldco.deletaClientes(int.Parse(txtBuscaId.Text), ckbBuscaClientePj.Checked, txtBuscaNome.Text, txtBuscaFone.Text, txtBuscaEmail.Text,  mktBuscaClienteCpf.Text, mktBuscaClienteRg.Text, Convert.ToDateTime(mktBuscaClienteDataNasc.Text), cbBuscaClienteSexo.Text, cbBuscaEstCiv.Text, float.Parse(txtBuscaAltura.Text), float.Parse(txtBuscaPeso.Text), cbkBuscaFumante.Checked, cbkBuscaCirurgia.Checked, cbkBuscaDoenca.Checked, txtBuscaRua.Text, int.Parse(txtBuscaNumero.Text), txtBuscaBairro.Text, txtBuscaCidade.Text, cbBuscaUf.Text,  txtBuscaComplemento.Text); 
        }

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            menuTSB men = new menuTSB();
            this.Hide();
            men.Show();
        }

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadCliente = new CadastrarCliente();
            this.Hide();
            cadCliente.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
