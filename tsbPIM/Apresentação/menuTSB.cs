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
    public partial class menuTSB : Form
    {
        public menuTSB()
        {
            InitializeComponent();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();
            func.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadCliente = new CadastrarCliente();
            cadCliente.Show();
        }
    }
}
