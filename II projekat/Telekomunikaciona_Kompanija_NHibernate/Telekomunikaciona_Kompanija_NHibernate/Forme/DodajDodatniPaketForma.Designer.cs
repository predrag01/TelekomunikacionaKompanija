﻿namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
    partial class DodajDodatniPaketForma
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDodaj = new System.Windows.Forms.Button();
			this.txbDodatniPaket = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Dodatni paket:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDodaj);
			this.groupBox1.Controls.Add(this.txbDodatniPaket);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(267, 180);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Osnovne informacije o dodatno paketu";
			// 
			// btnDodaj
			// 
			this.btnDodaj.BackColor = System.Drawing.Color.SandyBrown;
			this.btnDodaj.Location = new System.Drawing.Point(169, 143);
			this.btnDodaj.Name = "btnDodaj";
			this.btnDodaj.Size = new System.Drawing.Size(92, 27);
			this.btnDodaj.TabIndex = 2;
			this.btnDodaj.Text = "Dodaj";
			this.btnDodaj.UseVisualStyleBackColor = false;
			this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
			// 
			// txbDodatniPaket
			// 
			this.txbDodatniPaket.Location = new System.Drawing.Point(89, 25);
			this.txbDodatniPaket.Name = "txbDodatniPaket";
			this.txbDodatniPaket.Size = new System.Drawing.Size(172, 20);
			this.txbDodatniPaket.TabIndex = 1;
			// 
			// DodajDodatniPaketForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(288, 197);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "DodajDodatniPaketForma";
			this.Text = "DodajDodatniPaketForma";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txbDodatniPaket;
    }
}