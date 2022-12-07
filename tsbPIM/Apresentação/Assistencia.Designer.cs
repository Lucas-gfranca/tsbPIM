namespace tsbPIM.Apresentação
{
    partial class Assistencia
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
            this.panelFuncionario = new System.Windows.Forms.Panel();
            this.cbTipoServico = new System.Windows.Forms.ComboBox();
            this.lblTipoServico = new System.Windows.Forms.Label();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.btnCadastrarSeguradora = new System.Windows.Forms.Button();
            this.txtComplementoSeguradora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroSeguradora = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtCidadeSeguradora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairroSeguradora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRuaSeguradora = new System.Windows.Forms.TextBox();
            this.cbUfSeguradora = new System.Windows.Forms.ComboBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeguradoraEmail = new System.Windows.Forms.TextBox();
            this.txtIdSeguradora = new System.Windows.Forms.TextBox();
            this.txtSeguradoraNome = new System.Windows.Forms.TextBox();
            this.mktClienteFone = new System.Windows.Forms.MaskedTextBox();
            this.mktSeguradoraCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDadosFuncionario = new System.Windows.Forms.Label();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblSeguradoras = new System.Windows.Forms.Label();
            this.lblTSB = new System.Windows.Forms.Label();
            this.btnBuscarSeguradora = new System.Windows.Forms.Button();
            this.btnCadSeguradora = new System.Windows.Forms.Button();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelFuncionario.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFuncionario
            // 
            this.panelFuncionario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFuncionario.Controls.Add(this.cbTipoServico);
            this.panelFuncionario.Controls.Add(this.lblTipoServico);
            this.panelFuncionario.Controls.Add(this.bntCancelar);
            this.panelFuncionario.Controls.Add(this.btnCadastrarSeguradora);
            this.panelFuncionario.Controls.Add(this.txtComplementoSeguradora);
            this.panelFuncionario.Controls.Add(this.label6);
            this.panelFuncionario.Controls.Add(this.txtNumeroSeguradora);
            this.panelFuncionario.Controls.Add(this.lblNumero);
            this.panelFuncionario.Controls.Add(this.txtCidadeSeguradora);
            this.panelFuncionario.Controls.Add(this.label5);
            this.panelFuncionario.Controls.Add(this.txtBairroSeguradora);
            this.panelFuncionario.Controls.Add(this.label4);
            this.panelFuncionario.Controls.Add(this.txtRuaSeguradora);
            this.panelFuncionario.Controls.Add(this.cbUfSeguradora);
            this.panelFuncionario.Controls.Add(this.lblRua);
            this.panelFuncionario.Controls.Add(this.lblEstado);
            this.panelFuncionario.Controls.Add(this.label2);
            this.panelFuncionario.Controls.Add(this.txtSeguradoraEmail);
            this.panelFuncionario.Controls.Add(this.txtIdSeguradora);
            this.panelFuncionario.Controls.Add(this.txtSeguradoraNome);
            this.panelFuncionario.Controls.Add(this.mktClienteFone);
            this.panelFuncionario.Controls.Add(this.mktSeguradoraCnpj);
            this.panelFuncionario.Controls.Add(this.lblTelefone);
            this.panelFuncionario.Controls.Add(this.lblEmail);
            this.panelFuncionario.Controls.Add(this.lblId);
            this.panelFuncionario.Controls.Add(this.lblDadosFuncionario);
            this.panelFuncionario.Controls.Add(this.lblNomeFunc);
            this.panelFuncionario.Controls.Add(this.lblCnpj);
            this.panelFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFuncionario.Location = new System.Drawing.Point(708, 174);
            this.panelFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFuncionario.Name = "panelFuncionario";
            this.panelFuncionario.Size = new System.Drawing.Size(609, 747);
            this.panelFuncionario.TabIndex = 31;
            // 
            // cbTipoServico
            // 
            this.cbTipoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoServico.FormattingEnabled = true;
            this.cbTipoServico.Items.AddRange(new object[] {
            "Assist. Funerária",
            "Seguro de vida",
            "Médico",
            "Financeiro"});
            this.cbTipoServico.Location = new System.Drawing.Point(280, 89);
            this.cbTipoServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTipoServico.Name = "cbTipoServico";
            this.cbTipoServico.Size = new System.Drawing.Size(183, 38);
            this.cbTipoServico.TabIndex = 85;
            // 
            // lblTipoServico
            // 
            this.lblTipoServico.AutoSize = true;
            this.lblTipoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServico.Location = new System.Drawing.Point(275, 65);
            this.lblTipoServico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoServico.Name = "lblTipoServico";
            this.lblTipoServico.Size = new System.Drawing.Size(145, 25);
            this.lblTipoServico.TabIndex = 86;
            this.lblTipoServico.Text = "Tipo de serviço";
            // 
            // bntCancelar
            // 
            this.bntCancelar.BackColor = System.Drawing.Color.Red;
            this.bntCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntCancelar.Location = new System.Drawing.Point(347, 639);
            this.bntCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(199, 80);
            this.bntCancelar.TabIndex = 84;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarSeguradora
            // 
            this.btnCadastrarSeguradora.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCadastrarSeguradora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarSeguradora.Location = new System.Drawing.Point(60, 639);
            this.btnCadastrarSeguradora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrarSeguradora.Name = "btnCadastrarSeguradora";
            this.btnCadastrarSeguradora.Size = new System.Drawing.Size(199, 80);
            this.btnCadastrarSeguradora.TabIndex = 83;
            this.btnCadastrarSeguradora.Text = "Cadastrar";
            this.btnCadastrarSeguradora.UseVisualStyleBackColor = false;
            this.btnCadastrarSeguradora.Click += new System.EventHandler(this.btnCadastrarSeguradora_Click);
            // 
            // txtComplementoSeguradora
            // 
            this.txtComplementoSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplementoSeguradora.Location = new System.Drawing.Point(28, 529);
            this.txtComplementoSeguradora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComplementoSeguradora.Name = "txtComplementoSeguradora";
            this.txtComplementoSeguradora.Size = new System.Drawing.Size(349, 37);
            this.txtComplementoSeguradora.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 501);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 81;
            this.label6.Text = "Complemento";
            // 
            // txtNumeroSeguradora
            // 
            this.txtNumeroSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroSeguradora.Location = new System.Drawing.Point(484, 375);
            this.txtNumeroSeguradora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroSeguradora.Name = "txtNumeroSeguradora";
            this.txtNumeroSeguradora.Size = new System.Drawing.Size(103, 37);
            this.txtNumeroSeguradora.TabIndex = 80;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(487, 353);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(33, 25);
            this.lblNumero.TabIndex = 79;
            this.lblNumero.Text = "Nº";
            // 
            // txtCidadeSeguradora
            // 
            this.txtCidadeSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeSeguradora.Location = new System.Drawing.Point(249, 446);
            this.txtCidadeSeguradora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCidadeSeguradora.Name = "txtCidadeSeguradora";
            this.txtCidadeSeguradora.Size = new System.Drawing.Size(213, 37);
            this.txtCidadeSeguradora.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 423);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 77;
            this.label5.Text = "Cidade";
            // 
            // txtBairroSeguradora
            // 
            this.txtBairroSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroSeguradora.Location = new System.Drawing.Point(28, 446);
            this.txtBairroSeguradora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBairroSeguradora.Name = "txtBairroSeguradora";
            this.txtBairroSeguradora.Size = new System.Drawing.Size(212, 37);
            this.txtBairroSeguradora.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 423);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 75;
            this.label4.Text = "Bairro";
            // 
            // txtRuaSeguradora
            // 
            this.txtRuaSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuaSeguradora.Location = new System.Drawing.Point(28, 375);
            this.txtRuaSeguradora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRuaSeguradora.Name = "txtRuaSeguradora";
            this.txtRuaSeguradora.Size = new System.Drawing.Size(411, 37);
            this.txtRuaSeguradora.TabIndex = 74;
            // 
            // cbUfSeguradora
            // 
            this.cbUfSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUfSeguradora.FormattingEnabled = true;
            this.cbUfSeguradora.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUfSeguradora.Location = new System.Drawing.Point(483, 446);
            this.cbUfSeguradora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUfSeguradora.Name = "cbUfSeguradora";
            this.cbUfSeguradora.Size = new System.Drawing.Size(104, 38);
            this.cbUfSeguradora.TabIndex = 71;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(27, 353);
            this.lblRua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(47, 25);
            this.lblRua.TabIndex = 72;
            this.lblRua.Text = "Rua";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(487, 417);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(31, 25);
            this.lblEstado.TabIndex = 73;
            this.lblEstado.Text = "Uf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 337);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 56;
            this.label2.Text = "Endereço";
            // 
            // txtSeguradoraEmail
            // 
            this.txtSeguradoraEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeguradoraEmail.Location = new System.Drawing.Point(280, 174);
            this.txtSeguradoraEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSeguradoraEmail.Name = "txtSeguradoraEmail";
            this.txtSeguradoraEmail.Size = new System.Drawing.Size(307, 37);
            this.txtSeguradoraEmail.TabIndex = 48;
            // 
            // txtIdSeguradora
            // 
            this.txtIdSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSeguradora.Location = new System.Drawing.Point(41, 89);
            this.txtIdSeguradora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdSeguradora.Name = "txtIdSeguradora";
            this.txtIdSeguradora.Size = new System.Drawing.Size(99, 37);
            this.txtIdSeguradora.TabIndex = 45;
            // 
            // txtSeguradoraNome
            // 
            this.txtSeguradoraNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeguradoraNome.Location = new System.Drawing.Point(44, 169);
            this.txtSeguradoraNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSeguradoraNome.Name = "txtSeguradoraNome";
            this.txtSeguradoraNome.Size = new System.Drawing.Size(197, 37);
            this.txtSeguradoraNome.TabIndex = 43;
            // 
            // mktClienteFone
            // 
            this.mktClienteFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktClienteFone.Location = new System.Drawing.Point(280, 245);
            this.mktClienteFone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mktClienteFone.Mask = "(00)90000-0000";
            this.mktClienteFone.Name = "mktClienteFone";
            this.mktClienteFone.Size = new System.Drawing.Size(217, 37);
            this.mktClienteFone.TabIndex = 41;
            // 
            // mktSeguradoraCnpj
            // 
            this.mktSeguradoraCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktSeguradoraCnpj.Location = new System.Drawing.Point(44, 245);
            this.mktSeguradoraCnpj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mktSeguradoraCnpj.Mask = "000000000-00";
            this.mktSeguradoraCnpj.Name = "mktSeguradoraCnpj";
            this.mktSeguradoraCnpj.Size = new System.Drawing.Size(197, 37);
            this.mktSeguradoraCnpj.TabIndex = 32;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(284, 217);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(89, 25);
            this.lblTelefone.TabIndex = 34;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(285, 145);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 25);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "E-mail";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(40, 65);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblDadosFuncionario
            // 
            this.lblDadosFuncionario.AutoSize = true;
            this.lblDadosFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosFuncionario.Location = new System.Drawing.Point(103, 12);
            this.lblDadosFuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDadosFuncionario.Name = "lblDadosFuncionario";
            this.lblDadosFuncionario.Size = new System.Drawing.Size(408, 31);
            this.lblDadosFuncionario.TabIndex = 1;
            this.lblDadosFuncionario.Text = "Insira os dados da seguradora";
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFunc.Location = new System.Drawing.Point(39, 140);
            this.lblNomeFunc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(137, 25);
            this.lblNomeFunc.TabIndex = 27;
            this.lblNomeFunc.Text = "Nome fantasia";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(39, 217);
            this.lblCnpj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(65, 25);
            this.lblCnpj.TabIndex = 30;
            this.lblCnpj.Text = "CNPJ";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelLogo.Controls.Add(this.btnSair);
            this.panelLogo.Controls.Add(this.lblSeguradoras);
            this.panelLogo.Controls.Add(this.lblTSB);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1827, 171);
            this.panelLogo.TabIndex = 30;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(1684, 22);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(132, 47);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblSeguradoras
            // 
            this.lblSeguradoras.AutoSize = true;
            this.lblSeguradoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguradoras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeguradoras.Location = new System.Drawing.Point(635, 22);
            this.lblSeguradoras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeguradoras.Name = "lblSeguradoras";
            this.lblSeguradoras.Size = new System.Drawing.Size(696, 135);
            this.lblSeguradoras.TabIndex = 2;
            this.lblSeguradoras.Text = "Seguradora";
            // 
            // lblTSB
            // 
            this.lblTSB.AutoSize = true;
            this.lblTSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTSB.Location = new System.Drawing.Point(17, 22);
            this.lblTSB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTSB.Name = "lblTSB";
            this.lblTSB.Size = new System.Drawing.Size(293, 135);
            this.lblTSB.TabIndex = 1;
            this.lblTSB.Text = "TSB";
            // 
            // btnBuscarSeguradora
            // 
            this.btnBuscarSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarSeguradora.Location = new System.Drawing.Point(-1, 169);
            this.btnBuscarSeguradora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarSeguradora.Name = "btnBuscarSeguradora";
            this.btnBuscarSeguradora.Size = new System.Drawing.Size(296, 75);
            this.btnBuscarSeguradora.TabIndex = 4;
            this.btnBuscarSeguradora.Text = "Buscar Seguradora";
            this.btnBuscarSeguradora.UseVisualStyleBackColor = true;
            this.btnBuscarSeguradora.Click += new System.EventHandler(this.btnBuscarSeguradora_Click);
            // 
            // btnCadSeguradora
            // 
            this.btnCadSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadSeguradora.Location = new System.Drawing.Point(-1, 84);
            this.btnCadSeguradora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadSeguradora.Name = "btnCadSeguradora";
            this.btnCadSeguradora.Size = new System.Drawing.Size(296, 75);
            this.btnCadSeguradora.TabIndex = 5;
            this.btnCadSeguradora.Text = "Cadastrar Seguradora";
            this.btnCadSeguradora.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnVoltarMenu);
            this.panel1.Controls.Add(this.btnCadSeguradora);
            this.panel1.Controls.Add(this.btnBuscarSeguradora);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-1, 174);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 747);
            this.panel1.TabIndex = 32;
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
            // Assistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFuncionario);
            this.Controls.Add(this.panelLogo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Assistencia";
            this.Text = "Assistencia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Assistencia_Load);
            this.panelFuncionario.ResumeLayout(false);
            this.panelFuncionario.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeguradoraEmail;
        private System.Windows.Forms.TextBox txtIdSeguradora;
        private System.Windows.Forms.TextBox txtSeguradoraNome;
        private System.Windows.Forms.MaskedTextBox mktClienteFone;
        private System.Windows.Forms.MaskedTextBox mktSeguradoraCnpj;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDadosFuncionario;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblSeguradoras;
        private System.Windows.Forms.Label lblTSB;
        private System.Windows.Forms.TextBox txtComplementoSeguradora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeroSeguradora;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtCidadeSeguradora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairroSeguradora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRuaSeguradora;
        private System.Windows.Forms.ComboBox cbUfSeguradora;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbTipoServico;
        private System.Windows.Forms.Label lblTipoServico;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button btnCadastrarSeguradora;
        private System.Windows.Forms.Button btnBuscarSeguradora;
        private System.Windows.Forms.Button btnCadSeguradora;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}