namespace tsbPIM.Apresentação
{
    partial class TelaBuscaVenda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditarFuncionario = new System.Windows.Forms.Button();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pIM4DataSet11 = new tsbPIM.PIM4DataSet11();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendasTableAdapter = new tsbPIM.PIM4DataSet11TableAdapters.vendasTableAdapter();
            this.vendasIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientevendasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcIdvendasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSeguradoravendasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIM4DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
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
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblMenu.Location = new System.Drawing.Point(688, 22);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(520, 135);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Apolices";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnEditarFuncionario);
            this.panel1.Controls.Add(this.btnVoltarMenu);
            this.panel1.Controls.Add(this.btnBuscarCliente);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(2, 171);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 752);
            this.panel1.TabIndex = 132;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 36);
            this.label8.TabIndex = 9;
            this.label8.Text = "Opções";
            // 
            // btnEditarFuncionario
            // 
            this.btnEditarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFuncionario.Location = new System.Drawing.Point(-1, 84);
            this.btnEditarFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Size = new System.Drawing.Size(296, 75);
            this.btnEditarFuncionario.TabIndex = 8;
            this.btnEditarFuncionario.Text = "Cadastrar Seguradora";
            this.btnEditarFuncionario.UseVisualStyleBackColor = true;
            this.btnEditarFuncionario.Click += new System.EventHandler(this.btnEditarFuncionario_Click);
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarMenu.Location = new System.Drawing.Point(-1, 373);
            this.btnVoltarMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(296, 75);
            this.btnVoltarMenu.TabIndex = 7;
            this.btnVoltarMenu.Text = "Voltar ao Menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(-1, 158);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(296, 75);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "Buscar Seguradora";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendasIdDataGridViewTextBoxColumn,
            this.planoDataGridViewTextBoxColumn,
            this.dataVendaDataGridViewTextBoxColumn,
            this.idClientevendasDataGridViewTextBoxColumn,
            this.funcIdvendasDataGridViewTextBoxColumn,
            this.idSeguradoravendasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(593, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 518);
            this.dataGridView1.TabIndex = 133;
            // 
            // pIM4DataSet11
            // 
            this.pIM4DataSet11.DataSetName = "PIM4DataSet11";
            this.pIM4DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "vendas";
            this.vendasBindingSource.DataSource = this.pIM4DataSet11;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // vendasIdDataGridViewTextBoxColumn
            // 
            this.vendasIdDataGridViewTextBoxColumn.DataPropertyName = "vendasId";
            this.vendasIdDataGridViewTextBoxColumn.HeaderText = "ID Venda";
            this.vendasIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vendasIdDataGridViewTextBoxColumn.Name = "vendasIdDataGridViewTextBoxColumn";
            this.vendasIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendasIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // planoDataGridViewTextBoxColumn
            // 
            this.planoDataGridViewTextBoxColumn.DataPropertyName = "plano";
            this.planoDataGridViewTextBoxColumn.HeaderText = "Plano";
            this.planoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.planoDataGridViewTextBoxColumn.Name = "planoDataGridViewTextBoxColumn";
            this.planoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataVendaDataGridViewTextBoxColumn
            // 
            this.dataVendaDataGridViewTextBoxColumn.DataPropertyName = "dataVenda";
            this.dataVendaDataGridViewTextBoxColumn.HeaderText = "Data da Venda";
            this.dataVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataVendaDataGridViewTextBoxColumn.Name = "dataVendaDataGridViewTextBoxColumn";
            this.dataVendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idClientevendasDataGridViewTextBoxColumn
            // 
            this.idClientevendasDataGridViewTextBoxColumn.DataPropertyName = "idCliente_vendas";
            this.idClientevendasDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.idClientevendasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idClientevendasDataGridViewTextBoxColumn.Name = "idClientevendasDataGridViewTextBoxColumn";
            this.idClientevendasDataGridViewTextBoxColumn.Width = 125;
            // 
            // funcIdvendasDataGridViewTextBoxColumn
            // 
            this.funcIdvendasDataGridViewTextBoxColumn.DataPropertyName = "funcId_vendas";
            this.funcIdvendasDataGridViewTextBoxColumn.HeaderText = "Funcionário";
            this.funcIdvendasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.funcIdvendasDataGridViewTextBoxColumn.Name = "funcIdvendasDataGridViewTextBoxColumn";
            this.funcIdvendasDataGridViewTextBoxColumn.Width = 125;
            // 
            // idSeguradoravendasDataGridViewTextBoxColumn
            // 
            this.idSeguradoravendasDataGridViewTextBoxColumn.DataPropertyName = "idSeguradora_vendas";
            this.idSeguradoravendasDataGridViewTextBoxColumn.HeaderText = "Serviço";
            this.idSeguradoravendasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSeguradoravendasDataGridViewTextBoxColumn.Name = "idSeguradoravendasDataGridViewTextBoxColumn";
            this.idSeguradoravendasDataGridViewTextBoxColumn.Width = 125;
            // 
            // TelaBuscaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLogo);
            this.Name = "TelaBuscaVenda";
            this.Text = "BuscaVenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaBuscaVenda_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIM4DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblTSB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditarFuncionario;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PIM4DataSet11 pIM4DataSet11;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private PIM4DataSet11TableAdapters.vendasTableAdapter vendasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendasIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientevendasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcIdvendasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSeguradoravendasDataGridViewTextBoxColumn;
    }
}