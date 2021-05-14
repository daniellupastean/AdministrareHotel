
namespace InterfataUtilizator_WindowsForms
{
    partial class UCCautareClient
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
            this.PnlCautareClient = new System.Windows.Forms.Panel();
            this.PnlAfisareClientCautat = new System.Windows.Forms.Panel();
            this.LblCameraCautata = new System.Windows.Forms.Label();
            this.LblHeaderInfo = new System.Windows.Forms.Label();
            this.LblCautareAvertisment = new System.Windows.Forms.Label();
            this.LblTitluCautareClient = new System.Windows.Forms.Label();
            this.TxtIDCamera = new System.Windows.Forms.TextBox();
            this.LblIDClient = new System.Windows.Forms.Label();
            this.BtnCautaClient = new System.Windows.Forms.Button();
            this.PnlCautareClient.SuspendLayout();
            this.PnlAfisareClientCautat.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlCautareClient
            // 
            this.PnlCautareClient.BackColor = System.Drawing.Color.Transparent;
            this.PnlCautareClient.Controls.Add(this.PnlAfisareClientCautat);
            this.PnlCautareClient.Controls.Add(this.LblCautareAvertisment);
            this.PnlCautareClient.Controls.Add(this.LblTitluCautareClient);
            this.PnlCautareClient.Controls.Add(this.TxtIDCamera);
            this.PnlCautareClient.Controls.Add(this.LblIDClient);
            this.PnlCautareClient.Controls.Add(this.BtnCautaClient);
            this.PnlCautareClient.Location = new System.Drawing.Point(0, 0);
            this.PnlCautareClient.Name = "PnlCautareClient";
            this.PnlCautareClient.Size = new System.Drawing.Size(824, 515);
            this.PnlCautareClient.TabIndex = 7;
            // 
            // PnlAfisareClientCautat
            // 
            this.PnlAfisareClientCautat.BackColor = System.Drawing.Color.White;
            this.PnlAfisareClientCautat.Controls.Add(this.LblCameraCautata);
            this.PnlAfisareClientCautat.Controls.Add(this.LblHeaderInfo);
            this.PnlAfisareClientCautat.Location = new System.Drawing.Point(44, 261);
            this.PnlAfisareClientCautat.Name = "PnlAfisareClientCautat";
            this.PnlAfisareClientCautat.Size = new System.Drawing.Size(726, 92);
            this.PnlAfisareClientCautat.TabIndex = 25;
            this.PnlAfisareClientCautat.Visible = false;
            // 
            // LblCameraCautata
            // 
            this.LblCameraCautata.AutoSize = true;
            this.LblCameraCautata.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCameraCautata.Location = new System.Drawing.Point(10, 50);
            this.LblCameraCautata.Name = "LblCameraCautata";
            this.LblCameraCautata.Size = new System.Drawing.Size(0, 16);
            this.LblCameraCautata.TabIndex = 1;
            // 
            // LblHeaderInfo
            // 
            this.LblHeaderInfo.AutoSize = true;
            this.LblHeaderInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.LblHeaderInfo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderInfo.Location = new System.Drawing.Point(10, 14);
            this.LblHeaderInfo.Name = "LblHeaderInfo";
            this.LblHeaderInfo.Size = new System.Drawing.Size(0, 16);
            this.LblHeaderInfo.TabIndex = 0;
            // 
            // LblCautareAvertisment
            // 
            this.LblCautareAvertisment.AutoSize = true;
            this.LblCautareAvertisment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCautareAvertisment.ForeColor = System.Drawing.Color.Firebrick;
            this.LblCautareAvertisment.Location = new System.Drawing.Point(236, 220);
            this.LblCautareAvertisment.Name = "LblCautareAvertisment";
            this.LblCautareAvertisment.Size = new System.Drawing.Size(0, 20);
            this.LblCautareAvertisment.TabIndex = 24;
            // 
            // LblTitluCautareClient
            // 
            this.LblTitluCautareClient.AutoSize = true;
            this.LblTitluCautareClient.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitluCautareClient.Location = new System.Drawing.Point(283, 34);
            this.LblTitluCautareClient.Name = "LblTitluCautareClient";
            this.LblTitluCautareClient.Size = new System.Drawing.Size(210, 33);
            this.LblTitluCautareClient.TabIndex = 23;
            this.LblTitluCautareClient.Text = "Cautare Client";
            // 
            // TxtIDCamera
            // 
            this.TxtIDCamera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIDCamera.Location = new System.Drawing.Point(305, 170);
            this.TxtIDCamera.Name = "TxtIDCamera";
            this.TxtIDCamera.Size = new System.Drawing.Size(139, 26);
            this.TxtIDCamera.TabIndex = 2;
            // 
            // LblIDClient
            // 
            this.LblIDClient.AutoSize = true;
            this.LblIDClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIDClient.Location = new System.Drawing.Point(257, 170);
            this.LblIDClient.Name = "LblIDClient";
            this.LblIDClient.Size = new System.Drawing.Size(25, 20);
            this.LblIDClient.TabIndex = 1;
            this.LblIDClient.Text = "ID";
            // 
            // BtnCautaClient
            // 
            this.BtnCautaClient.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnCautaClient.FlatAppearance.BorderSize = 0;
            this.BtnCautaClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCautaClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCautaClient.Location = new System.Drawing.Point(468, 171);
            this.BtnCautaClient.Name = "BtnCautaClient";
            this.BtnCautaClient.Size = new System.Drawing.Size(74, 26);
            this.BtnCautaClient.TabIndex = 0;
            this.BtnCautaClient.Text = "Cauta";
            this.BtnCautaClient.UseVisualStyleBackColor = false;
            // 
            // UCCautareClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlCautareClient);
            this.Name = "UCCautareClient";
            this.Size = new System.Drawing.Size(824, 515);
            this.PnlCautareClient.ResumeLayout(false);
            this.PnlCautareClient.PerformLayout();
            this.PnlAfisareClientCautat.ResumeLayout(false);
            this.PnlAfisareClientCautat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlCautareClient;
        private System.Windows.Forms.Panel PnlAfisareClientCautat;
        private System.Windows.Forms.Label LblCameraCautata;
        private System.Windows.Forms.Label LblHeaderInfo;
        private System.Windows.Forms.Label LblCautareAvertisment;
        private System.Windows.Forms.Label LblTitluCautareClient;
        private System.Windows.Forms.TextBox TxtIDCamera;
        private System.Windows.Forms.Label LblIDClient;
        private System.Windows.Forms.Button BtnCautaClient;
    }
}
