namespace tsbPIM.Apresentação
{
    partial class TelaBuscaFunc
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
            this.components = new System.ComponentModel.Container();
            this.lblSexo = new System.Windows.Forms.Label();
            this.mktBuscaFuncRg = new System.Windows.Forms.MaskedTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.mktBuscaFuncDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.mktBuscaFuncCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtBuscaFuncId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBuscaFuncEstCiv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaFuncCargo = new System.Windows.Forms.TextBox();
            this.txtBuscaFuncFone = new System.Windows.Forms.TextBox();
            this.txtBuscaFuncEmail = new System.Windows.Forms.TextBox();
            this.txtBuscaFuncNome = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditarFuncionario = new System.Windows.Forms.Button();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblTSB = new System.Windows.Forms.Label();
            this.mktBuscaFuncCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.pIM4DataSet2 = new tsbPIM.PIM4DataSet2();
            this.cadFuncBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadFuncTableAdapter = new tsbPIM.PIM4DataSet2TableAdapters.CadFuncTableAdapter();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.funcIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcFoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcEstCivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcDataNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcCpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcSexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcRgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcCepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadFuncBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pIM4DataSet3 = new tsbPIM.PIM4DataSet3();
            this.cadFuncTableAdapter1 = new tsbPIM.PIM4DataSet3TableAdapters.CadFuncTableAdapter();
            this.cbBuscaFuncSexo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pIM4DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadFuncBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadFuncBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIM4DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(751, 226);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(45, 20);
            this.lblSexo.TabIndex = 126;
            this.lblSexo.Text = "Sexo";
            this.lblSexo.Click += new System.EventHandler(this.lblSexo_Click);
            // 
            // mktBuscaFuncRg
            // 
            this.mktBuscaFuncRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktBuscaFuncRg.Location = new System.Drawing.Point(752, 312);
            this.mktBuscaFuncRg.Mask = "00000000-0";
            this.mktBuscaFuncRg.Name = "mktBuscaFuncRg";
            this.mktBuscaFuncRg.ReadOnly = true;
            this.mktBuscaFuncRg.Size = new System.Drawing.Size(122, 31);
            this.mktBuscaFuncRg.TabIndex = 119;
            this.mktBuscaFuncRg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mktBuscaFuncRg_MaskInputRejected);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(753, 293);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(34, 20);
            this.lblRg.TabIndex = 118;
            this.lblRg.Text = "RG";
            this.lblRg.Click += new System.EventHandler(this.lblRg_Click);
            // 
            // mktBuscaFuncDataNasc
            // 
            this.mktBuscaFuncDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktBuscaFuncDataNasc.Location = new System.Drawing.Point(579, 312);
            this.mktBuscaFuncDataNasc.Mask = "00/00/0000";
            this.mktBuscaFuncDataNasc.Name = "mktBuscaFuncDataNasc";
            this.mktBuscaFuncDataNasc.ReadOnly = true;
            this.mktBuscaFuncDataNasc.Size = new System.Drawing.Size(122, 31);
            this.mktBuscaFuncDataNasc.TabIndex = 117;
            this.mktBuscaFuncDataNasc.ValidatingType = typeof(System.DateTime);
            this.mktBuscaFuncDataNasc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mktBuscaFuncDataNasc_MaskInputRejected);
            // 
            // mktBuscaFuncCpf
            // 
            this.mktBuscaFuncCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktBuscaFuncCpf.Location = new System.Drawing.Point(659, 388);
            this.mktBuscaFuncCpf.Mask = "000000000-00";
            this.mktBuscaFuncCpf.Name = "mktBuscaFuncCpf";
            this.mktBuscaFuncCpf.ReadOnly = true;
            this.mktBuscaFuncCpf.Size = new System.Drawing.Size(147, 31);
            this.mktBuscaFuncCpf.TabIndex = 115;
            this.mktBuscaFuncCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mktBuscaFuncCpf_MaskInputRejected);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(577, 289);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(88, 20);
            this.lblData.TabIndex = 116;
            this.lblData.Text = "Data Nasc.";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(655, 365);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 20);
            this.lblCpf.TabIndex = 114;
            this.lblCpf.Text = "CPF ";
            this.lblCpf.Click += new System.EventHandler(this.lblCpf_Click);
            // 
            // txtBuscaFuncId
            // 
            this.txtBuscaFuncId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaFuncId.Location = new System.Drawing.Point(342, 188);
            this.txtBuscaFuncId.Name = "txtBuscaFuncId";
            this.txtBuscaFuncId.ReadOnly = true;
            this.txtBuscaFuncId.Size = new System.Drawing.Size(65, 31);
            this.txtBuscaFuncId.TabIndex = 109;
            this.txtBuscaFuncId.TextChanged += new System.EventHandler(this.txtBuscaFuncId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 169);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 110;
            this.label5.Text = "Id";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(578, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 107;
            this.label10.Text = "Cargo";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 363);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 97;
            this.label4.Text = "Est. Civil";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbBuscaFuncEstCiv
            // 
            this.cbBuscaFuncEstCiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscaFuncEstCiv.FormattingEnabled = true;
            this.cbBuscaFuncEstCiv.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Viuvo(a)",
            "Divorciado(a)"});
            this.cbBuscaFuncEstCiv.Location = new System.Drawing.Point(495, 386);
            this.cbBuscaFuncEstCiv.Name = "cbBuscaFuncEstCiv";
            this.cbBuscaFuncEstCiv.Size = new System.Drawing.Size(135, 33);
            this.cbBuscaFuncEstCiv.TabIndex = 96;
            this.cbBuscaFuncEstCiv.SelectedIndexChanged += new System.EventHandler(this.cbBuscaFuncEstCiv_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "Telefone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 94;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 222);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBuscaFuncCargo
            // 
            this.txtBuscaFuncCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaFuncCargo.Location = new System.Drawing.Point(578, 246);
            this.txtBuscaFuncCargo.Name = "txtBuscaFuncCargo";
            this.txtBuscaFuncCargo.Size = new System.Drawing.Size(123, 31);
            this.txtBuscaFuncCargo.TabIndex = 92;
            this.txtBuscaFuncCargo.TextChanged += new System.EventHandler(this.txtBuscaFuncCargo_TextChanged);
            // 
            // txtBuscaFuncFone
            // 
            this.txtBuscaFuncFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaFuncFone.Location = new System.Drawing.Point(342, 386);
            this.txtBuscaFuncFone.Name = "txtBuscaFuncFone";
            this.txtBuscaFuncFone.Size = new System.Drawing.Size(125, 31);
            this.txtBuscaFuncFone.TabIndex = 90;
            this.txtBuscaFuncFone.TextChanged += new System.EventHandler(this.txtBuscaFuncFone_TextChanged);
            // 
            // txtBuscaFuncEmail
            // 
            this.txtBuscaFuncEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaFuncEmail.Location = new System.Drawing.Point(342, 312);
            this.txtBuscaFuncEmail.Name = "txtBuscaFuncEmail";
            this.txtBuscaFuncEmail.Size = new System.Drawing.Size(208, 31);
            this.txtBuscaFuncEmail.TabIndex = 89;
            this.txtBuscaFuncEmail.TextChanged += new System.EventHandler(this.txtBuscaFuncEmail_TextChanged);
            // 
            // txtBuscaFuncNome
            // 
            this.txtBuscaFuncNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaFuncNome.Location = new System.Drawing.Point(342, 245);
            this.txtBuscaFuncNome.Name = "txtBuscaFuncNome";
            this.txtBuscaFuncNome.Size = new System.Drawing.Size(208, 31);
            this.txtBuscaFuncNome.TabIndex = 88;
            this.txtBuscaFuncNome.TextChanged += new System.EventHandler(this.txtBuscaFuncNome_TextChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(1214, 166);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(144, 50);
            this.btnExcluir.TabIndex = 87;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1047, 166);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(144, 50);
            this.btnEditar.TabIndex = 86;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnEditarFuncionario);
            this.panel1.Controls.Add(this.btnVoltarMenu);
            this.panel1.Controls.Add(this.btnBuscarCliente);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 611);
            this.panel1.TabIndex = 85;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "Opções";
            // 
            // btnEditarFuncionario
            // 
            this.btnEditarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFuncionario.Location = new System.Drawing.Point(-1, 68);
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Size = new System.Drawing.Size(222, 61);
            this.btnEditarFuncionario.TabIndex = 8;
            this.btnEditarFuncionario.Text = "Cadastrar Funcionário";
            this.btnEditarFuncionario.UseVisualStyleBackColor = true;
            this.btnEditarFuncionario.Click += new System.EventHandler(this.btnEditarFuncionario_Click);
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarMenu.Location = new System.Drawing.Point(-1, 338);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(222, 61);
            this.btnVoltarMenu.TabIndex = 7;
            this.btnVoltarMenu.Text = "Voltar ao Menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(-1, 131);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(222, 61);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelLogo.Controls.Add(this.btnSair);
            this.panelLogo.Controls.Add(this.lblMenu);
            this.panelLogo.Controls.Add(this.lblTSB);
            this.panelLogo.Location = new System.Drawing.Point(0, -1);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1370, 139);
            this.panelLogo.TabIndex = 84;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(1249, 36);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 38);
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
            this.lblMenu.Location = new System.Drawing.Point(275, 18);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(859, 108);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = " Buscar Funcinário";
            // 
            // lblTSB
            // 
            this.lblTSB.AutoSize = true;
            this.lblTSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTSB.Location = new System.Drawing.Point(3, 18);
            this.lblTSB.Name = "lblTSB";
            this.lblTSB.Size = new System.Drawing.Size(235, 108);
            this.lblTSB.TabIndex = 1;
            this.lblTSB.Text = "TSB";
            // 
            // mktBuscaFuncCep
            // 
            this.mktBuscaFuncCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktBuscaFuncCep.Location = new System.Drawing.Point(838, 388);
            this.mktBuscaFuncCep.Mask = "00000-000";
            this.mktBuscaFuncCep.Name = "mktBuscaFuncCep";
            this.mktBuscaFuncCep.Size = new System.Drawing.Size(96, 31);
            this.mktBuscaFuncCep.TabIndex = 128;
            this.mktBuscaFuncCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mktBuscaFuncCep_MaskInputRejected);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(844, 365);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(41, 20);
            this.lblCep.TabIndex = 127;
            this.lblCep.Text = "CEP";
            this.lblCep.Click += new System.EventHandler(this.lblCep_Click);
            // 
            // pIM4DataSet2
            // 
            this.pIM4DataSet2.DataSetName = "PIM4DataSet2";
            this.pIM4DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadFuncBindingSource
            // 
            this.cadFuncBindingSource.DataMember = "CadFunc";
            this.cadFuncBindingSource.DataSource = this.pIM4DataSet2;
            // 
            // cadFuncTableAdapter
            // 
            this.cadFuncTableAdapter.ClearBeforeFill = true;
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AutoGenerateColumns = false;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.funcIdDataGridViewTextBoxColumn,
            this.funcNomeDataGridViewTextBoxColumn,
            this.funcEmailDataGridViewTextBoxColumn,
            this.funcFoneDataGridViewTextBoxColumn,
            this.funcEstCivDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.funcDataNascDataGridViewTextBoxColumn,
            this.funcCpfDataGridViewTextBoxColumn,
            this.funcSexoDataGridViewTextBoxColumn,
            this.funcRgDataGridViewTextBoxColumn,
            this.funcCepDataGridViewTextBoxColumn});
            this.dgvFuncionario.DataSource = this.cadFuncBindingSource1;
            this.dgvFuncionario.Location = new System.Drawing.Point(342, 451);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.Size = new System.Drawing.Size(998, 286);
            this.dgvFuncionario.TabIndex = 129;
            this.dgvFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellContentClick);
            this.dgvFuncionario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellDoubleClick);
            // 
            // funcIdDataGridViewTextBoxColumn
            // 
            this.funcIdDataGridViewTextBoxColumn.DataPropertyName = "funcId";
            this.funcIdDataGridViewTextBoxColumn.HeaderText = "funcId";
            this.funcIdDataGridViewTextBoxColumn.Name = "funcIdDataGridViewTextBoxColumn";
            // 
            // funcNomeDataGridViewTextBoxColumn
            // 
            this.funcNomeDataGridViewTextBoxColumn.DataPropertyName = "funcNome";
            this.funcNomeDataGridViewTextBoxColumn.HeaderText = "funcNome";
            this.funcNomeDataGridViewTextBoxColumn.Name = "funcNomeDataGridViewTextBoxColumn";
            // 
            // funcEmailDataGridViewTextBoxColumn
            // 
            this.funcEmailDataGridViewTextBoxColumn.DataPropertyName = "funcEmail";
            this.funcEmailDataGridViewTextBoxColumn.HeaderText = "funcEmail";
            this.funcEmailDataGridViewTextBoxColumn.Name = "funcEmailDataGridViewTextBoxColumn";
            // 
            // funcFoneDataGridViewTextBoxColumn
            // 
            this.funcFoneDataGridViewTextBoxColumn.DataPropertyName = "funcFone";
            this.funcFoneDataGridViewTextBoxColumn.HeaderText = "funcFone";
            this.funcFoneDataGridViewTextBoxColumn.Name = "funcFoneDataGridViewTextBoxColumn";
            // 
            // funcEstCivDataGridViewTextBoxColumn
            // 
            this.funcEstCivDataGridViewTextBoxColumn.DataPropertyName = "funcEstCiv";
            this.funcEstCivDataGridViewTextBoxColumn.HeaderText = "funcEstCiv";
            this.funcEstCivDataGridViewTextBoxColumn.Name = "funcEstCivDataGridViewTextBoxColumn";
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            // 
            // funcDataNascDataGridViewTextBoxColumn
            // 
            this.funcDataNascDataGridViewTextBoxColumn.DataPropertyName = "funcDataNasc";
            this.funcDataNascDataGridViewTextBoxColumn.HeaderText = "funcDataNasc";
            this.funcDataNascDataGridViewTextBoxColumn.Name = "funcDataNascDataGridViewTextBoxColumn";
            // 
            // funcCpfDataGridViewTextBoxColumn
            // 
            this.funcCpfDataGridViewTextBoxColumn.DataPropertyName = "funcCpf";
            this.funcCpfDataGridViewTextBoxColumn.HeaderText = "funcCpf";
            this.funcCpfDataGridViewTextBoxColumn.Name = "funcCpfDataGridViewTextBoxColumn";
            // 
            // funcSexoDataGridViewTextBoxColumn
            // 
            this.funcSexoDataGridViewTextBoxColumn.DataPropertyName = "funcSexo";
            this.funcSexoDataGridViewTextBoxColumn.HeaderText = "funcSexo";
            this.funcSexoDataGridViewTextBoxColumn.Name = "funcSexoDataGridViewTextBoxColumn";
            // 
            // funcRgDataGridViewTextBoxColumn
            // 
            this.funcRgDataGridViewTextBoxColumn.DataPropertyName = "funcRg";
            this.funcRgDataGridViewTextBoxColumn.HeaderText = "funcRg";
            this.funcRgDataGridViewTextBoxColumn.Name = "funcRgDataGridViewTextBoxColumn";
            // 
            // funcCepDataGridViewTextBoxColumn
            // 
            this.funcCepDataGridViewTextBoxColumn.DataPropertyName = "funcCep";
            this.funcCepDataGridViewTextBoxColumn.HeaderText = "funcCep";
            this.funcCepDataGridViewTextBoxColumn.Name = "funcCepDataGridViewTextBoxColumn";
            // 
            // cadFuncBindingSource1
            // 
            this.cadFuncBindingSource1.DataMember = "CadFunc";
            this.cadFuncBindingSource1.DataSource = this.pIM4DataSet3;
            // 
            // pIM4DataSet3
            // 
            this.pIM4DataSet3.DataSetName = "PIM4DataSet3";
            this.pIM4DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadFuncTableAdapter1
            // 
            this.cadFuncTableAdapter1.ClearBeforeFill = true;
            // 
            // cbBuscaFuncSexo
            // 
            this.cbBuscaFuncSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscaFuncSexo.Location = new System.Drawing.Point(752, 249);
            this.cbBuscaFuncSexo.Name = "cbBuscaFuncSexo";
            this.cbBuscaFuncSexo.ReadOnly = true;
            this.cbBuscaFuncSexo.Size = new System.Drawing.Size(125, 31);
            this.cbBuscaFuncSexo.TabIndex = 130;
            // 
            // TelaBuscaFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.cbBuscaFuncSexo);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.mktBuscaFuncCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.mktBuscaFuncRg);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.mktBuscaFuncDataNasc);
            this.Controls.Add(this.mktBuscaFuncCpf);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtBuscaFuncId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBuscaFuncEstCiv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscaFuncCargo);
            this.Controls.Add(this.txtBuscaFuncFone);
            this.Controls.Add(this.txtBuscaFuncEmail);
            this.Controls.Add(this.txtBuscaFuncNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLogo);
            this.Name = "TelaBuscaFunc";
            this.Text = "TelaBuscaFunc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaBuscaFunc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pIM4DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadFuncBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadFuncBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIM4DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.MaskedTextBox mktBuscaFuncRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.MaskedTextBox mktBuscaFuncDataNasc;
        private System.Windows.Forms.MaskedTextBox mktBuscaFuncCpf;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtBuscaFuncId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBuscaFuncEstCiv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaFuncCargo;
        private System.Windows.Forms.TextBox txtBuscaFuncFone;
        private System.Windows.Forms.TextBox txtBuscaFuncEmail;
        private System.Windows.Forms.TextBox txtBuscaFuncNome;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditarFuncionario;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblTSB;
        private System.Windows.Forms.MaskedTextBox mktBuscaFuncCep;
        private System.Windows.Forms.Label lblCep;
        private PIM4DataSet2 pIM4DataSet2;
        private System.Windows.Forms.BindingSource cadFuncBindingSource;
        private PIM4DataSet2TableAdapters.CadFuncTableAdapter cadFuncTableAdapter;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private PIM4DataSet3 pIM4DataSet3;
        private System.Windows.Forms.BindingSource cadFuncBindingSource1;
        private PIM4DataSet3TableAdapters.CadFuncTableAdapter cadFuncTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcFoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcEstCivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcDataNascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcCpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcSexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcRgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcCepDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox cbBuscaFuncSexo;
    }
}