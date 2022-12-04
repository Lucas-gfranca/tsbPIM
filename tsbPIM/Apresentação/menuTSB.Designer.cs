namespace tsbPIM.Apresentação
{
    partial class menuTSB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuTSB));
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblAssistencia = new System.Windows.Forms.Label();
            this.lblVendas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnAssistencia = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblTSB = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(1098, 246);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(89, 29);
            this.lblCliente.TabIndex = 33;
            this.lblCliente.Text = "Cliente";
            // 
            // lblAssistencia
            // 
            this.lblAssistencia.AutoSize = true;
            this.lblAssistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssistencia.Location = new System.Drawing.Point(748, 246);
            this.lblAssistencia.Name = "lblAssistencia";
            this.lblAssistencia.Size = new System.Drawing.Size(152, 29);
            this.lblAssistencia.TabIndex = 32;
            this.lblAssistencia.Text = "Seguradoras";
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendas.Location = new System.Drawing.Point(451, 246);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(94, 29);
            this.lblVendas.TabIndex = 31;
            this.lblVendas.Text = "Vendas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Funcionário";
            // 
            // btnCliente
            // 
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(1047, 278);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(204, 169);
            this.btnCliente.TabIndex = 26;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnAssistencia
            // 
            this.btnAssistencia.Image = ((System.Drawing.Image)(resources.GetObject("btnAssistencia.Image")));
            this.btnAssistencia.Location = new System.Drawing.Point(722, 278);
            this.btnAssistencia.Name = "btnAssistencia";
            this.btnAssistencia.Size = new System.Drawing.Size(204, 169);
            this.btnAssistencia.TabIndex = 25;
            this.btnAssistencia.UseVisualStyleBackColor = true;
            this.btnAssistencia.Click += new System.EventHandler(this.btnAssistencia_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVendas.Image")));
            this.btnVendas.Location = new System.Drawing.Point(400, 278);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVendas.Size = new System.Drawing.Size(204, 169);
            this.btnVendas.TabIndex = 24;
            this.btnVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.FlatAppearance.BorderSize = 5;
            this.btnFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionario.Image")));
            this.btnFuncionario.Location = new System.Drawing.Point(100, 278);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(204, 169);
            this.btnFuncionario.TabIndex = 23;
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelLogo.Controls.Add(this.btnSair);
            this.panelLogo.Controls.Add(this.lblMenu);
            this.panelLogo.Controls.Add(this.lblTSB);
            this.panelLogo.Location = new System.Drawing.Point(2, 1);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1370, 139);
            this.panelLogo.TabIndex = 22;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(1260, 18);
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
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenu.Location = new System.Drawing.Point(577, 18);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(284, 108);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Menu";
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
            this.lblTSB.Click += new System.EventHandler(this.lblTSB_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.Location = new System.Drawing.Point(14, 716);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(125, 24);
            this.lblVersao.TabIndex = 37;
            this.lblVersao.Text = "Versão: 0.001";
            this.lblVersao.Click += new System.EventHandler(this.lblVersao_Click);
            // 
            // menuTSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblAssistencia);
            this.Controls.Add(this.lblVendas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnAssistencia);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.panelLogo);
            this.Name = "menuTSB";
            this.Text = "menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblAssistencia;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnAssistencia;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblTSB;
        private System.Windows.Forms.Label lblVersao;
    }
}