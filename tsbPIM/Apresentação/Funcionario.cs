using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tsbPIM.Modelo;
using tsbPIM.DAL;

namespace tsbPIM.Apresentação
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCep_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDadosFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void lklVizuFunc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFuncId.Text) || String.IsNullOrEmpty(txtFuncNome.Text) || String.IsNullOrEmpty(txtCargo.Text) || String.IsNullOrEmpty(mktFuncDataNasc.Text) || String.IsNullOrEmpty(mktFuncFone.Text) || String.IsNullOrEmpty(cbFuncSexo.Text) || String.IsNullOrEmpty(mktFuncCpf.Text) || String.IsNullOrEmpty(cbFuncEstCiv.Text) || String.IsNullOrEmpty(mktFuncRg.Text) || String.IsNullOrEmpty(mktFuncCep.Text) || String.IsNullOrEmpty(txtFuncEmail.Text))
            {
                MessageBox.Show("Campos obrigatórios não preenchidos, verifique e tente novamente!!!");
                return;
            }


            LoginDaoComandos ldco = new LoginDaoComandos();
            ldco.cadFunc( int.Parse(txtFuncId.Text), txtFuncNome.Text, txtCargo.Text, Convert.ToDateTime(mktFuncDataNasc.Text), mktFuncFone.Text, cbFuncSexo.Text, mktFuncCpf.Text, cbFuncEstCiv.Text, mktFuncRg.Text, mktFuncCep.Text, txtFuncEmail.Text);
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Funcionario_Load(object sender, EventArgs e)
        {


        }

        private void txtIdFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            menuTSB menu = new menuTSB();
            this.Hide();
            menu.Show();
        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            TelaBuscaFunc buscaFunc = new TelaBuscaFunc();
            this.Hide();
            buscaFunc.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
