
namespace InterfataUtilizator_WindowsForms
{
    partial class UCAfisareRezervari
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
            this.LsBxAfisareRezervari = new System.Windows.Forms.ListBox();
            this.LblTitluAfisareRezervari = new System.Windows.Forms.Label();
            this.PnlAfisareCamere.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAfisareCamere
            // 
            this.PnlAfisareCamere.BackColor = System.Drawing.Color.Transparent;
            this.PnlAfisareCamere.Controls.Add(this.panel1);
            this.PnlAfisareCamere.Controls.Add(this.LblTitluAfisareRezervari);
            this.PnlAfisareCamere.Location = new System.Drawing.Point(0, 0);
            this.PnlAfisareCamere.Name = "PnlAfisareCamere";
            this.PnlAfisareCamere.Size = new System.Drawing.Size(824, 515);
            this.PnlAfisareCamere.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.LsBxAfisareRezervari);
            this.panel1.Location = new System.Drawing.Point(44, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 414);
            this.panel1.TabIndex = 25;
            // 
            // LsBxAfisareRezervari
            // 
            this.LsBxAfisareRezervari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsBxAfisareRezervari.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsBxAfisareRezervari.FormattingEnabled = true;
            this.LsBxAfisareRezervari.ItemHeight = 16;
            this.LsBxAfisareRezervari.Location = new System.Drawing.Point(11, 12);
            this.LsBxAfisareRezervari.Name = "LsBxAfisareRezervari";
            this.LsBxAfisareRezervari.Size = new System.Drawing.Size(715, 384);
            this.LsBxAfisareRezervari.TabIndex = 25;
            // 
            // LblTitluAfisareRezervari
            // 
            this.LblTitluAfisareRezervari.AutoSize = true;
            this.LblTitluAfisareRezervari.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitluAfisareRezervari.Location = new System.Drawing.Point(298, 32);
            this.LblTitluAfisareRezervari.Name = "LblTitluAfisareRezervari";
            this.LblTitluAfisareRezervari.Size = new System.Drawing.Size(229, 33);
            this.LblTitluAfisareRezervari.TabIndex = 23;
            this.LblTitluAfisareRezervari.Text = "Afisare Rezervari";
            // 
            // UCAfisareRezervari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlAfisareCamere);
            this.Name = "UCAfisareRezervari";
            this.Size = new System.Drawing.Size(824, 515);
            this.PnlAfisareCamere.ResumeLayout(false);
            this.PnlAfisareCamere.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAfisareCamere;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox LsBxAfisareRezervari;
        private System.Windows.Forms.Label LblTitluAfisareRezervari;
    }
}
