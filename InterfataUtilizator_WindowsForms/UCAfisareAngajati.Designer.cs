
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
            this.PnlAfisareAngajati = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LsBxAfisareAngajati = new System.Windows.Forms.ListBox();
            this.LblTitluAfisareAngajati = new System.Windows.Forms.Label();
            this.BtnStergeAngajat = new System.Windows.Forms.Button();
            this.PnlAfisareAngajati.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAfisareAngajati
            // 
            this.PnlAfisareAngajati.BackColor = System.Drawing.Color.Transparent;
            this.PnlAfisareAngajati.Controls.Add(this.panel1);
            this.PnlAfisareAngajati.Controls.Add(this.LblTitluAfisareAngajati);
            this.PnlAfisareAngajati.Location = new System.Drawing.Point(0, 0);
            this.PnlAfisareAngajati.Name = "PnlAfisareAngajati";
            this.PnlAfisareAngajati.Size = new System.Drawing.Size(824, 515);
            this.PnlAfisareAngajati.TabIndex = 8;
            this.PnlAfisareAngajati.VisibleChanged += new System.EventHandler(this.PnlAfisareCamere_VisibleChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.BtnStergeAngajat);
            this.panel1.Controls.Add(this.LsBxAfisareAngajati);
            this.panel1.Location = new System.Drawing.Point(44, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 414);
            this.panel1.TabIndex = 25;
            // 
            // LsBxAfisareAngajati
            // 
            this.LsBxAfisareAngajati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.LsBxAfisareAngajati.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsBxAfisareAngajati.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsBxAfisareAngajati.ForeColor = System.Drawing.Color.White;
            this.LsBxAfisareAngajati.FormattingEnabled = true;
            this.LsBxAfisareAngajati.ItemHeight = 16;
            this.LsBxAfisareAngajati.Location = new System.Drawing.Point(11, 15);
            this.LsBxAfisareAngajati.Name = "LsBxAfisareAngajati";
            this.LsBxAfisareAngajati.Size = new System.Drawing.Size(715, 336);
            this.LsBxAfisareAngajati.TabIndex = 26;
            this.LsBxAfisareAngajati.SelectedIndexChanged += new System.EventHandler(this.LsBxAfisareAngajati_SelectedIndexChanged);
            // 
            // LblTitluAfisareAngajati
            // 
            this.LblTitluAfisareAngajati.AutoSize = true;
            this.LblTitluAfisareAngajati.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitluAfisareAngajati.ForeColor = System.Drawing.Color.White;
            this.LblTitluAfisareAngajati.Location = new System.Drawing.Point(298, 32);
            this.LblTitluAfisareAngajati.Name = "LblTitluAfisareAngajati";
            this.LblTitluAfisareAngajati.Size = new System.Drawing.Size(224, 32);
            this.LblTitluAfisareAngajati.TabIndex = 23;
            this.LblTitluAfisareAngajati.Text = "Afisare Angajati";
            // 
            // BtnStergeAngajat
            // 
            this.BtnStergeAngajat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(155)))), ((int)(((byte)(118)))));
            this.BtnStergeAngajat.FlatAppearance.BorderSize = 0;
            this.BtnStergeAngajat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStergeAngajat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStergeAngajat.ForeColor = System.Drawing.Color.White;
            this.BtnStergeAngajat.Location = new System.Drawing.Point(320, 364);
            this.BtnStergeAngajat.Name = "BtnStergeAngajat";
            this.BtnStergeAngajat.Size = new System.Drawing.Size(94, 34);
            this.BtnStergeAngajat.TabIndex = 28;
            this.BtnStergeAngajat.Text = "Sterge";
            this.BtnStergeAngajat.UseVisualStyleBackColor = false;
            this.BtnStergeAngajat.Click += new System.EventHandler(this.BtnStergeAngajat_Click);
            // 
            // UCAfisareAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.PnlAfisareAngajati);
            this.Name = "UCAfisareAngajati";
            this.Size = new System.Drawing.Size(824, 515);
            this.Load += new System.EventHandler(this.UCAfisareAngajati_Load);
            this.PnlAfisareAngajati.ResumeLayout(false);
            this.PnlAfisareAngajati.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAfisareAngajati;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitluAfisareAngajati;
        private System.Windows.Forms.ListBox LsBxAfisareAngajati;
        private System.Windows.Forms.Button BtnStergeAngajat;
    }
}
