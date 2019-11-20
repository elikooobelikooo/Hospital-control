namespace Hastane
{
    partial class frmDoctorDuzenıe
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
            this.TxtxSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbBranch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnDuzenıe = new System.Windows.Forms.Button();
            this.Sifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Soyad";
            // 
            // TxtxSoyad
            // 
            this.TxtxSoyad.Location = new System.Drawing.Point(87, 51);
            this.TxtxSoyad.Name = "TxtxSoyad";
            this.TxtxSoyad.Size = new System.Drawing.Size(100, 20);
            this.TxtxSoyad.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ad";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(87, 25);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 20);
            this.TxtAd.TabIndex = 36;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(87, 90);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(100, 20);
            this.mskTC.TabIndex = 35;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "TC Numara";
            // 
            // CmbBranch
            // 
            this.CmbBranch.FormattingEnabled = true;
            this.CmbBranch.Location = new System.Drawing.Point(87, 116);
            this.CmbBranch.Name = "CmbBranch";
            this.CmbBranch.Size = new System.Drawing.Size(100, 21);
            this.CmbBranch.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Branch";
            // 
            // BtnDuzenıe
            // 
            this.BtnDuzenıe.Location = new System.Drawing.Point(87, 175);
            this.BtnDuzenıe.Name = "BtnDuzenıe";
            this.BtnDuzenıe.Size = new System.Drawing.Size(101, 23);
            this.BtnDuzenıe.TabIndex = 37;
            this.BtnDuzenıe.Text = "Duzenıe";
            this.BtnDuzenıe.UseVisualStyleBackColor = true;
            this.BtnDuzenıe.Click += new System.EventHandler(this.BtnDuzenıe_Click);
            // 
            // Sifre
            // 
            this.Sifre.AutoSize = true;
            this.Sifre.Location = new System.Drawing.Point(52, 146);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(28, 13);
            this.Sifre.TabIndex = 48;
            this.Sifre.Text = "Sifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(87, 143);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 47;
            // 
            // frmDoctorDuzenıe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 209);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.CmbBranch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtxSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnDuzenıe);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label2);
            this.Name = "frmDoctorDuzenıe";
            this.Text = "frmDoctorDuzenıe";
            this.Load += new System.EventHandler(this.frmDoctorDuzenıe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtxSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbBranch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnDuzenıe;
        private System.Windows.Forms.Label Sifre;
        private System.Windows.Forms.TextBox txtSifre;
    }
}