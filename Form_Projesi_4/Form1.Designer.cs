namespace Form_Projesi_4
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
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.lbl_Adres = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Güncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.Ad = new System.Windows.Forms.ListBox();
            this.Soyad = new System.Windows.Forms.ListBox();
            this.Tel = new System.Windows.Forms.ListBox();
            this.Adres = new System.Windows.Forms.ListBox();
            this.Email = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(41, 36);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(23, 13);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "Ad:";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(41, 59);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(40, 13);
            this.lbl_soyad.TabIndex = 0;
            this.lbl_soyad.Text = "Soyad:";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(41, 84);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(25, 13);
            this.lbl_telefon.TabIndex = 0;
            this.lbl_telefon.Text = "Tel:";
            // 
            // lbl_Adres
            // 
            this.lbl_Adres.AutoSize = true;
            this.lbl_Adres.Location = new System.Drawing.Point(41, 109);
            this.lbl_Adres.Name = "lbl_Adres";
            this.lbl_Adres.Size = new System.Drawing.Size(37, 13);
            this.lbl_Adres.TabIndex = 0;
            this.lbl_Adres.Text = "Adres:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(41, 133);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(101, 29);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(109, 20);
            this.txt_Ad.TabIndex = 1;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(101, 55);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(109, 20);
            this.txt_Soyad.TabIndex = 2;
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(101, 81);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(109, 20);
            this.txt_Tel.TabIndex = 3;
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(101, 106);
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(109, 20);
            this.txt_Adres.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(101, 132);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(109, 20);
            this.txt_email.TabIndex = 3;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(60, 183);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(116, 38);
            this.btn_Kaydet.TabIndex = 5;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Güncelle
            // 
            this.btn_Güncelle.Location = new System.Drawing.Point(454, 183);
            this.btn_Güncelle.Name = "btn_Güncelle";
            this.btn_Güncelle.Size = new System.Drawing.Size(116, 38);
            this.btn_Güncelle.TabIndex = 5;
            this.btn_Güncelle.Text = "Güncelle";
            this.btn_Güncelle.UseVisualStyleBackColor = true;
            this.btn_Güncelle.Click += new System.EventHandler(this.btn_Güncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(257, 183);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(116, 38);
            this.btn_Sil.TabIndex = 5;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // Ad
            // 
            this.Ad.FormattingEnabled = true;
            this.Ad.Location = new System.Drawing.Point(257, 32);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(313, 17);
            this.Ad.TabIndex = 6;
            // 
            // Soyad
            // 
            this.Soyad.FormattingEnabled = true;
            this.Soyad.Location = new System.Drawing.Point(257, 58);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(313, 17);
            this.Soyad.TabIndex = 6;
            // 
            // Tel
            // 
            this.Tel.FormattingEnabled = true;
            this.Tel.Location = new System.Drawing.Point(257, 84);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(313, 17);
            this.Tel.TabIndex = 6;
            // 
            // Adres
            // 
            this.Adres.FormattingEnabled = true;
            this.Adres.Location = new System.Drawing.Point(257, 109);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(313, 17);
            this.Adres.TabIndex = 6;
            // 
            // Email
            // 
            this.Email.FormattingEnabled = true;
            this.Email.Location = new System.Drawing.Point(257, 135);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(313, 17);
            this.Email.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 249);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Güncelle);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_Adres);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Name = "Form1";
            this.Text = "Telefon Rehberi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_Adres;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Güncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.ListBox Ad;
        private System.Windows.Forms.ListBox Soyad;
        private System.Windows.Forms.ListBox Tel;
        private System.Windows.Forms.ListBox Adres;
        private System.Windows.Forms.ListBox Email;
    }
}

