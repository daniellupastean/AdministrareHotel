
namespace InterfataUtilizator_WindowsForms
{
    partial class UCAfisareCamere
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
            this.LsBxAfisareCamere = new System.Windows.Forms.ListBox();
            this.LblTitluAfisareCamere = new System.Windows.Forms.Label();
            this.PnlAfisareCamere.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAfisareCamere
            // 
            this.PnlAfisareCamere.BackColor = System.Drawing.Color.Transparent;
            this.PnlAfisareCamere.Controls.Add(this.panel1);
            this.PnlAfisareCamere.Controls.Add(this.LblTitluAfisareCamere);
            this.PnlAfisareCamere.Location = new System.Drawing.Point(0, 0);
            this.PnlAfisareCamere.Name = "PnlAfisareCamere";
            this.PnlAfisareCamere.Size = new System.Drawing.Size(824, 515);
            this.PnlAfisareCamere.TabIndex = 6;
            this.PnlAfisareCamere.VisibleChanged += new System.EventHandler(this.PnlAfisareCamere_VisibleChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.LsBxAfisareCamere);
            this.panel1.Location = new System.Drawing.Point(44, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 414);
            this.panel1.TabIndex = 25;
            // 
            // LsBxAfisareCamere
            // 
            this.LsBxAfisareCamere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsBxAfisareCamere.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsBxAfisareCamere.FormattingEnabled = true;
            this.LsBxAfisareCamere.ItemHeight = 16;
            this.LsBxAfisareCamere.Location = new System.Drawing.Point(11, 12);
            this.LsBxAfisareCamere.Name = "LsBxAfisareCamere";
            this.LsBxAfisareCamere.Size = new System.Drawing.Size(715, 384);
            this.LsBxAfisareCamere.TabIndex = 25;
            // 
            // LblTitluAfisareCamere
            // 
            this.LblTitluAfisareCamere.AutoSize = true;
            this.LblTitluAfisareCamere.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitluAfisareCamere.Location = new System.Drawing.Point(298, 32);
            this.LblTitluAfisareCamere.Name = "LblTitluAfisareCamere";
            this.LblTitluAfisareCamere.Size = new System.Drawing.Size(219, 33);
            this.LblTitluAfisareCamere.TabIndex = 23;
            this.LblTitluAfisareCamere.Text = "Afisare Camere";
            // 
            // UCAfisareCamere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlAfisareCamere);
            this.Name = "UCAfisareCamere";
            this.Size = new System.Drawing.Size(824, 515);
            this.Load += new System.EventHandler(this.UCAfisareCamere_Load);
            this.PnlAfisareCamere.ResumeLayout(false);
            this.PnlAfisareCamere.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAfisareCamere;
        private System.Windows.Forms.Label LblTitluAfisareCamere;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox LsBxAfisareCamere;
    }
}
