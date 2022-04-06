namespace Proje_Hastane
{
    partial class FrmDoktorBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDüzenle));
            this.label5 = new System.Windows.Forms.Label();
            this.txbSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSifre = new System.Windows.Forms.TextBox();
            this.cmbBranş = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBilgileriGüncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Soyad:";
            // 
            // txbSoyad
            // 
            this.txbSoyad.Location = new System.Drawing.Point(179, 84);
            this.txbSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSoyad.Name = "txbSoyad";
            this.txbSoyad.Size = new System.Drawing.Size(167, 31);
            this.txbSoyad.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ad:";
            // 
            // txbAd
            // 
            this.txbAd.Location = new System.Drawing.Point(179, 45);
            this.txbAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbAd.Name = "txbAd";
            this.txbAd.Size = new System.Drawing.Size(167, 31);
            this.txbAd.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "TC Kimlik No:";
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(179, 123);
            this.mskTc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(116, 31);
            this.mskTc.TabIndex = 30;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Şifre:";
            // 
            // txbSifre
            // 
            this.txbSifre.Location = new System.Drawing.Point(179, 206);
            this.txbSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSifre.Name = "txbSifre";
            this.txbSifre.Size = new System.Drawing.Size(167, 31);
            this.txbSifre.TabIndex = 36;
            // 
            // cmbBranş
            // 
            this.cmbBranş.FormattingEnabled = true;
            this.cmbBranş.Location = new System.Drawing.Point(179, 163);
            this.cmbBranş.Name = "cmbBranş";
            this.cmbBranş.Size = new System.Drawing.Size(167, 31);
            this.cmbBranş.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Branş:";
            // 
            // btnBilgileriGüncelle
            // 
            this.btnBilgileriGüncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBilgileriGüncelle.Location = new System.Drawing.Point(179, 244);
            this.btnBilgileriGüncelle.Name = "btnBilgileriGüncelle";
            this.btnBilgileriGüncelle.Size = new System.Drawing.Size(167, 36);
            this.btnBilgileriGüncelle.TabIndex = 40;
            this.btnBilgileriGüncelle.Text = "Bilgilerimi Güncelle";
            this.btnBilgileriGüncelle.UseVisualStyleBackColor = true;
            this.btnBilgileriGüncelle.Click += new System.EventHandler(this.btnBilgileriGüncelle_Click);
            // 
            // FrmDoktorBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(415, 301);
            this.Controls.Add(this.btnBilgileriGüncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBranş);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskTc);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorBilgiDüzenle";
            this.Text = "Doktor Bilgi Güncelle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSifre;
        private System.Windows.Forms.ComboBox cmbBranş;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBilgileriGüncelle;
    }
}