namespace banco
{
    partial class CadastroIHM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroIHM));
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nomeCompleto = new System.Windows.Forms.TextBox();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_voltarMenu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_senhaConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(186, 353);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(192, 49);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(39, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(354, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(39, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(39, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(309, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telefone:";
            // 
            // tb_nomeCompleto
            // 
            this.tb_nomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tb_nomeCompleto.Location = new System.Drawing.Point(43, 132);
            this.tb_nomeCompleto.Name = "tb_nomeCompleto";
            this.tb_nomeCompleto.Size = new System.Drawing.Size(269, 24);
            this.tb_nomeCompleto.TabIndex = 14;
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Culture = new System.Globalization.CultureInfo("en-US");
            this.mtb_cpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mtb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.mtb_cpf.Location = new System.Drawing.Point(357, 132);
            this.mtb_cpf.Mask = "000.000.000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(111, 24);
            this.mtb_cpf.TabIndex = 15;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tb_email.Location = new System.Drawing.Point(43, 202);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(198, 24);
            this.tb_email.TabIndex = 16;
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.mtb_telefone.Location = new System.Drawing.Point(314, 199);
            this.mtb_telefone.Mask = "(99) 00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(117, 24);
            this.mtb_telefone.TabIndex = 17;
            // 
            // tb_senha
            // 
            this.tb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tb_senha.Location = new System.Drawing.Point(42, 280);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(160, 24);
            this.tb_senha.TabIndex = 18;
            this.tb_senha.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 60);
            this.panel1.TabIndex = 1;
            // 
            // lb_voltarMenu
            // 
            this.lb_voltarMenu.AutoSize = true;
            this.lb_voltarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_voltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lb_voltarMenu.ForeColor = System.Drawing.Color.Black;
            this.lb_voltarMenu.Location = new System.Drawing.Point(216, 414);
            this.lb_voltarMenu.Name = "lb_voltarMenu";
            this.lb_voltarMenu.Size = new System.Drawing.Size(133, 18);
            this.lb_voltarMenu.TabIndex = 20;
            this.lb_voltarMenu.Text = "Voltar para o menu";
            this.lb_voltarMenu.Click += new System.EventHandler(this.lb_voltarMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(286, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Confirme sua senha:";
            // 
            // tb_senhaConfirm
            // 
            this.tb_senhaConfirm.Location = new System.Drawing.Point(289, 278);
            this.tb_senhaConfirm.Name = "tb_senhaConfirm";
            this.tb_senhaConfirm.Size = new System.Drawing.Size(160, 26);
            this.tb_senhaConfirm.TabIndex = 22;
            this.tb_senhaConfirm.UseSystemPasswordChar = true;
            // 
            // CadastroIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 455);
            this.Controls.Add(this.tb_senhaConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_voltarMenu);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.tb_nomeCompleto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "CadastroIHM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_nomeCompleto;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_voltarMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_senhaConfirm;
    }
}