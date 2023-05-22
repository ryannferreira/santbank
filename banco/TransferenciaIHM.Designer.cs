namespace banco
{
    partial class TransferenciaIHM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferenciaIHM));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_valorTransferencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_concluirTransferencia = new System.Windows.Forms.Button();
            this.mtb_cpfDestinatario = new System.Windows.Forms.MaskedTextBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(41, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o valor da transferência:";
            // 
            // tb_valorTransferencia
            // 
            this.tb_valorTransferencia.Location = new System.Drawing.Point(91, 109);
            this.tb_valorTransferencia.Name = "tb_valorTransferencia";
            this.tb_valorTransferencia.Size = new System.Drawing.Size(111, 20);
            this.tb_valorTransferencia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(47, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite o CPF do destinatário:";
            // 
            // btn_concluirTransferencia
            // 
            this.btn_concluirTransferencia.Location = new System.Drawing.Point(99, 244);
            this.btn_concluirTransferencia.Name = "btn_concluirTransferencia";
            this.btn_concluirTransferencia.Size = new System.Drawing.Size(97, 32);
            this.btn_concluirTransferencia.TabIndex = 5;
            this.btn_concluirTransferencia.Text = "Concluir";
            this.btn_concluirTransferencia.UseVisualStyleBackColor = true;
            // 
            // mtb_cpfDestinatario
            // 
            this.mtb_cpfDestinatario.Culture = new System.Globalization.CultureInfo("en-US");
            this.mtb_cpfDestinatario.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mtb_cpfDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.mtb_cpfDestinatario.Location = new System.Drawing.Point(91, 190);
            this.mtb_cpfDestinatario.Mask = "000.000.000-00";
            this.mtb_cpfDestinatario.Name = "mtb_cpfDestinatario";
            this.mtb_cpfDestinatario.Size = new System.Drawing.Size(111, 24);
            this.mtb_cpfDestinatario.TabIndex = 16;
            // 
            // TransferenciaIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 298);
            this.Controls.Add(this.mtb_cpfDestinatario);
            this.Controls.Add(this.btn_concluirTransferencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_valorTransferencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransferenciaIHM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransferenciaIHM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_valorTransferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_concluirTransferencia;
        private System.Windows.Forms.MaskedTextBox mtb_cpfDestinatario;
    }
}