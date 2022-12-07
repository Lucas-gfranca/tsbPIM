namespace tsbPIM.Apresentação
{
    partial class Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblTSB = new System.Windows.Forms.Label();
            this.panelFuncionario = new System.Windows.Forms.Panel();
            this.cbDropServicos = new System.Windows.Forms.ComboBox();
            this.cbDropCLientes = new System.Windows.Forms.ComboBox();
            this.cbFomaPagamento = new System.Windows.Forms.ComboBox();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.cbDropFuncionario = new System.Windows.Forms.ComboBox();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtVendaId = new System.Windows.Forms.TextBox();
            this.cbPlanos = new System.Windows.Forms.ComboBox();
            this.mktDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDadosVendas = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.btnCadSeguradora = new System.Windows.Forms.Button();
            this.btnBuscarSeguradora = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            this.panelFuncionario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelLogo.Controls.Add(this.btnSair);
            this.panelLogo.Controls.Add(this.lblMenu);
            this.panelLogo.Controls.Add(this.lblTSB);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1827, 171);
            this.panelLogo.TabIndex = 131;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(1665, 34);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(132, 47);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMenu.Location = new System.Drawing.Point(792, 22);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(471, 135);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Vendas";
            // 
            // lblTSB
            // 
            this.lblTSB.AutoSize = true;
            this.lblTSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTSB.Location = new System.Drawing.Point(4, 22);
            this.lblTSB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTSB.Name = "lblTSB";
            this.lblTSB.Size = new System.Drawing.Size(293, 135);
            this.lblTSB.TabIndex = 1;
            this.lblTSB.Text = "TSB";
            // 
            // panelFuncionario
            // 
            this.panelFuncionario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelFuncionario.Controls.Add(this.cbDropServicos);
            this.panelFuncionario.Controls.Add(this.cbDropCLientes);
            this.panelFuncionario.Controls.Add(this.cbFomaPagamento);
            this.panelFuncionario.Controls.Add(this.lblFormaPagamento);
            this.panelFuncionario.Controls.Add(this.cbDropFuncionario);
            this.panelFuncionario.Controls.Add(this.bntCancelar);
            this.panelFuncionario.Controls.Add(this.btnCadastrar);
            this.panelFuncionario.Controls.Add(this.txtVendaId);
            this.panelFuncionario.Controls.Add(this.cbPlanos);
            this.panelFuncionario.Controls.Add(this.mktDataVenda);
            this.panelFuncionario.Controls.Add(this.lblEmail);
            this.panelFuncionario.Controls.Add(this.lblId);
            this.panelFuncionario.Controls.Add(this.lblDadosVendas);
            this.panelFuncionario.Controls.Add(this.lblData);
            this.panelFuncionario.Controls.Add(this.lblNomeFunc);
            this.panelFuncionario.Controls.Add(this.lblCargo);
            this.panelFuncionario.Controls.Add(this.lblSexo);
            this.panelFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFuncionario.Location = new System.Drawing.Point(719, 174);
            this.panelFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFuncionario.Name = "panelFuncionario";
            this.panelFuncionario.Size = new System.Drawing.Size(673, 747);
            this.panelFuncionario.TabIndex = 132;
            // 
            // cbDropServicos
            // 
            this.cbDropServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDropServicos.FormattingEnabled = true;
            this.cbDropServicos.Location = new System.Drawing.Point(393, 218);
            this.cbDropServicos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDropServicos.Name = "cbDropServicos";
            this.cbDropServicos.Size = new System.Drawing.Size(252, 38);
            this.cbDropServicos.TabIndex = 52;
            // 
            // cbDropCLientes
            // 
            this.cbDropCLientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDropCLientes.FormattingEnabled = true;
            this.cbDropCLientes.Location = new System.Drawing.Point(52, 218);
            this.cbDropCLientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDropCLientes.Name = "cbDropCLientes";
            this.cbDropCLientes.Size = new System.Drawing.Size(252, 38);
            this.cbDropCLientes.TabIndex = 51;
            // 
            // cbFomaPagamento
            // 
            this.cbFomaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFomaPagamento.FormattingEnabled = true;
            this.cbFomaPagamento.Items.AddRange(new object[] {
            "Débito",
            "Crédito",
            "Boleto",
            "Pix"});
            this.cbFomaPagamento.Location = new System.Drawing.Point(53, 390);
            this.cbFomaPagamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFomaPagamento.Name = "cbFomaPagamento";
            this.cbFomaPagamento.Size = new System.Drawing.Size(231, 38);
            this.cbFomaPagamento.TabIndex = 49;
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPagamento.Location = new System.Drawing.Point(48, 362);
            this.lblFormaPagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(210, 25);
            this.lblFormaPagamento.TabIndex = 50;
            this.lblFormaPagamento.Text = "Formas de Pagamento";
            // 
            // cbDropFuncionario
            // 
            this.cbDropFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDropFuncionario.FormattingEnabled = true;
            this.cbDropFuncionario.Location = new System.Drawing.Point(52, 310);
            this.cbDropFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDropFuncionario.Name = "cbDropFuncionario";
            this.cbDropFuncionario.Size = new System.Drawing.Size(223, 38);
            this.cbDropFuncionario.TabIndex = 48;
            // 
            // bntCancelar
            // 
            this.bntCancelar.BackColor = System.Drawing.Color.Red;
            this.bntCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntCancelar.Location = new System.Drawing.Point(368, 614);
            this.bntCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(199, 80);
            this.bntCancelar.TabIndex = 47;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Location = new System.Drawing.Point(77, 614);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(199, 80);
            this.btnCadastrar.TabIndex = 46;
            this.btnCadastrar.Text = "Finalizar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtVendaId
            // 
            this.txtVendaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendaId.Location = new System.Drawing.Point(53, 130);
            this.txtVendaId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVendaId.Name = "txtVendaId";
            this.txtVendaId.Size = new System.Drawing.Size(80, 37);
            this.txtVendaId.TabIndex = 45;
            // 
            // cbPlanos
            // 
            this.cbPlanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlanos.FormattingEnabled = true;
            this.cbPlanos.Items.AddRange(new object[] {
            "Básico",
            "Seguro+",
            "Seguro Masters Premmium"});
            this.cbPlanos.Location = new System.Drawing.Point(393, 306);
            this.cbPlanos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPlanos.Name = "cbPlanos";
            this.cbPlanos.Size = new System.Drawing.Size(252, 38);
            this.cbPlanos.TabIndex = 27;
            // 
            // mktDataVenda
            // 
            this.mktDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktDataVenda.Location = new System.Drawing.Point(395, 393);
            this.mktDataVenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mktDataVenda.Mask = "00/00/0000";
            this.mktDataVenda.Name = "mktDataVenda";
            this.mktDataVenda.Size = new System.Drawing.Size(156, 37);
            this.mktDataVenda.TabIndex = 38;
            this.mktDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(49, 282);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(114, 25);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Funcionário";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(49, 107);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblDadosVendas
            // 
            this.lblDadosVendas.AutoSize = true;
            this.lblDadosVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosVendas.Location = new System.Drawing.Point(144, 21);
            this.lblDadosVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDadosVendas.Name = "lblDadosVendas";
            this.lblDadosVendas.Size = new System.Drawing.Size(340, 31);
            this.lblDadosVendas.TabIndex = 1;
            this.lblDadosVendas.Text = "Insira os dados da venda";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(392, 369);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(53, 25);
            this.lblData.TabIndex = 32;
            this.lblData.Text = "Data";
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFunc.Location = new System.Drawing.Point(49, 191);
            this.lblNomeFunc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(73, 25);
            this.lblNomeFunc.TabIndex = 27;
            this.lblNomeFunc.Text = "Cliente";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(389, 194);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(78, 25);
            this.lblCargo.TabIndex = 28;
            this.lblCargo.Text = "Serviço";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(388, 278);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(72, 25);
            this.lblSexo.TabIndex = 29;
            this.lblSexo.Text = "Planos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnVoltarMenu);
            this.panel1.Controls.Add(this.btnCadSeguradora);
            this.panel1.Controls.Add(this.btnBuscarSeguradora);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1, 174);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 747);
            this.panel1.TabIndex = 133;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 36);
            this.label7.TabIndex = 10;
            this.label7.Text = "Opções";
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarMenu.Location = new System.Drawing.Point(-1, 492);
            this.btnVoltarMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(296, 75);
            this.btnVoltarMenu.TabIndex = 7;
            this.btnVoltarMenu.Text = "Voltar ao Menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // btnCadSeguradora
            // 
            this.btnCadSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadSeguradora.Location = new System.Drawing.Point(-1, 84);
            this.btnCadSeguradora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadSeguradora.Name = "btnCadSeguradora";
            this.btnCadSeguradora.Size = new System.Drawing.Size(296, 75);
            this.btnCadSeguradora.TabIndex = 5;
            this.btnCadSeguradora.Text = "Cadastrar Venda";
            this.btnCadSeguradora.UseVisualStyleBackColor = true;
            // 
            // btnBuscarSeguradora
            // 
            this.btnBuscarSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarSeguradora.Location = new System.Drawing.Point(-1, 169);
            this.btnBuscarSeguradora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarSeguradora.Name = "btnBuscarSeguradora";
            this.btnBuscarSeguradora.Size = new System.Drawing.Size(296, 75);
            this.btnBuscarSeguradora.TabIndex = 4;
            this.btnBuscarSeguradora.Text = "Buscar Venda";
            this.btnBuscarSeguradora.UseVisualStyleBackColor = true;
            this.btnBuscarSeguradora.Click += new System.EventHandler(this.btnBuscarSeguradora_Click);
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFuncionario);
            this.Controls.Add(this.panelLogo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelFuncionario.ResumeLayout(false);
            this.panelFuncionario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblTSB;
        private System.Windows.Forms.Panel panelFuncionario;
        private System.Windows.Forms.ComboBox cbDropCLientes;
        private System.Windows.Forms.ComboBox cbFomaPagamento;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.ComboBox cbDropFuncionario;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtVendaId;
        private System.Windows.Forms.ComboBox cbPlanos;
        private System.Windows.Forms.MaskedTextBox mktDataVenda;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDadosVendas;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Button btnCadSeguradora;
        private System.Windows.Forms.Button btnBuscarSeguradora;
        private System.Windows.Forms.ComboBox cbDropServicos;
    }
}