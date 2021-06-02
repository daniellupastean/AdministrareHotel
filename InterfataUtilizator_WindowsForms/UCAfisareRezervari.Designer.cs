
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
            this.PnlAfisareRezervari = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LsBxAfisareRezervari = new System.Windows.Forms.ListBox();
            this.LblTitluAfisareRezervari = new System.Windows.Forms.Label();
            this.BtnStergeRezervare = new System.Windows.Forms.Button();
            this.PnlAfisareRezervari.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAfisareRezervari
            // 
            this.PnlAfisareRezervari.BackColor = System.Drawing.Color.Transparent;
            this.PnlAfisareRezervari.Controls.Add(this.panel1);
            this.PnlAfisareRezervari.Controls.Add(this.LblTitluAfisareRezervari);
            this.PnlAfisareRezervari.Location = new System.Drawing.Point(0, 0);
            this.PnlAfisareRezervari.Name = "PnlAfisareRezervari";
            this.PnlAfisareRezervari.Size = new System.Drawing.Size(824, 515);
            this.PnlAfisareRezervari.TabIndex = 7;
            this.PnlAfisareRezervari.VisibleChanged += new System.EventHandler(this.PnlAfisareRezervari_VisibleChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.BtnStergeRezervare);
            this.panel1.Controls.Add(this.LsBxAfisareRezervari);
            this.panel1.Location = new System.Drawing.Point(44, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 414);
            this.panel1.TabIndex = 25;
            // 
            // LsBxAfisareRezervari
            // 
            this.LsBxAfisareRezervari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.LsBxAfisareRezervari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsBxAfisareRezervari.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsBxAfisareRezervari.ForeColor = System.Drawing.Color.White;
            this.LsBxAfisareRezervari.FormattingEnabled = true;
            this.LsBxAfisareRezervari.ItemHeight = 16;
            this.LsBxAfisareRezervari.Location = new System.Drawing.Point(11, 12);
            this.LsBxAfisareRezervari.Name = "LsBxAfisareRezervari";
            this.LsBxAfisareRezervari.Size = new System.Drawing.Size(715, 336);
            this.LsBxAfisareRezervari.TabIndex = 25;
            this.LsBxAfisareRezervari.SelectedIndexChanged += new System.EventHandler(this.LsBxAfisareRezervari_SelectedIndexChanged);
            // 
            // LblTitluAfisareRezervari
            // 
            this.LblTitluAfisareRezervari.AutoSize = true;
            this.LblTitluAfisareRezervari.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitluAfisareRezervari.ForeColor = System.Drawing.Color.White;
            this.LblTitluAfisareRezervari.Location = new System.Drawing.Point(298, 32);
            this.LblTitluAfisareRezervari.Name = "LblTitluAfisareRezervari";
            this.LblTitluAfisareRezervari.Size = new System.Drawing.Size(232, 32);
            this.LblTitluAfisareRezervari.TabIndex = 23;
            this.LblTitluAfisareRezervari.Text = "Afisare Rezervari";
            // 
            // BtnStergeRezervare
            // 
            this.BtnStergeRezervare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(155)))), ((int)(((byte)(118)))));
            this.BtnStergeRezervare.FlatAppearance.BorderSize = 0;
            this.BtnStergeRezervare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStergeRezervare.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStergeRezervare.ForeColor = System.Drawing.Color.White;
            this.BtnStergeRezervare.Location = new System.Drawing.Point(320, 364);
            this.BtnStergeRezervare.Name = "BtnStergeRezervare";
            this.BtnStergeRezervare.Size = new System.Drawing.Size(94, 34);
            this.BtnStergeRezervare.TabIndex = 29;
            this.BtnStergeRezervare.Text = "Sterge";
            this.BtnStergeRezervare.UseVisualStyleBackColor = false;
            this.BtnStergeRezervare.Click += new System.EventHandler(this.BtnStergeRezervare_Click);
            // 
            // UCAfisareRezervari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.PnlAfisareRezervari);
            this.Name = "UCAfisareRezervari";
            this.Size = new System.Drawing.Size(824, 515);
            this.Load += new System.EventHandler(this.UCAfisareRezervari_Load);
            this.PnlAfisareRezervari.ResumeLayout(false);
            this.PnlAfisareRezervari.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAfisareRezervari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox LsBxAfisareRezervari;
        private System.Windows.Forms.Label LblTitluAfisareRezervari;
        private System.Windows.Forms.Button BtnStergeRezervare;
    }
}
