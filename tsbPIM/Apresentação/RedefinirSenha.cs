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
    public partial class RedefinirSenha : Form
    {
        public RedefinirSenha()
        {
            InitializeComponent();
        }

        private void bntVoltar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
