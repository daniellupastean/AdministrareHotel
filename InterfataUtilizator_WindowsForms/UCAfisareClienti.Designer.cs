
namespace InterfataUtilizator_WindowsForms
{
    partial class UCAfisareClienti
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
            this.PnlAfisareClienti = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LsBxAfisareClienti = new System.Windows.Forms.ListBox();
            this.LblTitluAfisareClienti = new System.Windows.Forms.Label();
            this.PnlAfisareClienti.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAfisareClienti
            // 
            this.PnlAfisareClienti.BackColor = System.Drawing.Color.Transparent;
            this.PnlAfisareClienti.Controls.Add(this.panel1);
            this.PnlAfisareClienti.Controls.Add(this.LblTitluAfisareClienti);
            this.PnlAfisareClienti.Location = new System.Drawing.Point(0, 0);
            this.PnlAfisareClienti.Name = "PnlAfisareClienti";
            this.PnlAfisareClienti.Size = new System.Drawing.Size(824, 515);
            this.PnlAfisareClienti.TabIndex = 8;
            this.PnlAfisareClienti.VisibleChanged += new System.EventHandler(this.PnlAfisareClienti_VisibleChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.LsBxAfisareClienti);
            this.panel1.Location = new System.Drawing.Point(44, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 414);
            this.panel1.TabIndex = 25;
            // 
            // LsBxAfisareClienti
            // 
            this.LsBxAfisareClienti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsBxAfisareClienti.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsBxAfisareClienti.FormattingEnabled = true;
            this.LsBxAfisareClienti.ItemHeight = 16;
            this.LsBxAfisareClienti.Location = new System.Drawing.Point(11, 12);
            this.LsBxAfisareClienti.Name = "LsBxAfisareClienti";
            this.LsBxAfisareClienti.Size = new System.Drawing.Size(715, 384);
            this.LsBxAfisareClienti.TabIndex = 25;
            // 
            // LblTitluAfisareClienti
            // 
            this.LblTitluAfisareClienti.AutoSize = true;
            this.LblTitluAfisareClienti.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitluAfisareClienti.Location = new System.Drawing.Point(298, 32);
            this.LblTitluAfisareClienti.Name = "LblTitluAfisareClienti";
            this.LblTitluAfisareClienti.Size = new System.Drawing.Size(193, 33);
            this.LblTitluAfisareClienti.TabIndex = 23;
            this.LblTitluAfisareClienti.Text = "Afisare Clienti";
            // 
            // UCAfisareClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlAfisareClienti);
            this.Name = "UCAfisareClienti";
            this.Size = new System.Drawing.Size(824, 515);
            this.Load += new System.EventHandler(this.UCAfisareClienti_Load);
            this.PnlAfisareClienti.ResumeLayout(false);
            this.PnlAfisareClienti.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAfisareClienti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox LsBxAfisareClienti;
        private System.Windows.Forms.Label LblTitluAfisareClienti;
    }
}
