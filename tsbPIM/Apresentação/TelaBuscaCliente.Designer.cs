namespace tsbPIM.Apresentação
{
    partial class TelaBuscaCliente
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblTSB = new System.Windows.Forms.Label();
            this.dadosClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pIM4DataSet = new tsbPIM.PIM4DataSet();
            this.dadosClienteTableAdapter = new tsbPIM.PIM4DataSetTableAdapters.dadosClienteTableAdapter();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.txtBuscaEmail = new System.Windows.Forms.TextBox();
            this.txtBuscaFone = new System.Windows.Forms.TextBox();
            this.txtBuscaComplemento = new System.Windows.Forms.TextBox();
            this.txtBuscaRua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBuscaEstCiv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBuscaComplemento = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscaCidade = new System.Windows.Forms.TextBox();
            this.txtBuscaBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuscaNumero = new System.Windows.Forms.TextBox();
            this.cbBuscaUf = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pesquisaClientes = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientePj = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estCivCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fumante = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cirurgias = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.doencas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pIM4DataSet1 = new tsbPIM.PIM4DataSet1();
            this.dadosClienteTableAdapter1 = new tsbPIM.PIM4DataSet1TableAdapters.dadosClienteTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.cbkBuscaDoenca = new System.Windows.Forms.CheckBox();
            this.cbkBuscaCirurgia = new System.Windows.Forms.CheckBox();
            this.cbkBuscaFumante = new System.Windows.Forms.CheckBox();
            this.mktBuscaClienteDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.mktBuscaClienteCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.mktBuscaClienteRg = new System.Windows.Forms.MaskedTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.ckbBuscaClientePj = new System.Windows.Forms.CheckBox();
            this.txtBuscaPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtBuscaAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditarFuncionario = new System.Windows.Forms.Button();
            this.cbBuscaClienteSexo = new System.Windows.Forms.TextBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIM4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIM4DataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelLogo.Controls.Add(this.btnSair);
            this.panelLogo.Controls.Add(this.lblMenu);
            this.panelLogo.Controls.Add(this.lblTSB);
            this.panelLogo.Location = new System.Drawing.Point(-1, 1);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1370, 139);
            this.panelLogo.TabIndex = 30;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(1242, 35);
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
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenu.Location = new System.Drawing.Point(386, 18);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(707, 108);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = " Buscar Cliente";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
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
            // dadosClienteBindingSource
            // 
            this.dadosClienteBindingSource.DataMember = "dadosCliente";
            this.dadosClienteBindingSource.DataSource = this.pIM4DataSet;
            // 
            // pIM4DataSet
            // 
            this.pIM4DataSet.DataSetName = "PIM4DataSet";
            this.pIM4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dadosClienteTableAdapter
            // 
            this.dadosClienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1048, 169);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(144, 50);
            this.btnEditar.TabIndex = 35;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(1214, 169);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(144, 50);
            this.btnExcluir.TabIndex = 36;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaNome.Location = new System.Drawing.Point(342, 249);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(176, 31);
            this.txtBuscaNome.TabIndex = 37;
            // 
            // txtBuscaEmail
            // 
            this.txtBuscaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaEmail.Location = new System.Drawing.Point(342, 311);
            this.txtBuscaEmail.Name = "txtBuscaEmail";
            this.txtBuscaEmail.Size = new System.Drawing.Size(189, 31);
            this.txtBuscaEmail.TabIndex = 38;
            // 
            // txtBuscaFone
            // 
            this.txtBuscaFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaFone.Location = new System.Drawing.Point(341, 369);
            this.txtBuscaFone.Name = "txtBuscaFone";
            this.txtBuscaFone.Size = new System.Drawing.Size(141, 31);
            this.txtBuscaFone.TabIndex = 39;
            // 
            // txtBuscaComplemento
            // 
            this.txtBuscaComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaComplemento.Location = new System.Drawing.Point(738, 316);
            this.txtBuscaComplemento.Name = "txtBuscaComplemento";
            this.txtBuscaComplemento.Size = new System.Drawing.Size(197, 31);
            this.txtBuscaComplemento.TabIndex = 41;
            // 
            // txtBuscaRua
            // 
            this.txtBuscaRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaRua.Location = new System.Drawing.Point(449, 188);
            this.txtBuscaRua.Name = "txtBuscaRua";
            this.txtBuscaRua.Size = new System.Drawing.Size(220, 31);
            this.txtBuscaRua.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 223);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Telefone";
            // 
            // cbBuscaEstCiv
            // 
            this.cbBuscaEstCiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscaEstCiv.FormattingEnabled = true;
            this.cbBuscaEstCiv.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Viuvo(a)",
            "Divorciado(a)"});
            this.cbBuscaEstCiv.Location = new System.Drawing.Point(510, 371);
            this.cbBuscaEstCiv.Name = "cbBuscaEstCiv";
            this.cbBuscaEstCiv.Size = new System.Drawing.Size(128, 33);
            this.cbBuscaEstCiv.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(512, 348);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Est. Civil";
            // 
            // lblBuscaComplemento
            // 
            this.lblBuscaComplemento.AutoSize = true;
            this.lblBuscaComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaComplemento.Location = new System.Drawing.Point(740, 293);
            this.lblBuscaComplemento.Name = "lblBuscaComplemento";
            this.lblBuscaComplemento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBuscaComplemento.Size = new System.Drawing.Size(108, 20);
            this.lblBuscaComplemento.TabIndex = 56;
            this.lblBuscaComplemento.Text = "Complemento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(632, 226);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(805, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Bairro";
            // 
            // txtBuscaCidade
            // 
            this.txtBuscaCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaCidade.Location = new System.Drawing.Point(635, 249);
            this.txtBuscaCidade.Name = "txtBuscaCidade";
            this.txtBuscaCidade.Size = new System.Drawing.Size(142, 31);
            this.txtBuscaCidade.TabIndex = 52;
            // 
            // txtBuscaBairro
            // 
            this.txtBuscaBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaBairro.Location = new System.Drawing.Point(805, 250);
            this.txtBuscaBairro.Name = "txtBuscaBairro";
            this.txtBuscaBairro.Size = new System.Drawing.Size(120, 31);
            this.txtBuscaBairro.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(535, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 58;
            this.label9.Text = "Nº";
            // 
            // txtBuscaNumero
            // 
            this.txtBuscaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaNumero.Location = new System.Drawing.Point(539, 250);
            this.txtBuscaNumero.Name = "txtBuscaNumero";
            this.txtBuscaNumero.Size = new System.Drawing.Size(70, 31);
            this.txtBuscaNumero.TabIndex = 57;
            // 
            // cbBuscaUf
            // 
            this.cbBuscaUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscaUf.FormattingEnabled = true;
            this.cbBuscaUf.Items.AddRange(new object[] {
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
            this.cbBuscaUf.Location = new System.Drawing.Point(699, 190);
            this.cbBuscaUf.Name = "cbBuscaUf";
            this.cbBuscaUf.Size = new System.Drawing.Size(50, 33);
            this.cbBuscaUf.TabIndex = 62;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(695, 167);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(26, 20);
            this.lblEstado.TabIndex = 63;
            this.lblEstado.Text = "Uf";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(443, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 64;
            this.label10.Text = "Rua";
            // 
            // pesquisaClientes
            // 
            this.pesquisaClientes.AllowUserToOrderColumns = true;
            this.pesquisaClientes.AutoGenerateColumns = false;
            this.pesquisaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pesquisaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.clientePj,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.foneCliente,
            this.emailCliente,
            this.rgCliente,
            this.cpfCliente,
            this.dataNascCliente,
            this.sexoCliente,
            this.estCivCliente,
            this.altura,
            this.peso,
            this.fumante,
            this.cirurgias,
            this.doencas,
            this.rua,
            this.numero,
            this.cidade,
            this.uf,
            this.bairro,
            this.complemento});
            this.pesquisaClientes.DataSource = this.dadosClienteBindingSource1;
            this.pesquisaClientes.Location = new System.Drawing.Point(342, 451);
            this.pesquisaClientes.Name = "pesquisaClientes";
            this.pesquisaClientes.Size = new System.Drawing.Size(998, 286);
            this.pesquisaClientes.TabIndex = 65;
            this.pesquisaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.pesquisaClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pesquisaClientes_CellDoubleClick);
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            // 
            // clientePj
            // 
            this.clientePj.DataPropertyName = "clientePj";
            this.clientePj.HeaderText = "clientePj";
            this.clientePj.Name = "clientePj";
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "nomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "nomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            // 
            // foneCliente
            // 
            this.foneCliente.DataPropertyName = "foneCliente";
            this.foneCliente.HeaderText = "foneCliente";
            this.foneCliente.Name = "foneCliente";
            // 
            // emailCliente
            // 
            this.emailCliente.DataPropertyName = "emailCliente";
            this.emailCliente.HeaderText = "emailCliente";
            this.emailCliente.Name = "emailCliente";
            // 
            // rgCliente
            // 
            this.rgCliente.DataPropertyName = "rgCliente";
            this.rgCliente.HeaderText = "rgCliente";
            this.rgCliente.Name = "rgCliente";
            // 
            // cpfCliente
            // 
            this.cpfCliente.DataPropertyName = "cpfCliente";
            this.cpfCliente.HeaderText = "cpfCliente";
            this.cpfCliente.Name = "cpfCliente";
            // 
            // dataNascCliente
            // 
            this.dataNascCliente.DataPropertyName = "dataNascCliente";
            this.dataNascCliente.HeaderText = "dataNascCliente";
            this.dataNascCliente.Name = "dataNascCliente";
            // 
            // sexoCliente
            // 
            this.sexoCliente.DataPropertyName = "sexoCliente";
            this.sexoCliente.HeaderText = "sexoCliente";
            this.sexoCliente.Name = "sexoCliente";
            // 
            // estCivCliente
            // 
            this.estCivCliente.DataPropertyName = "estCivCliente";
            this.estCivCliente.HeaderText = "estCivCliente";
            this.estCivCliente.Name = "estCivCliente";
            // 
            // altura
            // 
            this.altura.DataPropertyName = "altura";
            this.altura.HeaderText = "altura";
            this.altura.Name = "altura";
            // 
            // peso
            // 
            this.peso.DataPropertyName = "peso";
            this.peso.HeaderText = "peso";
            this.peso.Name = "peso";
            // 
            // fumante
            // 
            this.fumante.DataPropertyName = "fumante";
            this.fumante.HeaderText = "fumante";
            this.fumante.Name = "fumante";
            // 
            // cirurgias
            // 
            this.cirurgias.DataPropertyName = "cirurgias";
            this.cirurgias.HeaderText = "cirurgias";
            this.cirurgias.Name = "cirurgias";
            // 
            // doencas
            // 
            this.doencas.DataPropertyName = "doencas";
            this.doencas.HeaderText = "doencas";
            this.doencas.Name = "doencas";
            // 
            // rua
            // 
            this.rua.DataPropertyName = "rua";
            this.rua.HeaderText = "rua";
            this.rua.Name = "rua";
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "numero";
            this.numero.Name = "numero";
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "cidade";
            this.cidade.Name = "cidade";
            // 
            // uf
            // 
            this.uf.DataPropertyName = "uf";
            this.uf.HeaderText = "uf";
            this.uf.Name = "uf";
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "bairro";
            this.bairro.Name = "bairro";
            // 
            // complemento
            // 
            this.complemento.DataPropertyName = "complemento";
            this.complemento.HeaderText = "complemento";
            this.complemento.Name = "complemento";
            // 
            // dadosClienteBindingSource1
            // 
            this.dadosClienteBindingSource1.DataMember = "dadosCliente";
            this.dadosClienteBindingSource1.DataSource = this.pIM4DataSet1;
            // 
            // pIM4DataSet1
            // 
            this.pIM4DataSet1.DataSetName = "PIM4DataSet1";
            this.pIM4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dadosClienteTableAdapter1
            // 
            this.dadosClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 169);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Id";
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaId.Location = new System.Drawing.Point(342, 188);
            this.txtBuscaId.Name = "txtBuscaId";
            this.txtBuscaId.ReadOnly = true;
            this.txtBuscaId.Size = new System.Drawing.Size(67, 31);
            this.txtBuscaId.TabIndex = 66;
            // 
            // cbkBuscaDoenca
            // 
            this.cbkBuscaDoenca.AutoSize = true;
            this.cbkBuscaDoenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkBuscaDoenca.Location = new System.Drawing.Point(1033, 357);
            this.cbkBuscaDoenca.Name = "cbkBuscaDoenca";
            this.cbkBuscaDoenca.Size = new System.Drawing.Size(196, 24);
            this.cbkBuscaDoenca.TabIndex = 70;
            this.cbkBuscaDoenca.Text = "Doenças hereditárias  ?";
            this.cbkBuscaDoenca.UseVisualStyleBackColor = true;
            // 
            // cbkBuscaCirurgia
            // 
            this.cbkBuscaCirurgia.AutoSize = true;
            this.cbkBuscaCirurgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkBuscaCirurgia.Location = new System.Drawing.Point(1033, 334);
            this.cbkBuscaCirurgia.Name = "cbkBuscaCirurgia";
            this.cbkBuscaCirurgia.Size = new System.Drawing.Size(107, 24);
            this.cbkBuscaCirurgia.TabIndex = 69;
            this.cbkBuscaCirurgia.Text = "Cirurgias  ?";
            this.cbkBuscaCirurgia.UseVisualStyleBackColor = true;
            // 
            // cbkBuscaFumante
            // 
            this.cbkBuscaFumante.AutoSize = true;
            this.cbkBuscaFumante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkBuscaFumante.Location = new System.Drawing.Point(1033, 311);
            this.cbkBuscaFumante.Name = "cbkBuscaFumante";
            this.cbkBuscaFumante.Size = new System.Drawing.Size(105, 24);
            this.cbkBuscaFumante.TabIndex = 68;
            this.cbkBuscaFumante.Text = "Fumante ?";
            this.cbkBuscaFumante.UseVisualStyleBackColor = true;
            // 
            // mktBuscaClienteDataNasc
            // 
            this.mktBuscaClienteDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktBuscaClienteDataNasc.Location = new System.Drawing.Point(669, 374);
            this.mktBuscaClienteDataNasc.Mask = "00/00/0000";
            this.mktBuscaClienteDataNasc.Name = "mktBuscaClienteDataNasc";
            this.mktBuscaClienteDataNasc.ReadOnly = true;
            this.mktBuscaClienteDataNasc.Size = new System.Drawing.Size(120, 31);
            this.mktBuscaClienteDataNasc.TabIndex = 74;
            this.mktBuscaClienteDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // mktBuscaClienteCpf
            // 
            this.mktBuscaClienteCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktBuscaClienteCpf.Location = new System.Drawing.Point(566, 312);
            this.mktBuscaClienteCpf.Mask = "000000000-00";
            this.mktBuscaClienteCpf.Name = "mktBuscaClienteCpf";
            this.mktBuscaClienteCpf.ReadOnly = true;
            this.mktBuscaClienteCpf.Size = new System.Drawing.Size(142, 31);
            this.mktBuscaClienteCpf.TabIndex = 72;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(668, 354);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(88, 20);
            this.lblData.TabIndex = 73;
            this.lblData.Text = "Data Nasc.";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(563, 289);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(106, 20);
            this.lblCpf.TabIndex = 71;
            this.lblCpf.Text = "CPF ou CNPJ";
            // 
            // mktBuscaClienteRg
            // 
            this.mktBuscaClienteRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktBuscaClienteRg.Location = new System.Drawing.Point(805, 374);
            this.mktBuscaClienteRg.Mask = "00000000-0";
            this.mktBuscaClienteRg.Name = "mktBuscaClienteRg";
            this.mktBuscaClienteRg.ReadOnly = true;
            this.mktBuscaClienteRg.Size = new System.Drawing.Size(122, 31);
            this.mktBuscaClienteRg.TabIndex = 76;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(807, 355);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(34, 20);
            this.lblRg.TabIndex = 75;
            this.lblRg.Text = "RG";
            // 
            // ckbBuscaClientePj
            // 
            this.ckbBuscaClientePj.AutoSize = true;
            this.ckbBuscaClientePj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBuscaClientePj.Location = new System.Drawing.Point(1032, 380);
            this.ckbBuscaClientePj.Name = "ckbBuscaClientePj";
            this.ckbBuscaClientePj.Size = new System.Drawing.Size(107, 24);
            this.ckbBuscaClientePj.TabIndex = 77;
            this.ckbBuscaClientePj.Text = "Cliente Pj ?";
            this.ckbBuscaClientePj.UseVisualStyleBackColor = true;
            // 
            // txtBuscaPeso
            // 
            this.txtBuscaPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaPeso.Location = new System.Drawing.Point(957, 250);
            this.txtBuscaPeso.Name = "txtBuscaPeso";
            this.txtBuscaPeso.Size = new System.Drawing.Size(62, 31);
            this.txtBuscaPeso.TabIndex = 81;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(960, 230);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(45, 20);
            this.lblPeso.TabIndex = 80;
            this.lblPeso.Text = "Peso";
            this.lblPeso.Click += new System.EventHandler(this.lblPeso_Click);
            // 
            // txtBuscaAltura
            // 
            this.txtBuscaAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaAltura.Location = new System.Drawing.Point(957, 192);
            this.txtBuscaAltura.Name = "txtBuscaAltura";
            this.txtBuscaAltura.Size = new System.Drawing.Size(62, 31);
            this.txtBuscaAltura.TabIndex = 79;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(954, 173);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 20);
            this.lblAltura.TabIndex = 78;
            this.lblAltura.Text = "Altura";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(774, 169);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(45, 20);
            this.lblSexo.TabIndex = 83;
            this.lblSexo.Text = "Sexo";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(-1, 130);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(222, 61);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarMenu.Location = new System.Drawing.Point(-1, 325);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(222, 61);
            this.btnVoltarMenu.TabIndex = 7;
            this.btnVoltarMenu.Text = "Voltar ao Menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
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
            this.panel1.Location = new System.Drawing.Point(-1, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 611);
            this.panel1.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 16);
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
            this.btnEditarFuncionario.Text = "Cadastrar Cliente";
            this.btnEditarFuncionario.UseVisualStyleBackColor = true;
            this.btnEditarFuncionario.Click += new System.EventHandler(this.btnEditarFuncionario_Click);
            // 
            // cbBuscaClienteSexo
            // 
            this.cbBuscaClienteSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscaClienteSexo.Location = new System.Drawing.Point(778, 192);
            this.cbBuscaClienteSexo.Name = "cbBuscaClienteSexo";
            this.cbBuscaClienteSexo.Size = new System.Drawing.Size(141, 31);
            this.cbBuscaClienteSexo.TabIndex = 84;
            // 
            // TelaBuscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.cbBuscaClienteSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtBuscaPeso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtBuscaAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.ckbBuscaClientePj);
            this.Controls.Add(this.mktBuscaClienteRg);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.mktBuscaClienteDataNasc);
            this.Controls.Add(this.mktBuscaClienteCpf);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.cbkBuscaDoenca);
            this.Controls.Add(this.cbkBuscaCirurgia);
            this.Controls.Add(this.cbkBuscaFumante);
            this.Controls.Add(this.txtBuscaId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pesquisaClientes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbBuscaUf);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBuscaNumero);
            this.Controls.Add(this.lblBuscaComplemento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscaCidade);
            this.Controls.Add(this.txtBuscaBairro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBuscaEstCiv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscaRua);
            this.Controls.Add(this.txtBuscaComplemento);
            this.Controls.Add(this.txtBuscaFone);
            this.Controls.Add(this.txtBuscaEmail);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panelLogo);
            this.Name = "TelaBuscaCliente";
            this.Text = "TelaBusca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaBusca_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIM4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIM4DataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblTSB;
        private PIM4DataSet pIM4DataSet;
        private System.Windows.Forms.BindingSource dadosClienteBindingSource;
        private PIM4DataSetTableAdapters.dadosClienteTableAdapter dadosClienteTableAdapter;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.TextBox txtBuscaEmail;
        private System.Windows.Forms.TextBox txtBuscaFone;
        private System.Windows.Forms.TextBox txtBuscaComplemento;
        private System.Windows.Forms.TextBox txtBuscaRua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBuscaEstCiv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBuscaComplemento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscaCidade;
        private System.Windows.Forms.TextBox txtBuscaBairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBuscaNumero;
        private System.Windows.Forms.ComboBox cbBuscaUf;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView pesquisaClientes;
        private PIM4DataSet1 pIM4DataSet1;
        private System.Windows.Forms.BindingSource dadosClienteBindingSource1;
        private PIM4DataSet1TableAdapters.dadosClienteTableAdapter dadosClienteTableAdapter1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.CheckBox cbkBuscaDoenca;
        private System.Windows.Forms.CheckBox cbkBuscaCirurgia;
        private System.Windows.Forms.CheckBox cbkBuscaFumante;
        private System.Windows.Forms.MaskedTextBox mktBuscaClienteDataNasc;
        private System.Windows.Forms.MaskedTextBox mktBuscaClienteCpf;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mktBuscaClienteRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.CheckBox ckbBuscaClientePj;
        private System.Windows.Forms.TextBox txtBuscaPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtBuscaAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clientePj;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estCivCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fumante;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cirurgias;
        private System.Windows.Forms.DataGridViewCheckBoxColumn doencas;
        private System.Windows.Forms.DataGridViewTextBoxColumn rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditarFuncionario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cbBuscaClienteSexo;
    }
}