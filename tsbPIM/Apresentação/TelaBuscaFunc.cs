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
    public partial class TelaBuscaFunc : Form
    {
        public TelaBuscaFunc()
        {
            InitializeComponent();
        }

        private void TelaBuscaFunc_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pIM4DataSet3.CadFunc'. Você pode movê-la ou removê-la conforme necessário.
            this.cadFuncTableAdapter1.Fill(this.pIM4DataSet3.CadFunc);
            // TODO: esta linha de código carrega dados na tabela 'pIM4DataSet2.CadFunc'. Você pode movê-la ou removê-la conforme necessário.
            this.cadFuncTableAdapter.Fill(this.pIM4DataSet2.CadFunc);

        }

       

        private void dgvFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dgvFuncionario.Rows[e.RowIndex];
            txtBuscaFuncId.Text = linha.Cells[0].Value.ToString();
            txtBuscaFuncNome.Text = linha.Cells[1].Value.ToString();
            txtBuscaFuncEmail.Text = linha.Cells[2].Value.ToString();
            txtBuscaFuncFone.Text = linha.Cells[3].Value.ToString();
            cbBuscaFuncEstCiv.Text = linha.Cells[4].Value.ToString();
            txtBuscaFuncCargo.Text = linha.Cells[5].Value.ToString();
            mktBuscaFuncDataNasc.Text = linha.Cells[6].Value.ToString();
            mktBuscaFuncCpf.Text = linha.Cells[7].Value.ToString();
            cbBuscaFuncSexo.Text = linha.Cells[8].Value.ToString();
            mktBuscaFuncRg.Text = linha.Cells[9].Value.ToString();
            mktBuscaFuncCep.Text = linha.Cells[10].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LoginDaoComandos ldco = new LoginDaoComandos();
            ldco.alterarDadosFunc(int.Parse(txtBuscaFuncId.Text), txtBuscaFuncNome.Text, txtBuscaFuncCargo.Text, Convert.ToDateTime(mktBuscaFuncDataNasc.Text), txtBuscaFuncFone.Text, cbBuscaFuncSexo.Text, mktBuscaFuncCpf.Text, cbBuscaFuncEstCiv.Text, mktBuscaFuncRg.Text, mktBuscaFuncCep.Text, txtBuscaFuncEmail.Text);
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            LoginDaoComandos ldco = new LoginDaoComandos();
            ldco.deletaDadosFunc(int.Parse(txtBuscaFuncId.Text), txtBuscaFuncNome.Text, txtBuscaFuncCargo.Text, Convert.ToDateTime(mktBuscaFuncDataNasc.Text), txtBuscaFuncFone.Text, cbBuscaFuncSexo.Text, mktBuscaFuncCpf.Text, cbBuscaFuncEstCiv.Text, mktBuscaFuncRg.Text, mktBuscaFuncCep.Text, txtBuscaFuncEmail.Text);
        }

        private void mktBuscaFuncCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblCep_Click(object sender, EventArgs e)
        {

        }

        private void cbBuscaFuncSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }

        private void mktBuscaFuncRg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblRg_Click(object sender, EventArgs e)
        {

        }

        private void mktBuscaFuncDataNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mktBuscaFuncCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscaFuncId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbBuscaFuncEstCiv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscaFuncCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscaFuncFone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscaFuncEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscaFuncNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();
            this.Hide();
            func.Show();
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

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
