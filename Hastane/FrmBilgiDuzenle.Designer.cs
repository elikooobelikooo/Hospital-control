namespace Hastane
{
    partial class FrmBilgiDuzenle
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
            this.CmbCins = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtxSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnDuzenıe = new System.Windows.Forms.Button();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbCins
            // 
            this.CmbCins.FormattingEnabled = true;
            this.CmbCins.Items.AddRange(new object[] {
            "Erkek",
            "Kadin"});
            this.CmbCins.Location = new System.Drawing.Point(93, 155);
            this.CmbCins.Name = "CmbCins";
            this.CmbCins.Size = new System.Drawing.Size(100, 21);
            this.CmbCins.TabIndex = 33;
            this.CmbCins.SelectedIndexChanged += new System.EventHandler(this.CmbCins_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Cinsiyyet";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Sifre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(93, 129);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 30;
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(93, 103);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(100, 20);
            this.mskTelefon.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Soyad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtxSoyad
            // 
            this.TxtxSoyad.Location = new System.Drawing.Point(93, 51);
            this.TxtxSoyad.Name = "TxtxSoyad";
            this.TxtxSoyad.Size = new System.Drawing.Size(100, 20);
            this.TxtxSoyad.TabIndex = 26;
            this.TxtxSoyad.TextChanged += new System.EventHandler(this.TxtxSoyad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnDuzenıe
            // 
            this.BtnDuzenıe.Location = new System.Drawing.Point(93, 182);
            this.BtnDuzenıe.Name = "BtnDuzenıe";
            this.BtnDuzenıe.Size = new System.Drawing.Size(101, 23);
            this.BtnDuzenıe.TabIndex = 24;
            this.BtnDuzenıe.Text = "Duzenıe";
            this.BtnDuzenıe.UseVisualStyleBackColor = true;
            this.BtnDuzenıe.Click += new System.EventHandler(this.BtnDuzenıe_Click);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(93, 25);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 20);
            this.TxtAd.TabIndex = 23;
            this.TxtAd.TextChanged += new System.EventHandler(this.TxtAd_TextChanged);
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(93, 77);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(100, 20);
            this.mskTC.TabIndex = 22;
            this.mskTC.ValidatingType = typeof(int);
            this.mskTC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTC_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "TC Numara";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 224);
            this.Controls.Add(this.CmbCins);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtxSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnDuzenıe);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label2);
            this.Name = "FrmBilgiDuzenle";
            this.Text = "FrmBilgiDuzenle";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbCins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtxSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDuzenıe;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label2;
    }
}