namespace PripremaZaProvjeruZnanja
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
            this.btnUnesi = new System.Windows.Forms.Button();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.dtpGodPro = new System.Windows.Forms.DateTimePicker();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.trckSnaga = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtIspis = new System.Windows.Forms.RichTextBox();
            this.lblVrijednost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trckSnaga)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(59, 242);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(200, 40);
            this.btnUnesi.TabIndex = 0;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Items.AddRange(new object[] {
            "Automobil",
            "JetSki",
            "Zrakomlat"});
            this.cmbVrsta.Location = new System.Drawing.Point(59, 51);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(145, 21);
            this.cmbVrsta.TabIndex = 1;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(322, 102);
            this.txtMarka.Multiline = true;
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(145, 20);
            this.txtMarka.TabIndex = 2;
            // 
            // dtpGodPro
            // 
            this.dtpGodPro.CustomFormat = "";
            this.dtpGodPro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGodPro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpGodPro.Location = new System.Drawing.Point(322, 52);
            this.dtpGodPro.Name = "dtpGodPro";
            this.dtpGodPro.ShowCheckBox = true;
            this.dtpGodPro.Size = new System.Drawing.Size(145, 20);
            this.dtpGodPro.TabIndex = 3;
            this.dtpGodPro.Value = new System.DateTime(2022, 3, 1, 0, 0, 0, 0);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(59, 102);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(145, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // trckSnaga
            // 
            this.trckSnaga.LargeChange = 20;
            this.trckSnaga.Location = new System.Drawing.Point(59, 166);
            this.trckSnaga.Maximum = 350;
            this.trckSnaga.Minimum = 45;
            this.trckSnaga.Name = "trckSnaga";
            this.trckSnaga.Size = new System.Drawing.Size(408, 45);
            this.trckSnaga.SmallChange = 5;
            this.trckSnaga.TabIndex = 5;
            this.trckSnaga.Value = 45;
            this.trckSnaga.Scroll += new System.EventHandler(this.trckSnaga_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vrsta vozila :";
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(267, 242);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(200, 40);
            this.btnIspisi.TabIndex = 7;
            this.btnIspisi.Text = "Ispis";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Snaga (KS) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Godina proizvodnje : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Naziv vozila :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Marka vozila : ";
            // 
            // rtxtIspis
            // 
            this.rtxtIspis.Location = new System.Drawing.Point(59, 303);
            this.rtxtIspis.Name = "rtxtIspis";
            this.rtxtIspis.Size = new System.Drawing.Size(408, 197);
            this.rtxtIspis.TabIndex = 13;
            this.rtxtIspis.Text = "";
            // 
            // lblVrijednost
            // 
            this.lblVrijednost.AutoSize = true;
            this.lblVrijednost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrijednost.Location = new System.Drawing.Point(247, 205);
            this.lblVrijednost.Name = "lblVrijednost";
            this.lblVrijednost.Size = new System.Drawing.Size(30, 24);
            this.lblVrijednost.TabIndex = 14;
            this.lblVrijednost.Text = "45";
            this.lblVrijednost.Click += new System.EventHandler(this.lblVrijednost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 564);
            this.Controls.Add(this.lblVrijednost);
            this.Controls.Add(this.rtxtIspis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trckSnaga);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.dtpGodPro);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.cmbVrsta);
            this.Controls.Add(this.btnUnesi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trckSnaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.DateTimePicker dtpGodPro;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TrackBar trckSnaga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtIspis;
        private System.Windows.Forms.Label lblVrijednost;
    }
}

