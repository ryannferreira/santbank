namespace banco
{
    partial class MenuPrincipalIHM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalIHM));
            this.lb_saldo = new System.Windows.Forms.Label();
            this.pic_extrato = new System.Windows.Forms.PictureBox();
            this.lb_nomeLogado = new System.Windows.Forms.Label();
            this.pic_sair = new System.Windows.Forms.PictureBox();
            this.pic_cartão = new System.Windows.Forms.PictureBox();
            this.pic_deposito = new System.Windows.Forms.PictureBox();
            this.pic_saque = new System.Windows.Forms.PictureBox();
            this.pic_transferencia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_extrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cartão)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_deposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_saque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_transferencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_saldo
            // 
            this.lb_saldo.AutoSize = true;
            this.lb_saldo.BackColor = System.Drawing.Color.Transparent;
            this.lb_saldo.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_saldo.ForeColor = System.Drawing.Color.White;
            this.lb_saldo.Location = new System.Drawing.Point(820, 57);
            this.lb_saldo.Name = "lb_saldo";
            this.lb_saldo.Size = new System.Drawing.Size(70, 22);
            this.lb_saldo.TabIndex = 1;
            this.lb_saldo.Text = "default";
            // 
            // pic_extrato
            // 
            this.pic_extrato.BackColor = System.Drawing.Color.Transparent;
            this.pic_extrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_extrato.Location = new System.Drawing.Point(163, 341);
            this.pic_extrato.Name = "pic_extrato";
            this.pic_extrato.Size = new System.Drawing.Size(173, 154);
            this.pic_extrato.TabIndex = 2;
            this.pic_extrato.TabStop = false;
            this.pic_extrato.Click += new System.EventHandler(this.pic_extrato_Click);
            // 
            // lb_nomeLogado
            // 
            this.lb_nomeLogado.AutoSize = true;
            this.lb_nomeLogado.BackColor = System.Drawing.Color.Transparent;
            this.lb_nomeLogado.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nomeLogado.ForeColor = System.Drawing.Color.White;
            this.lb_nomeLogado.Location = new System.Drawing.Point(195, 57);
            this.lb_nomeLogado.Name = "lb_nomeLogado";
            this.lb_nomeLogado.Size = new System.Drawing.Size(70, 22);
            this.lb_nomeLogado.TabIndex = 3;
            this.lb_nomeLogado.Text = "default";
            // 
            // pic_sair
            // 
            this.pic_sair.BackColor = System.Drawing.Color.Transparent;
            this.pic_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_sair.Location = new System.Drawing.Point(689, 341);
            this.pic_sair.Name = "pic_sair";
            this.pic_sair.Size = new System.Drawing.Size(173, 154);
            this.pic_sair.TabIndex = 4;
            this.pic_sair.TabStop = false;
            this.pic_sair.Click += new System.EventHandler(this.pic_sair_Click);
            // 
            // pic_cartão
            // 
            this.pic_cartão.BackColor = System.Drawing.Color.Transparent;
            this.pic_cartão.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_cartão.Location = new System.Drawing.Point(432, 341);
            this.pic_cartão.Name = "pic_cartão";
            this.pic_cartão.Size = new System.Drawing.Size(173, 154);
            this.pic_cartão.TabIndex = 5;
            this.pic_cartão.TabStop = false;
            this.pic_cartão.Click += new System.EventHandler(this.pic_cartão_Click);
            // 
            // pic_deposito
            // 
            this.pic_deposito.BackColor = System.Drawing.Color.Transparent;
            this.pic_deposito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_deposito.Location = new System.Drawing.Point(163, 147);
            this.pic_deposito.Name = "pic_deposito";
            this.pic_deposito.Size = new System.Drawing.Size(173, 154);
            this.pic_deposito.TabIndex = 6;
            this.pic_deposito.TabStop = false;
            this.pic_deposito.Click += new System.EventHandler(this.pic_deposito_Click);
            // 
            // pic_saque
            // 
            this.pic_saque.BackColor = System.Drawing.Color.Transparent;
            this.pic_saque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_saque.Location = new System.Drawing.Point(432, 147);
            this.pic_saque.Name = "pic_saque";
            this.pic_saque.Size = new System.Drawing.Size(173, 154);
            this.pic_saque.TabIndex = 7;
            this.pic_saque.TabStop = false;
            this.pic_saque.Click += new System.EventHandler(this.pic_saque_Click);
            // 
            // pic_transferencia
            // 
            this.pic_transferencia.BackColor = System.Drawing.Color.Transparent;
            this.pic_transferencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_transferencia.Location = new System.Drawing.Point(689, 147);
            this.pic_transferencia.Name = "pic_transferencia";
            this.pic_transferencia.Size = new System.Drawing.Size(173, 154);
            this.pic_transferencia.TabIndex = 8;
            this.pic_transferencia.TabStop = false;
            this.pic_transferencia.Click += new System.EventHandler(this.pic_transferencia_Click);
            // 
            // MenuPrincipalIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1015, 598);
            this.Controls.Add(this.pic_transferencia);
            this.Controls.Add(this.pic_saque);
            this.Controls.Add(this.pic_deposito);
            this.Controls.Add(this.pic_cartão);
            this.Controls.Add(this.pic_sair);
            this.Controls.Add(this.lb_nomeLogado);
            this.Controls.Add(this.pic_extrato);
            this.Controls.Add(this.lb_saldo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuPrincipalIHM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SANTBANK - Internet Banking";
            ((System.ComponentModel.ISupportInitialize)(this.pic_extrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cartão)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_deposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_saque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_transferencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_saldo;
        private System.Windows.Forms.PictureBox pic_extrato;
        private System.Windows.Forms.Label lb_nomeLogado;
        private System.Windows.Forms.PictureBox pic_sair;
        private System.Windows.Forms.PictureBox pic_cartão;
        private System.Windows.Forms.PictureBox pic_deposito;
        private System.Windows.Forms.PictureBox pic_saque;
        private System.Windows.Forms.PictureBox pic_transferencia;
    }
}