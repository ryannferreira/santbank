namespace banco
{
    partial class LoginIHM
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginIHM));
            this.btn_logar = new System.Windows.Forms.Button();
            this.btn_cadastreSe = new System.Windows.Forms.Button();
            this.tb_loginSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtb_loginCpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_logar
            // 
            this.btn_logar.BackColor = System.Drawing.Color.White;
            this.btn_logar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_logar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_logar.Location = new System.Drawing.Point(186, 408);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(119, 29);
            this.btn_logar.TabIndex = 5;
            this.btn_logar.Text = "Acessar";
            this.btn_logar.UseVisualStyleBackColor = false;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // btn_cadastreSe
            // 
            this.btn_cadastreSe.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_cadastreSe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastreSe.FlatAppearance.BorderSize = 0;
            this.btn_cadastreSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastreSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btn_cadastreSe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cadastreSe.Location = new System.Drawing.Point(948, 65);
            this.btn_cadastreSe.Name = "btn_cadastreSe";
            this.btn_cadastreSe.Size = new System.Drawing.Size(169, 37);
            this.btn_cadastreSe.TabIndex = 4;
            this.btn_cadastreSe.Text = "Crie sua conta";
            this.btn_cadastreSe.UseVisualStyleBackColor = false;
            this.btn_cadastreSe.Click += new System.EventHandler(this.btn_cadastreSe_Click);
            // 
            // tb_loginSenha
            // 
            this.tb_loginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_loginSenha.Location = new System.Drawing.Point(216, 343);
            this.tb_loginSenha.Name = "tb_loginSenha";
            this.tb_loginSenha.Size = new System.Drawing.Size(122, 26);
            this.tb_loginSenha.TabIndex = 3;
            this.tb_loginSenha.UseSystemPasswordChar = true;
            this.tb_loginSenha.TextChanged += new System.EventHandler(this.tb_loginSenha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(146, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(146, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "ACESSE SUA CONTA";
            // 
            // mtb_loginCpf
            // 
            this.mtb_loginCpf.Culture = new System.Globalization.CultureInfo("es-US");
            this.mtb_loginCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtb_loginCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_loginCpf.Location = new System.Drawing.Point(203, 289);
            this.mtb_loginCpf.Mask = "000.000.000-00";
            this.mtb_loginCpf.Name = "mtb_loginCpf";
            this.mtb_loginCpf.Size = new System.Drawing.Size(121, 26);
            this.mtb_loginCpf.TabIndex = 7;
            this.mtb_loginCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtb_loginCpf_MaskInputRejected);
            // 
            // LoginIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 601);
            this.Controls.Add(this.mtb_loginCpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cadastreSe);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.tb_loginSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "LoginIHM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SANTBANK - Internet Banking";
            this.Load += new System.EventHandler(this.LoginIHM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cadastreSe;
        private System.Windows.Forms.TextBox tb_loginSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtb_loginCpf;
    }
}

