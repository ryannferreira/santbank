namespace banco
{
    partial class SaqueIHM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaqueIHM));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_concluirSaque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_valorSaque = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_concluirSaque
            // 
            this.btn_concluirSaque.Location = new System.Drawing.Point(91, 149);
            this.btn_concluirSaque.Name = "btn_concluirSaque";
            this.btn_concluirSaque.Size = new System.Drawing.Size(97, 32);
            this.btn_concluirSaque.TabIndex = 6;
            this.btn_concluirSaque.Text = "Concluir";
            this.btn_concluirSaque.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(66, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o valor do saque:";
            // 
            // tb_valorSaque
            // 
            this.tb_valorSaque.Location = new System.Drawing.Point(81, 106);
            this.tb_valorSaque.Name = "tb_valorSaque";
            this.tb_valorSaque.Size = new System.Drawing.Size(116, 20);
            this.tb_valorSaque.TabIndex = 8;
            // 
            // SaqueIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 206);
            this.Controls.Add(this.tb_valorSaque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_concluirSaque);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaqueIHM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaqueIHM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_concluirSaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_valorSaque;
    }
}