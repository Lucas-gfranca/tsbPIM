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
using tsbPIM.Modelo;

namespace tsbPIM.Apresentação
{
    public partial class Vendas : Form
    {
        List<DropDown> lstDropDown = new List<DropDown>();
        List<ClientesDropDown> lstClientesDropDown = new List<ClientesDropDown>();
        List<SeguradoraDropDown> lstSeguradoraDropDown = new List<SeguradoraDropDown>();
        public Vendas()
        {
            InitializeComponent();
            LoginDaoComandos dao = new LoginDaoComandos();
            var lstTemp = dao.selecionarFunc();
            lstTemp.ForEach((e) => lstDropDown.Add(new DropDown(e.funcId, e.funcNome)));
            foreach(var item in lstDropDown)
            {
                cbDropFuncionario.Items.Add(item.Name);
            }

            var lstTemp2 = dao.selecionarCliente();
            lstTemp2.ForEach((e) => lstClientesDropDown.Add(new ClientesDropDown(e.idCliente, e.nomeCliente)));
            foreach(var item in lstClientesDropDown)
            {
                cbDropCLientes.Items.Add(item.Name);
            }

            var lstTemp3 = dao.selecionarSeguradora();
            lstTemp3.ForEach((e) => lstSeguradoraDropDown.Add(new SeguradoraDropDown(e.idSeguradora, e.tipoServico)));
            foreach (var item in lstSeguradoraDropDown)
            {
                cbDropServicos.Items.Add(item.Name);
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbPlanos.Text) || String.IsNullOrEmpty(mktDataVenda.Text))
            {
                MessageBox.Show("Campos obrigatórios não preenchidos, verifique e tente novamente!!!");
                return;
            }
            var funcionario = lstDropDown.Find((fnc) => fnc.Name == cbDropFuncionario.Text);
            var seguradora = lstSeguradoraDropDown.Find((sgr) => sgr.Name == cbDropServicos.Text);
            var cliente = lstClientesDropDown.Find((clt) => clt.Name == cbDropCLientes.Text);

            LoginDaoComandos ldco = new LoginDaoComandos();
            ldco.inserirVenda(cbPlanos.Text, Convert.ToDateTime(mktDataVenda.Text), cliente.Id, funcionario.Id, seguradora.Id);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            menuTSB menu = new menuTSB();
            this.Hide();
            menu.Show();
        }

        private void btnBuscarSeguradora_Click(object sender, EventArgs e)
        {
            TelaBuscaVenda buscaVendas = new TelaBuscaVenda();
            this.Hide();
            buscaVendas.Show();
        }
    }
}
