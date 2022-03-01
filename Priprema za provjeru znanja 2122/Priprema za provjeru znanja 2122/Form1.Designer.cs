namespace Priprema_za_provjeru_znanja_2122
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
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpGodPro = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.trckSnaga = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtIspis = new System.Windows.Forms.RichTextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.lblSnaga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trckSnaga)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Items.AddRange(new object[] {
            "Automobil",
            "JetSki",
            "Zrakomlat"});
            this.cmbVrsta.Location = new System.Drawing.Point(144, 64);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(121, 24);
            this.cmbVrsta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vrsta vozila";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(144, 94);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(121, 22);
            this.txtNaziv.TabIndex = 2;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(144, 122);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(121, 22);
            this.txtMarka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marka vozila";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Naziv vozila";
            // 
            // dtpGodPro
            // 
            this.dtpGodPro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGodPro.Location = new System.Drawing.Point(144, 150);
            this.dtpGodPro.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dtpGodPro.Name = "dtpGodPro";
            this.dtpGodPro.Size = new System.Drawing.Size(121, 22);
            this.dtpGodPro.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Godina proizvodnje:";
            // 
            // trckSnaga
            // 
            this.trckSnaga.LargeChange = 20;
            this.trckSnaga.Location = new System.Drawing.Point(144, 178);
            this.trckSnaga.Maximum = 350;
            this.trckSnaga.Minimum = 45;
            this.trckSnaga.Name = "trckSnaga";
            this.trckSnaga.Size = new System.Drawing.Size(121, 56);
            this.trckSnaga.SmallChange = 5;
            this.trckSnaga.TabIndex = 8;
            this.trckSnaga.Value = 45;
            this.trckSnaga.Scroll += new System.EventHandler(this.trckSnaga_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Snaga (KS):";
            // 
            // rtxtIspis
            // 
            this.rtxtIspis.Location = new System.Drawing.Point(316, 64);
            this.rtxtIspis.Name = "rtxtIspis";
            this.rtxtIspis.Size = new System.Drawing.Size(472, 374);
            this.rtxtIspis.TabIndex = 10;
            this.rtxtIspis.Text = "";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(58, 283);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(207, 74);
            this.btnUnesi.TabIndex = 11;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(58, 374);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(207, 64);
            this.btnIspisi.TabIndex = 12;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // lblSnaga
            // 
            this.lblSnaga.AutoSize = true;
            this.lblSnaga.Location = new System.Drawing.Point(191, 214);
            this.lblSnaga.Name = "lblSnaga";
            this.lblSnaga.Size = new System.Drawing.Size(21, 16);
            this.lblSnaga.TabIndex = 13;
            this.lblSnaga.Text = "45";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSnaga);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.rtxtIspis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trckSnaga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpGodPro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVrsta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trckSnaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpGodPro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trckSnaga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtIspis;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.Label lblSnaga;
    }
}

