﻿
namespace InterfataUtilizator_WindowsForms
{
    partial class UCAfisareAngajati
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlAfisareCamere = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LsBxAfisareAngajati = new System.Windows.Forms.ListBox();
            this.LblTitluAfisareAngajati = new System.Windows.Forms.Label();
            this.PnlAfisareCamere.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAfisareCamere
            // 
            this.PnlAfisareCamere.BackColor = System.Drawing.Color.Transparent;
            this.PnlAfisareCamere.Controls.Add(this.panel1);
            this.PnlAfisareCamere.Controls.Add(this.LblTitluAfisareAngajati);
            this.PnlAfisareCamere.Location = new System.Drawing.Point(0, 0);
            this.PnlAfisareCamere.Name = "PnlAfisareCamere";
            this.PnlAfisareCamere.Size = new System.Drawing.Size(824, 515);
            this.PnlAfisareCamere.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.LsBxAfisareAngajati);
            this.panel1.Location = new System.Drawing.Point(44, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 414);
            this.panel1.TabIndex = 25;
            // 
            // LsBxAfisareAngajati
            // 
            this.LsBxAfisareAngajati.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsBxAfisareAngajati.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsBxAfisareAngajati.FormattingEnabled = true;
            this.LsBxAfisareAngajati.ItemHeight = 16;
            this.LsBxAfisareAngajati.Location = new System.Drawing.Point(11, 12);
            this.LsBxAfisareAngajati.Name = "LsBxAfisareAngajati";
            this.LsBxAfisareAngajati.Size = new System.Drawing.Size(715, 384);
            this.LsBxAfisareAngajati.TabIndex = 25;
            // 
            // LblTitluAfisareAngajati
            // 
            this.LblTitluAfisareAngajati.AutoSize = true;
            this.LblTitluAfisareAngajati.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitluAfisareAngajati.Location = new System.Drawing.Point(298, 32);
            this.LblTitluAfisareAngajati.Name = "LblTitluAfisareAngajati";
            this.LblTitluAfisareAngajati.Size = new System.Drawing.Size(220, 33);
            this.LblTitluAfisareAngajati.TabIndex = 23;
            this.LblTitluAfisareAngajati.Text = "Afisare Angajati";
            // 
            // UCAfisareAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlAfisareCamere);
            this.Name = "UCAfisareAngajati";
            this.Size = new System.Drawing.Size(824, 515);
            this.PnlAfisareCamere.ResumeLayout(false);
            this.PnlAfisareCamere.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAfisareCamere;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox LsBxAfisareAngajati;
        private System.Windows.Forms.Label LblTitluAfisareAngajati;
    }
}