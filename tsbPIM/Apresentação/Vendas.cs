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
            LoginDaoComandos ldco = new LoginDaoComandos();
            ldco.inserirVenda(int.Parse(txtVendaId.Text), cbPlanos.Text, Convert.ToDateTime(mktDataVenda.Text), cbDropCLientes.Text, cbDropServicos.Text, cbDropFuncionario.Text);
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
    }
}
