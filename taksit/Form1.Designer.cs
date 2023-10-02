namespace taksit
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTaksitTutar = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.tbTaksitSayisi = new System.Windows.Forms.TrackBar();
            this.btnHesapla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbTaksitSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(110, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fiyat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taksit Sayısı:";
            // 
            // lblTaksitTutar
            // 
            this.lblTaksitTutar.AutoSize = true;
            this.lblTaksitTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaksitTutar.Location = new System.Drawing.Point(57, 226);
            this.lblTaksitTutar.Name = "lblTaksitTutar";
            this.lblTaksitTutar.Size = new System.Drawing.Size(129, 24);
            this.lblTaksitTutar.TabIndex = 2;
            this.lblTaksitTutar.Text = "Taksit Tutarı:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(190, 47);
            this.txtFiyat.Multiline = true;
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 45);
            this.txtFiyat.TabIndex = 3;
            // 
            // tbTaksitSayisi
            // 
            this.tbTaksitSayisi.Location = new System.Drawing.Point(190, 98);
            this.tbTaksitSayisi.Maximum = 12;
            this.tbTaksitSayisi.Minimum = 1;
            this.tbTaksitSayisi.Name = "tbTaksitSayisi";
            this.tbTaksitSayisi.Size = new System.Drawing.Size(194, 45);
            this.tbTaksitSayisi.TabIndex = 4;
            this.tbTaksitSayisi.Value = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(190, 161);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(194, 45);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.tbTaksitSayisi);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblTaksitTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbTaksitSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTaksitTutar;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TrackBar tbTaksitSayisi;
        private System.Windows.Forms.Button btnHesapla;
    }
}

