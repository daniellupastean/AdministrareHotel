
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
            this.BtnStergeClient = new System.Windows.Forms.Button();
            this.PnlAfisareClienti.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAfisareClienti
            // 
            this.PnlAfisareClienti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.BtnStergeClient);
            this.panel1.Controls.Add(this.LsBxAfisareClienti);
            this.panel1.Location = new System.Drawing.Point(44, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 414);
            this.panel1.TabIndex = 25;
            // 
            // LsBxAfisareClienti
            // 
            this.LsBxAfisareClienti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.LsBxAfisareClienti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsBxAfisareClienti.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsBxAfisareClienti.ForeColor = System.Drawing.Color.White;
            this.LsBxAfisareClienti.FormattingEnabled = true;
            this.LsBxAfisareClienti.ItemHeight = 16;
            this.LsBxAfisareClienti.Location = new System.Drawing.Point(11, 12);
            this.LsBxAfisareClienti.Name = "LsBxAfisareClienti";
            this.LsBxAfisareClienti.Size = new System.Drawing.Size(715, 336);
            this.LsBxAfisareClienti.TabIndex = 25;
            this.LsBxAfisareClienti.SelectedIndexChanged += new System.EventHandler(this.LsBxAfisareClienti_SelectedIndexChanged);
            // 
            // LblTitluAfisareClienti
            // 
            this.LblTitluAfisareClienti.AutoSize = true;
            this.LblTitluAfisareClienti.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitluAfisareClienti.ForeColor = System.Drawing.Color.White;
            this.LblTitluAfisareClienti.Location = new System.Drawing.Point(298, 32);
            this.LblTitluAfisareClienti.Name = "LblTitluAfisareClienti";
            this.LblTitluAfisareClienti.Size = new System.Drawing.Size(193, 32);
            this.LblTitluAfisareClienti.TabIndex = 23;
            this.LblTitluAfisareClienti.Text = "Afisare Clienti";
            // 
            // BtnStergeClient
            // 
            this.BtnStergeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(155)))), ((int)(((byte)(118)))));
            this.BtnStergeClient.FlatAppearance.BorderSize = 0;
            this.BtnStergeClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStergeClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStergeClient.ForeColor = System.Drawing.Color.White;
            this.BtnStergeClient.Location = new System.Drawing.Point(320, 364);
            this.BtnStergeClient.Name = "BtnStergeClient";
            this.BtnStergeClient.Size = new System.Drawing.Size(94, 34);
            this.BtnStergeClient.TabIndex = 27;
            this.BtnStergeClient.Text = "Sterge";
            this.BtnStergeClient.UseVisualStyleBackColor = false;
            this.BtnStergeClient.Click += new System.EventHandler(this.BtnStergeClient_Click);
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
        private System.Windows.Forms.Label LblTitluAfisareClienti;
        private System.Windows.Forms.ListBox LsBxAfisareClienti;
        private System.Windows.Forms.Button BtnStergeClient;
    }
}
