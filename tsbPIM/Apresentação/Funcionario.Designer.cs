namespace tsbPIM.Apresentação
{
    partial class Funcionario
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
            this.lblEstCivil = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDadosFuncionario = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mktFuncCpf = new System.Windows.Forms.MaskedTextBox();
            this.mktFuncRg = new System.Windows.Forms.MaskedTextBox();
            this.mktFuncDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.mktFuncCep = new System.Windows.Forms.MaskedTextBox();
            this.mktFuncFone = new System.Windows.Forms.MaskedTextBox();
            this.cbFuncSexo = new System.Windows.Forms.ComboBox();
            this.cbFuncEstCiv = new System.Windows.Forms.ComboBox();
            this.txtFuncNome = new System.Windows.Forms.TextBox();
            this.panelFuncionario = new System.Windows.Forms.Panel();
            this.txtFuncEmail = new System.Windows.Forms.TextBox();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtFuncId = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.btnEditarFuncionario = new System.Windows.Forms.Button();
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            this.panelFuncionario.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panelLogo.TabIndex = 23;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(1683, 37);
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
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenu.Location = new System.Drawing.Point(532, 22);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(697, 135);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Funcionário";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
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
            // lblEstCivil
            // 
            this.lblEstCivil.AutoSize = true;
            this.lblEstCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstCivil.Location = new System.Drawing.Point(51, 406);
            this.lblEstCivil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstCivil.Name = "lblEstCivil";
            this.lblEstCivil.Size = new System.Drawing.Size(115, 25);
            this.lblEstCivil.TabIndex = 31;
            this.lblEstCivil.Text = "Estado Civil";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(49, 338);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(52, 25);
            this.lblCpf.TabIndex = 30;
            this.lblCpf.Text = "CPF";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(412, 262);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(58, 25);
            this.lblSexo.TabIndex = 29;
            this.lblSexo.Text = "Sexo";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(412, 194);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(66, 25);
            this.lblCargo.TabIndex = 28;
            this.lblCargo.Text = "Cargo";
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFunc.Location = new System.Drawing.Point(49, 194);
            this.lblNomeFunc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(64, 25);
            this.lblNomeFunc.TabIndex = 27;
            this.lblNomeFunc.Text = "Nome";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(52, 485);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(108, 25);
            this.lblData.TabIndex = 32;
            this.lblData.Text = "Data Nasc.";
            // 
            // lblDadosFuncionario
            // 
            this.lblDadosFuncionario.AutoSize = true;
            this.lblDadosFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosFuncionario.Location = new System.Drawing.Point(113, 20);
            this.lblDadosFuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDadosFuncionario.Name = "lblDadosFuncionario";
            this.lblDadosFuncionario.Size = new System.Drawing.Size(405, 31);
            this.lblDadosFuncionario.TabIndex = 1;
            this.lblDadosFuncionario.Text = "Insira os dados do funcionário";
            this.lblDadosFuncionario.Click += new System.EventHandler(this.lblDadosFuncionario_Click);
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
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(413, 338);
            this.lblRg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(40, 25);
            this.lblRg.TabIndex = 36;
            this.lblRg.Text = "RG";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(413, 412);
            this.lblCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(53, 25);
            this.lblCep.TabIndex = 35;
            this.lblCep.Text = "CEP";
            this.lblCep.Click += new System.EventHandler(this.lblCep_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(49, 266);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 25);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "E-mail";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(415, 485);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(89, 25);
            this.lblTelefone.TabIndex = 34;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Click += new System.EventHandler(this.lblTelefone_Click);
            // 
            // mktFuncCpf
            // 
            this.mktFuncCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktFuncCpf.Location = new System.Drawing.Point(52, 362);
            this.mktFuncCpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mktFuncCpf.Mask = "000000000-00";
            this.mktFuncCpf.Name = "mktFuncCpf";
            this.mktFuncCpf.Size = new System.Drawing.Size(199, 37);
            this.mktFuncCpf.TabIndex = 32;
            // 
            // mktFuncRg
            // 
            this.mktFuncRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktFuncRg.Location = new System.Drawing.Point(417, 362);
            this.mktFuncRg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mktFuncRg.Mask = "00000000-0";
            this.mktFuncRg.Name = "mktFuncRg";
            this.mktFuncRg.Size = new System.Drawing.Size(167, 37);
            this.mktFuncRg.TabIndex = 37;
            // 
            // mktFuncDataNasc
            // 
            this.mktFuncDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktFuncDataNasc.Location = new System.Drawing.Point(55, 508);
            this.mktFuncDataNasc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mktFuncDataNasc.Mask = "00/00/0000";
            this.mktFuncDataNasc.Name = "mktFuncDataNasc";
            this.mktFuncDataNasc.Size = new System.Drawing.Size(156, 37);
            this.mktFuncDataNasc.TabIndex = 38;
            this.mktFuncDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // mktFuncCep
            // 
            this.mktFuncCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktFuncCep.Location = new System.Drawing.Point(417, 436);
            this.mktFuncCep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mktFuncCep.Mask = "00000-000";
            this.mktFuncCep.Name = "mktFuncCep";
            this.mktFuncCep.Size = new System.Drawing.Size(148, 37);
            this.mktFuncCep.TabIndex = 39;
            // 
            // mktFuncFone
            // 
            this.mktFuncFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktFuncFone.Location = new System.Drawing.Point(419, 508);
            this.mktFuncFone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mktFuncFone.Mask = "(00)90000-0000";
            this.mktFuncFone.Name = "mktFuncFone";
            this.mktFuncFone.Size = new System.Drawing.Size(217, 37);
            this.mktFuncFone.TabIndex = 41;
            // 
            // cbFuncSexo
            // 
            this.cbFuncSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncSexo.FormattingEnabled = true;
            this.cbFuncSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cbFuncSexo.Location = new System.Drawing.Point(416, 289);
            this.cbFuncSexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFuncSexo.Name = "cbFuncSexo";
            this.cbFuncSexo.Size = new System.Drawing.Size(197, 38);
            this.cbFuncSexo.TabIndex = 27;
            // 
            // cbFuncEstCiv
            // 
            this.cbFuncEstCiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncEstCiv.FormattingEnabled = true;
            this.cbFuncEstCiv.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Viuvo(a)",
            "Divorciado(a)"});
            this.cbFuncEstCiv.Location = new System.Drawing.Point(55, 433);
            this.cbFuncEstCiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFuncEstCiv.Name = "cbFuncEstCiv";
            this.cbFuncEstCiv.Size = new System.Drawing.Size(196, 38);
            this.cbFuncEstCiv.TabIndex = 42;
            // 
            // txtFuncNome
            // 
            this.txtFuncNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncNome.Location = new System.Drawing.Point(51, 218);
            this.txtFuncNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFuncNome.Name = "txtFuncNome";
            this.txtFuncNome.Size = new System.Drawing.Size(304, 37);
            this.txtFuncNome.TabIndex = 43;
            this.txtFuncNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelFuncionario
            // 
            this.panelFuncionario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelFuncionario.Controls.Add(this.txtFuncEmail);
            this.panelFuncionario.Controls.Add(this.bntCancelar);
            this.panelFuncionario.Controls.Add(this.btnCadastrar);
            this.panelFuncionario.Controls.Add(this.txtFuncId);
            this.panelFuncionario.Controls.Add(this.txtCargo);
            this.panelFuncionario.Controls.Add(this.txtFuncNome);
            this.panelFuncionario.Controls.Add(this.cbFuncEstCiv);
            this.panelFuncionario.Controls.Add(this.cbFuncSexo);
            this.panelFuncionario.Controls.Add(this.mktFuncFone);
            this.panelFuncionario.Controls.Add(this.mktFuncCep);
            this.panelFuncionario.Controls.Add(this.mktFuncDataNasc);
            this.panelFuncionario.Controls.Add(this.mktFuncRg);
            this.panelFuncionario.Controls.Add(this.mktFuncCpf);
            this.panelFuncionario.Controls.Add(this.lblTelefone);
            this.panelFuncionario.Controls.Add(this.lblEmail);
            this.panelFuncionario.Controls.Add(this.lblCep);
            this.panelFuncionario.Controls.Add(this.lblRg);
            this.panelFuncionario.Controls.Add(this.lblId);
            this.panelFuncionario.Controls.Add(this.lblDadosFuncionario);
            this.panelFuncionario.Controls.Add(this.lblData);
            this.panelFuncionario.Controls.Add(this.lblNomeFunc);
            this.panelFuncionario.Controls.Add(this.lblCargo);
            this.panelFuncionario.Controls.Add(this.lblSexo);
            this.panelFuncionario.Controls.Add(this.lblCpf);
            this.panelFuncionario.Controls.Add(this.lblEstCivil);
            this.panelFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFuncionario.Location = new System.Drawing.Point(569, 172);
            this.panelFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFuncionario.Name = "panelFuncionario";
            this.panelFuncionario.Size = new System.Drawing.Size(673, 747);
            this.panelFuncionario.TabIndex = 25;
            // 
            // txtFuncEmail
            // 
            this.txtFuncEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncEmail.Location = new System.Drawing.Point(51, 289);
            this.txtFuncEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFuncEmail.Name = "txtFuncEmail";
            this.txtFuncEmail.Size = new System.Drawing.Size(304, 37);
            this.txtFuncEmail.TabIndex = 48;
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
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtFuncId
            // 
            this.txtFuncId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncId.Location = new System.Drawing.Point(53, 130);
            this.txtFuncId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFuncId.Name = "txtFuncId";
            this.txtFuncId.Size = new System.Drawing.Size(80, 37);
            this.txtFuncId.TabIndex = 45;
            this.txtFuncId.TextChanged += new System.EventHandler(this.txtIdFunc_TextChanged);
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(416, 218);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(197, 37);
            this.txtCargo.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnVoltarMenu);
            this.panel2.Controls.Add(this.btnEditarFuncionario);
            this.panel2.Controls.Add(this.btnBuscarFuncionario);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 172);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 752);
            this.panel2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Opções";
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarMenu.Location = new System.Drawing.Point(-1, 417);
            this.btnVoltarMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(296, 75);
            this.btnVoltarMenu.TabIndex = 7;
            this.btnVoltarMenu.Text = "Voltar ao Menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // btnEditarFuncionario
            // 
            this.btnEditarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFuncionario.Location = new System.Drawing.Point(-1, 101);
            this.btnEditarFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Size = new System.Drawing.Size(296, 75);
            this.btnEditarFuncionario.TabIndex = 5;
            this.btnEditarFuncionario.Text = "Cadastrar Funcionário";
            this.btnEditarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(-1, 185);
            this.btnBuscarFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(296, 75);
            this.btnBuscarFuncionario.TabIndex = 4;
            this.btnBuscarFuncionario.Text = "Buscar Funcionário";
            this.btnBuscarFuncionario.UseVisualStyleBackColor = true;
            this.btnBuscarFuncionario.Click += new System.EventHandler(this.btnBuscarFuncionario_Click);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelFuncionario);
            this.Controls.Add(this.panelLogo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Funcionario";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Funcionario_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelFuncionario.ResumeLayout(false);
            this.panelFuncionario.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblTSB;
        private System.Windows.Forms.Label lblEstCivil;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDadosFuncionario;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mktFuncCpf;
        private System.Windows.Forms.MaskedTextBox mktFuncRg;
        private System.Windows.Forms.MaskedTextBox mktFuncDataNasc;
        private System.Windows.Forms.MaskedTextBox mktFuncCep;
        private System.Windows.Forms.MaskedTextBox mktFuncFone;
        private System.Windows.Forms.ComboBox cbFuncSexo;
        private System.Windows.Forms.ComboBox cbFuncEstCiv;
        private System.Windows.Forms.TextBox txtFuncNome;
        private System.Windows.Forms.Panel panelFuncionario;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtFuncId;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtFuncEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Button btnBuscarFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditarFuncionario;
    }
}