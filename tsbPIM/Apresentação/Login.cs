using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tsbPIM.Apresentação;
using tsbPIM.Modelo;

namespace tsbPIM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtEmail.Text, txtSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menuTSB men = new menuTSB();
                    men.Show();
                }
                else
                {
                    MessageBox.Show("Dados incorretos, verifique e tente novamente", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RedefinirSenha senhaNova = new RedefinirSenha();
            senhaNova.Show();
        }
    }
}
