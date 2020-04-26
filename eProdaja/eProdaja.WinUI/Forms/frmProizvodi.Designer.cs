namespace eProdaja.WinUI.Forms
{
    partial class frmProizvodi
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.btn_DodajImg = new System.Windows.Forms.Button();
            this.btn_Sacuvaj = new System.Windows.Forms.Button();
            this.cmbVrProizvoda = new System.Windows.Forms.ComboBox();
            this.cmbJedMjere = new System.Windows.Forms.ComboBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrste proizvoda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Šifra: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Naziv:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cijena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Slika:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Jed. mjere:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(230, 104);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(243, 22);
            this.txtSifra.TabIndex = 7;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(230, 142);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(243, 22);
            this.txtNaziv.TabIndex = 8;
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(230, 224);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(243, 22);
            this.txtSlika.TabIndex = 9;
            // 
            // btn_DodajImg
            // 
            this.btn_DodajImg.Location = new System.Drawing.Point(491, 221);
            this.btn_DodajImg.Name = "btn_DodajImg";
            this.btn_DodajImg.Size = new System.Drawing.Size(83, 29);
            this.btn_DodajImg.TabIndex = 10;
            this.btn_DodajImg.Text = "Dodaj";
            this.btn_DodajImg.UseVisualStyleBackColor = true;
            this.btn_DodajImg.Click += new System.EventHandler(this.btn_DodajImg_Click);
            // 
            // btn_Sacuvaj
            // 
            this.btn_Sacuvaj.Location = new System.Drawing.Point(725, 308);
            this.btn_Sacuvaj.Name = "btn_Sacuvaj";
            this.btn_Sacuvaj.Size = new System.Drawing.Size(133, 61);
            this.btn_Sacuvaj.TabIndex = 12;
            this.btn_Sacuvaj.Text = "Sacuvaj";
            this.btn_Sacuvaj.UseVisualStyleBackColor = true;
            this.btn_Sacuvaj.Click += new System.EventHandler(this.btn_Sacuvaj_Click);
            // 
            // cmbVrProizvoda
            // 
            this.cmbVrProizvoda.FormattingEnabled = true;
            this.cmbVrProizvoda.Location = new System.Drawing.Point(230, 65);
            this.cmbVrProizvoda.Name = "cmbVrProizvoda";
            this.cmbVrProizvoda.Size = new System.Drawing.Size(243, 24);
            this.cmbVrProizvoda.TabIndex = 13;
            this.cmbVrProizvoda.SelectedIndexChanged += new System.EventHandler(this.cmbVrProizvoda_SelectedIndexChanged);
            // 
            // cmbJedMjere
            // 
            this.cmbJedMjere.FormattingEnabled = true;
            this.cmbJedMjere.Location = new System.Drawing.Point(327, 183);
            this.cmbJedMjere.Name = "cmbJedMjere";
            this.cmbJedMjere.Size = new System.Drawing.Size(146, 24);
            this.cmbJedMjere.TabIndex = 14;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(130, 186);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(79, 22);
            this.txtCijena.TabIndex = 15;
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(12, 396);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.RowHeadersWidth = 51;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.Size = new System.Drawing.Size(899, 216);
            this.dgvProizvodi.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(653, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 624);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.cmbJedMjere);
            this.Controls.Add(this.cmbVrProizvoda);
            this.Controls.Add(this.btn_Sacuvaj);
            this.Controls.Add(this.btn_DodajImg);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProizvodi";
            this.Text = "frmProizvodi";
            this.Load += new System.EventHandler(this.frmProizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Button btn_DodajImg;
        private System.Windows.Forms.Button btn_Sacuvaj;
        private System.Windows.Forms.ComboBox cmbVrProizvoda;
        private System.Windows.Forms.ComboBox cmbJedMjere;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}