﻿using System;
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
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblDadosFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void panelFuncionario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            menuTSB menu = new menuTSB();
            menu.Show();
       
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            LoginDaoComandos ldco = new LoginDaoComandos();
            ldco.cadCliente(int.Parse(txtIdCliente.Text), ckbClientePj.Checked,  txtClienteNome.Text, mktClienteFone.Text, mktClienteCpf.Text, mktClienteRg.Text, txtClienteEmail.Text, mktClienteDataNasc.Text, cbClienteSexo.Text, cbClienteEstCiv.Text, float.Parse(txtAltura.Text), float.Parse(txtPeso.Text), cbkFumante.Checked, cbkCirurgia.Checked, cbkDoenca.Checked, txtRua.Text, int.Parse(txtNumero.Text), txtBairro.Text, txtCidade.Text, cbUf.Text, txtComplemento.Text);
        }

        private void cbkFumante_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
