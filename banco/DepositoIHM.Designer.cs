namespace banco
{
    partial class DepositoIHM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositoIHM));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_concluirDeposito = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_valorDeposito = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_concluirDeposito
            // 
            this.btn_concluirDeposito.Location = new System.Drawing.Point(96, 148);
            this.btn_concluirDeposito.Name = "btn_concluirDeposito";
            this.btn_concluirDeposito.Size = new System.Drawing.Size(97, 32);
            this.btn_concluirDeposito.TabIndex = 13;
            this.btn_concluirDeposito.Text = "Concluir";
            this.btn_concluirDeposito.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(56, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Digite o valor do depósito:";
            // 
            // tb_valorDeposito
            // 
            this.tb_valorDeposito.Location = new System.Drawing.Point(86, 107);
            this.tb_valorDeposito.Name = "tb_valorDeposito";
            this.tb_valorDeposito.Size = new System.Drawing.Size(116, 20);
            this.tb_valorDeposito.TabIndex = 15;
            // 
            // DepositoIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.tb_valorDeposito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_concluirDeposito);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepositoIHM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositoIHM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_concluirDeposito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_valorDeposito;
    }
}