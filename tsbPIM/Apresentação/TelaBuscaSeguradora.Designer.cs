namespace tsbPIM.Apresentação
{
    partial class TelaBuscaSeguradora
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
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.idSeguradoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeSeguradoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjSeguradoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneSeguradoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailSeguradoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaSeguradoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numSeguradoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroSeguradoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeSeguradoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufSeguradoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoSeguradoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguradoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pIM4DataSet4 = new tsbPIM.PIM4DataSet4();
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
            this.txtBuscaSegEmail = new System.Windows.Forms.TextBox();
            this.txtBuscaSegFone = new System.Windows.Forms.TextBox();
            this.txtBuscaSegRua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscaSegId = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtBuscaSegNome = new System.Windows.Forms.TextBox();
            this.cbBuscaUfSeguradora = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbBuscaTipoServico = new System.Windows.Forms.ComboBox();
            this.lblTipoServico = new System.Windows.Forms.Label();
            this.txtBuscaSegBairro = new System.Windows.Forms.TextBox();
            this.txtBuscaSegCidade = new System.Windows.Forms.TextBox();
            this.txtBuscaSegNum = new System.Windows.Forms.TextBox();
            this.txtBuscaSegComp = new System.Windows.Forms.TextBox();
            this.mktBuscaSegCnpj = new System.Windows.Forms.TextBox();
            this.seguradoraTableAdapter = new tsbPIM.PIM4DataSet4TableAdapters.seguradoraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIM4DataSet4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AutoGenerateColumns = false;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSeguradoraDataGridViewTextBoxColumn,
            this.nomeSeguradoraDataGridViewTextBoxColumn,
            this.cnpjSeguradoraDataGridViewTextBoxColumn,
            this.foneSeguradoraDataGridViewTextBoxColumn,
            this.emailSeguradoraDataGridViewTextBoxColumn,
            this.tipoServicoDataGridViewTextBoxColumn,
            this.ruaSeguradoraDataGridViewTextBoxColumn,
            this.numSeguradoraDataGridViewTextBoxColumn,
            this.bairroSeguradoraDataGridViewTextBoxColumn,
            this.cidadeSeguradoraDataGridViewTextBoxColumn,
            this.ufSeguradoraDataGridViewTextBoxColumn,
            this.complementoSeguradoraDataGridViewTextBoxColumn});
            this.dgvFuncionario.DataSource = this.seguradoraBindingSource;
            this.dgvFuncionario.Location = new System.Drawing.Point(342, 451);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.Size = new System.Drawing.Size(998, 286);
            this.dgvFuncionario.TabIndex = 156;
            this.dgvFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellContentClick);
            this.dgvFuncionario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellContentDoubleClick);
            // 
            // idSeguradoraDataGridViewTextBoxColumn
            // 
            this.idSeguradoraDataGridViewTextBoxColumn.DataPropertyName = "idSeguradora";
            this.idSeguradoraDataGridViewTextBoxColumn.HeaderText = "idSeguradora";
            this.idSeguradoraDataGridViewTextBoxColumn.Name = "idSeguradoraDataGridViewTextBoxColumn";
            // 
            // nomeSeguradoraDataGridViewTextBoxColumn
            // 
            this.nomeSeguradoraDataGridViewTextBoxColumn.DataPropertyName = "nomeSeguradora";
            this.nomeSeguradoraDataGridViewTextBoxColumn.HeaderText = "nomeSeguradora";
            this.nomeSeguradoraDataGridViewTextBoxColumn.Name = "nomeSeguradoraDataGridViewTextBoxColumn";
            // 
            // cnpjSeguradoraDataGridViewTextBoxColumn
            // 
            this.cnpjSeguradoraDataGridViewTextBoxColumn.DataPropertyName = "cnpjSeguradora";
            this.cnpjSeguradoraDataGridViewTextBoxColumn.HeaderText = "cnpjSeguradora";
            this.cnpjSeguradoraDataGridViewTextBoxColumn.Name = "cnpjSeguradoraDataGridViewTextBoxColumn";
            // 
            // foneSeguradoraDataGridViewTextBoxColumn
            // 
            this.foneSeguradoraDataGridViewTextBoxColumn.DataPropertyName = "foneSeguradora";
            this.foneSeguradoraDataGridViewTextBoxColumn.HeaderText = "foneSeguradora";
            this.foneSeguradoraDataGridViewTextBoxColumn.Name = "foneSeguradoraDataGridViewTextBoxColumn";
            // 
            // emailSeguradoraDataGridViewTextBoxColumn
            // 
            this.emailSeguradoraDataGridViewTextBoxColumn.DataPropertyName = "emailSeguradora";
            this.emailSeguradoraDataGridViewTextBoxColumn.HeaderText = "emailSeguradora";
            this.emailSeguradoraDataGridViewTextBoxColumn.Name = "emailSeguradoraDataGridViewTextBoxColumn";
            // 
            // tipoServicoDataGridViewTextBoxColumn
            // 
            this.tipoServicoDataGridViewTextBoxColumn.DataPropertyName = "tipoServico";
            this.tipoServicoDataGridViewTextBoxColumn.HeaderText = "tipoServico";
            this.tipoServicoDataGridViewTextBoxColumn.Name = "tipoServicoDataGridViewTextBoxColumn";
            // 
            // ruaSeguradoraDataGridViewTextBoxColumn
            // 
            this.ruaSeguradoraDataGridViewTextBoxColumn.DataPropertyName = "ruaSeguradora";
            this.ruaSeguradoraDataGridViewTextBoxColumn.HeaderText = "ruaSeguradora";
            this.ruaSeguradoraDataGridViewTextBoxColumn.Name = "ruaSeguradoraDataGridViewTextBoxColumn";
            // 
            // numSeguradoraDataGridViewTextBoxColumn
            // 
            this.numSeguradoraDataGridViewTextBoxColumn.DataPropertyName = "numSeguradora";
            this.numSeguradoraDataGridViewTextBoxColumn.HeaderText = "numSeguradora";
            this.numSeguradoraDataGridViewTextBoxColumn.Name = "numSeguradoraDataGridViewTextBoxColumn";
            // 
            // bairroSeguradoraDataGridViewTextBoxColumn
            // 
            this.bairroSeguradoraDataGridViewTextBoxColumn.DataPropertyName = "bairroSeguradora";
            this.bairroSeguradoraDataGridViewTextBoxColumn.HeaderText = "bairroSeguradora";
            this.bairroSeguradoraDataGridViewTextBoxColumn.Name = "bairroSeguradoraDataGridViewTextBoxColumn";
            // 
            // cidadeSeguradoraDataGridViewTextBoxColumn
            // 
            this.cidadeSeguradoraDataGridViewTextBoxColumn.DataPropertyName = "cidadeSeguradora";
            this.cidadeSeguradoraDataGridViewTextBoxColumn.HeaderText = "cidadeSeguradora";
            this.cidadeSeguradoraDataGridViewTextBoxColumn.Name = "cidadeSeguradoraDataGridViewTextBoxColumn";
            // 
            // ufSeguradoraDataGridViewTextBoxColumn
            // 
            this.ufSeguradoraDataGridViewTextBoxColumn.DataPropertyName = "ufSeguradora";
            this.ufSeguradoraDataGridViewTextBoxColumn.HeaderText = "ufSeguradora";
            this.ufSeguradoraDataGridViewTextBoxColumn.Name = "ufSeguradoraDataGridViewTextBoxColumn";
            // 
            // complementoSeguradoraDataGridViewTextBoxColumn
            // 
            this.complementoSeguradoraDataGridViewTextBoxColumn.DataPropertyName = "complementoSeguradora";
            this.complementoSeguradoraDataGridViewTextBoxColumn.HeaderText = "complementoSeguradora";
            this.complementoSeguradoraDataGridViewTextBoxColumn.Name = "complementoSeguradoraDataGridViewTextBoxColumn";
            // 
            // seguradoraBindingSource
            // 
            this.seguradoraBindingSource.DataMember = "seguradora";
            this.seguradoraBindingSource.DataSource = this.pIM4DataSet4;
            // 
            // pIM4DataSet4
            // 
            this.pIM4DataSet4.DataSetName = "PIM4DataSet4";
            this.pIM4DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(1214, 166);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(144, 50);
            this.btnExcluir.TabIndex = 133;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1063, 166);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(144, 50);
            this.btnEditar.TabIndex = 132;
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
            this.panel1.TabIndex = 131;
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
            this.btnEditarFuncionario.Text = "Cadastrar Seguradora";
            this.btnEditarFuncionario.UseVisualStyleBackColor = true;
            this.btnEditarFuncionario.Click += new System.EventHandler(this.btnEditarFuncionario_Click);
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarMenu.Location = new System.Drawing.Point(-1, 303);
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
            this.btnBuscarCliente.Location = new System.Drawing.Point(-1, 128);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(222, 61);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "Buscar Seguradora";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
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
            this.panelLogo.TabIndex = 130;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(1249, 28);
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
            this.lblMenu.Location = new System.Drawing.Point(263, 18);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(912, 108);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = " Buscar Seguradora";
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
            // txtBuscaSegEmail
            // 
            this.txtBuscaSegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaSegEmail.Location = new System.Drawing.Point(342, 315);
            this.txtBuscaSegEmail.Name = "txtBuscaSegEmail";
            this.txtBuscaSegEmail.Size = new System.Drawing.Size(182, 31);
            this.txtBuscaSegEmail.TabIndex = 135;
            // 
            // txtBuscaSegFone
            // 
            this.txtBuscaSegFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaSegFone.Location = new System.Drawing.Point(342, 383);
            this.txtBuscaSegFone.Name = "txtBuscaSegFone";
            this.txtBuscaSegFone.Size = new System.Drawing.Size(133, 31);
            this.txtBuscaSegFone.TabIndex = 136;
            // 
            // txtBuscaSegRua
            // 
            this.txtBuscaSegRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaSegRua.Location = new System.Drawing.Point(518, 383);
            this.txtBuscaSegRua.Name = "txtBuscaSegRua";
            this.txtBuscaSegRua.Size = new System.Drawing.Size(212, 31);
            this.txtBuscaSegRua.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 225);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 138;
            this.label1.Text = "Nome fantasia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 139;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 140;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(558, 225);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 142;
            this.label4.Text = "CNPJ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(515, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 143;
            this.label10.Text = "Rua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 162);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 145;
            this.label5.Text = "Id";
            // 
            // txtBuscaSegId
            // 
            this.txtBuscaSegId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaSegId.Location = new System.Drawing.Point(342, 185);
            this.txtBuscaSegId.Name = "txtBuscaSegId";
            this.txtBuscaSegId.ReadOnly = true;
            this.txtBuscaSegId.Size = new System.Drawing.Size(59, 31);
            this.txtBuscaSegId.TabIndex = 144;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(758, 294);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(56, 20);
            this.lblCpf.TabIndex = 146;
            this.lblCpf.Text = "cidade";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(758, 225);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(49, 20);
            this.lblData.TabIndex = 148;
            this.lblData.Text = "bairro";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(758, 365);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(26, 20);
            this.lblSexo.TabIndex = 153;
            this.lblSexo.Text = "Nº";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(879, 365);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(108, 20);
            this.lblCep.TabIndex = 154;
            this.lblCep.Text = "Complemento";
            // 
            // txtBuscaSegNome
            // 
            this.txtBuscaSegNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaSegNome.Location = new System.Drawing.Point(342, 248);
            this.txtBuscaSegNome.Name = "txtBuscaSegNome";
            this.txtBuscaSegNome.Size = new System.Drawing.Size(182, 31);
            this.txtBuscaSegNome.TabIndex = 134;
            // 
            // cbBuscaUfSeguradora
            // 
            this.cbBuscaUfSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscaUfSeguradora.FormattingEnabled = true;
            this.cbBuscaUfSeguradora.Items.AddRange(new object[] {
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
            this.cbBuscaUfSeguradora.Location = new System.Drawing.Point(963, 248);
            this.cbBuscaUfSeguradora.Name = "cbBuscaUfSeguradora";
            this.cbBuscaUfSeguradora.Size = new System.Drawing.Size(77, 33);
            this.cbBuscaUfSeguradora.TabIndex = 157;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(970, 225);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(26, 20);
            this.lblEstado.TabIndex = 158;
            this.lblEstado.Text = "Uf";
            // 
            // cbBuscaTipoServico
            // 
            this.cbBuscaTipoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscaTipoServico.FormattingEnabled = true;
            this.cbBuscaTipoServico.Items.AddRange(new object[] {
            "Assist. Funerária",
            "Seguro de vida",
            "Médico",
            "Financeiro"});
            this.cbBuscaTipoServico.Location = new System.Drawing.Point(565, 315);
            this.cbBuscaTipoServico.Name = "cbBuscaTipoServico";
            this.cbBuscaTipoServico.Size = new System.Drawing.Size(149, 33);
            this.cbBuscaTipoServico.TabIndex = 159;
            // 
            // lblTipoServico
            // 
            this.lblTipoServico.AutoSize = true;
            this.lblTipoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServico.Location = new System.Drawing.Point(561, 292);
            this.lblTipoServico.Name = "lblTipoServico";
            this.lblTipoServico.Size = new System.Drawing.Size(114, 20);
            this.lblTipoServico.TabIndex = 160;
            this.lblTipoServico.Text = "Tipo de serviço";
            // 
            // txtBuscaSegBairro
            // 
            this.txtBuscaSegBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaSegBairro.Location = new System.Drawing.Point(762, 248);
            this.txtBuscaSegBairro.Name = "txtBuscaSegBairro";
            this.txtBuscaSegBairro.Size = new System.Drawing.Size(146, 31);
            this.txtBuscaSegBairro.TabIndex = 161;
            // 
            // txtBuscaSegCidade
            // 
            this.txtBuscaSegCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaSegCidade.Location = new System.Drawing.Point(762, 317);
            this.txtBuscaSegCidade.Name = "txtBuscaSegCidade";
            this.txtBuscaSegCidade.Size = new System.Drawing.Size(143, 31);
            this.txtBuscaSegCidade.TabIndex = 162;
            // 
            // txtBuscaSegNum
            // 
            this.txtBuscaSegNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaSegNum.Location = new System.Drawing.Point(762, 383);
            this.txtBuscaSegNum.Name = "txtBuscaSegNum";
            this.txtBuscaSegNum.Size = new System.Drawing.Size(76, 31);
            this.txtBuscaSegNum.TabIndex = 163;
            // 
            // txtBuscaSegComp
            // 
            this.txtBuscaSegComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaSegComp.Location = new System.Drawing.Point(882, 383);
            this.txtBuscaSegComp.Name = "txtBuscaSegComp";
            this.txtBuscaSegComp.Size = new System.Drawing.Size(190, 31);
            this.txtBuscaSegComp.TabIndex = 164;
            // 
            // mktBuscaSegCnpj
            // 
            this.mktBuscaSegCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktBuscaSegCnpj.Location = new System.Drawing.Point(562, 248);
            this.mktBuscaSegCnpj.Name = "mktBuscaSegCnpj";
            this.mktBuscaSegCnpj.ReadOnly = true;
            this.mktBuscaSegCnpj.Size = new System.Drawing.Size(152, 31);
            this.mktBuscaSegCnpj.TabIndex = 165;
            // 
            // seguradoraTableAdapter
            // 
            this.seguradoraTableAdapter.ClearBeforeFill = true;
            // 
            // TelaBuscaSeguradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.mktBuscaSegCnpj);
            this.Controls.Add(this.txtBuscaSegComp);
            this.Controls.Add(this.txtBuscaSegNum);
            this.Controls.Add(this.txtBuscaSegCidade);
            this.Controls.Add(this.txtBuscaSegBairro);
            this.Controls.Add(this.cbBuscaTipoServico);
            this.Controls.Add(this.lblTipoServico);
            this.Controls.Add(this.cbBuscaUfSeguradora);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtBuscaSegId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscaSegRua);
            this.Controls.Add(this.txtBuscaSegFone);
            this.Controls.Add(this.txtBuscaSegEmail);
            this.Controls.Add(this.txtBuscaSegNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLogo);
            this.Name = "TelaBuscaSeguradora";
            this.Text = "TelaBuscaSeguradora";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaBuscaSeguradora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIM4DataSet4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionario;
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
        private System.Windows.Forms.TextBox txtBuscaSegEmail;
        private System.Windows.Forms.TextBox txtBuscaSegFone;
        private System.Windows.Forms.TextBox txtBuscaSegRua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscaSegId;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtBuscaSegNome;
        private System.Windows.Forms.ComboBox cbBuscaUfSeguradora;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbBuscaTipoServico;
        private System.Windows.Forms.Label lblTipoServico;
        private System.Windows.Forms.TextBox txtBuscaSegBairro;
        private System.Windows.Forms.TextBox txtBuscaSegCidade;
        private System.Windows.Forms.TextBox txtBuscaSegNum;
        private System.Windows.Forms.TextBox txtBuscaSegComp;
        private System.Windows.Forms.TextBox mktBuscaSegCnpj;
        private PIM4DataSet4 pIM4DataSet4;
        private System.Windows.Forms.BindingSource seguradoraBindingSource;
        private PIM4DataSet4TableAdapters.seguradoraTableAdapter seguradoraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSeguradoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeSeguradoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjSeguradoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneSeguradoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailSeguradoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaSeguradoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSeguradoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroSeguradoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeSeguradoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufSeguradoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoSeguradoraDataGridViewTextBoxColumn;
    }
}