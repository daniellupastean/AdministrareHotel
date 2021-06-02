
namespace InterfataUtilizator_WindowsForms
{
    partial class UCModificareRezervare
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
            this.PnlModificareRezervare = new System.Windows.Forms.Panel();
            this.LblCautareAvertisment = new System.Windows.Forms.Label();
            this.TxtIDRezervare = new System.Windows.Forms.TextBox();
            this.LblIDRezervare = new System.Windows.Forms.Label();
            this.BtnCautaRezervare = new System.Windows.Forms.Button();
            this.PnlDateRezervare = new System.Windows.Forms.Panel();
            this.DtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.DtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.LblCheckOut = new System.Windows.Forms.Label();
            this.LblCheckIn = new System.Windows.Forms.Label();
            this.TxtIDCamera = new System.Windows.Forms.TextBox();
            this.LblIDCamera = new System.Windows.Forms.Label();
            this.TxtCNPClient = new System.Windows.Forms.TextBox();
            this.LblCNPClient = new System.Windows.Forms.Label();
            this.LblAvertisment = new System.Windows.Forms.Label();
            this.BtnModificaRezervare = new System.Windows.Forms.Button();
            this.LblTitluModificareRezervare = new System.Windows.Forms.Label();
            this.PnlModificareRezervare.SuspendLayout();
            this.PnlDateRezervare.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlModificareRezervare
            // 
            this.PnlModificareRezervare.BackColor = System.Drawing.Color.Transparent;
            this.PnlModificareRezervare.Controls.Add(this.LblCautareAvertisment);
            this.PnlModificareRezervare.Controls.Add(this.TxtIDRezervare);
            this.PnlModificareRezervare.Controls.Add(this.LblIDRezervare);
            this.PnlModificareRezervare.Controls.Add(this.BtnCautaRezervare);
            this.PnlModificareRezervare.Controls.Add(this.PnlDateRezervare);
            this.PnlModificareRezervare.Controls.Add(this.LblTitluModificareRezervare);
            this.PnlModificareRezervare.Location = new System.Drawing.Point(0, 0);
            this.PnlModificareRezervare.Name = "PnlModificareRezervare";
            this.PnlModificareRezervare.Size = new System.Drawing.Size(824, 515);
            this.PnlModificareRezervare.TabIndex = 6;
            // 
            // LblCautareAvertisment
            // 
            this.LblCautareAvertisment.AutoSize = true;
            this.LblCautareAvertisment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCautareAvertisment.ForeColor = System.Drawing.Color.Firebrick;
            this.LblCautareAvertisment.Location = new System.Drawing.Point(231, 131);
            this.LblCautareAvertisment.Name = "LblCautareAvertisment";
            this.LblCautareAvertisment.Size = new System.Drawing.Size(0, 17);
            this.LblCautareAvertisment.TabIndex = 28;
            // 
            // TxtIDRezervare
            // 
            this.TxtIDRezervare.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIDRezervare.Location = new System.Drawing.Point(301, 93);
            this.TxtIDRezervare.Name = "TxtIDRezervare";
            this.TxtIDRezervare.Size = new System.Drawing.Size(139, 26);
            this.TxtIDRezervare.TabIndex = 27;
            // 
            // LblIDRezervare
            // 
            this.LblIDRezervare.AutoSize = true;
            this.LblIDRezervare.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIDRezervare.ForeColor = System.Drawing.Color.White;
            this.LblIDRezervare.Location = new System.Drawing.Point(253, 93);
            this.LblIDRezervare.Name = "LblIDRezervare";
            this.LblIDRezervare.Size = new System.Drawing.Size(25, 20);
            this.LblIDRezervare.TabIndex = 26;
            this.LblIDRezervare.Text = "ID";
            // 
            // BtnCautaRezervare
            // 
            this.BtnCautaRezervare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(155)))), ((int)(((byte)(118)))));
            this.BtnCautaRezervare.FlatAppearance.BorderSize = 0;
            this.BtnCautaRezervare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCautaRezervare.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCautaRezervare.ForeColor = System.Drawing.Color.White;
            this.BtnCautaRezervare.Location = new System.Drawing.Point(464, 94);
            this.BtnCautaRezervare.Name = "BtnCautaRezervare";
            this.BtnCautaRezervare.Size = new System.Drawing.Size(74, 26);
            this.BtnCautaRezervare.TabIndex = 25;
            this.BtnCautaRezervare.Text = "Cauta";
            this.BtnCautaRezervare.UseVisualStyleBackColor = false;
            this.BtnCautaRezervare.Click += new System.EventHandler(this.BtnCautaRezervare_Click);
            // 
            // PnlDateRezervare
            // 
            this.PnlDateRezervare.Controls.Add(this.DtpCheckOut);
            this.PnlDateRezervare.Controls.Add(this.DtpCheckIn);
            this.PnlDateRezervare.Controls.Add(this.LblCheckOut);
            this.PnlDateRezervare.Controls.Add(this.LblCheckIn);
            this.PnlDateRezervare.Controls.Add(this.TxtIDCamera);
            this.PnlDateRezervare.Controls.Add(this.LblIDCamera);
            this.PnlDateRezervare.Controls.Add(this.TxtCNPClient);
            this.PnlDateRezervare.Controls.Add(this.LblCNPClient);
            this.PnlDateRezervare.Controls.Add(this.LblAvertisment);
            this.PnlDateRezervare.Controls.Add(this.BtnModificaRezervare);
            this.PnlDateRezervare.Location = new System.Drawing.Point(37, 139);
            this.PnlDateRezervare.Name = "PnlDateRezervare";
            this.PnlDateRezervare.Size = new System.Drawing.Size(748, 366);
            this.PnlDateRezervare.TabIndex = 24;
            this.PnlDateRezervare.Visible = false;
            // 
            // DtpCheckOut
            // 
            this.DtpCheckOut.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpCheckOut.Location = new System.Drawing.Point(332, 205);
            this.DtpCheckOut.Name = "DtpCheckOut";
            this.DtpCheckOut.Size = new System.Drawing.Size(200, 22);
            this.DtpCheckOut.TabIndex = 54;
            // 
            // DtpCheckIn
            // 
            this.DtpCheckIn.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpCheckIn.Location = new System.Drawing.Point(332, 159);
            this.DtpCheckIn.Name = "DtpCheckIn";
            this.DtpCheckIn.Size = new System.Drawing.Size(200, 22);
            this.DtpCheckIn.TabIndex = 53;
            // 
            // LblCheckOut
            // 
            this.LblCheckOut.AutoSize = true;
            this.LblCheckOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCheckOut.ForeColor = System.Drawing.Color.White;
            this.LblCheckOut.Location = new System.Drawing.Point(183, 207);
            this.LblCheckOut.Name = "LblCheckOut";
            this.LblCheckOut.Size = new System.Drawing.Size(117, 20);
            this.LblCheckOut.TabIndex = 52;
            this.LblCheckOut.Text = "Data Check-In";
            // 
            // LblCheckIn
            // 
            this.LblCheckIn.AutoSize = true;
            this.LblCheckIn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCheckIn.ForeColor = System.Drawing.Color.White;
            this.LblCheckIn.Location = new System.Drawing.Point(183, 160);
            this.LblCheckIn.Name = "LblCheckIn";
            this.LblCheckIn.Size = new System.Drawing.Size(130, 20);
            this.LblCheckIn.TabIndex = 51;
            this.LblCheckIn.Text = "Data Check-Out";
            // 
            // TxtIDCamera
            // 
            this.TxtIDCamera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIDCamera.Location = new System.Drawing.Point(332, 108);
            this.TxtIDCamera.Name = "TxtIDCamera";
            this.TxtIDCamera.Size = new System.Drawing.Size(200, 26);
            this.TxtIDCamera.TabIndex = 50;
            // 
            // LblIDCamera
            // 
            this.LblIDCamera.AutoSize = true;
            this.LblIDCamera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIDCamera.ForeColor = System.Drawing.Color.White;
            this.LblIDCamera.Location = new System.Drawing.Point(183, 108);
            this.LblIDCamera.Name = "LblIDCamera";
            this.LblIDCamera.Size = new System.Drawing.Size(89, 20);
            this.LblIDCamera.TabIndex = 49;
            this.LblIDCamera.Text = "ID Camera";
            // 
            // TxtCNPClient
            // 
            this.TxtCNPClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCNPClient.Location = new System.Drawing.Point(331, 59);
            this.TxtCNPClient.MaxLength = 13;
            this.TxtCNPClient.Name = "TxtCNPClient";
            this.TxtCNPClient.Size = new System.Drawing.Size(201, 26);
            this.TxtCNPClient.TabIndex = 48;
            // 
            // LblCNPClient
            // 
            this.LblCNPClient.AutoSize = true;
            this.LblCNPClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCNPClient.ForeColor = System.Drawing.Color.White;
            this.LblCNPClient.Location = new System.Drawing.Point(183, 60);
            this.LblCNPClient.Name = "LblCNPClient";
            this.LblCNPClient.Size = new System.Drawing.Size(87, 20);
            this.LblCNPClient.TabIndex = 47;
            this.LblCNPClient.Text = "CNP Client";
            // 
            // LblAvertisment
            // 
            this.LblAvertisment.AutoSize = true;
            this.LblAvertisment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAvertisment.ForeColor = System.Drawing.Color.Firebrick;
            this.LblAvertisment.Location = new System.Drawing.Point(185, 263);
            this.LblAvertisment.Name = "LblAvertisment";
            this.LblAvertisment.Size = new System.Drawing.Size(0, 17);
            this.LblAvertisment.TabIndex = 46;
            // 
            // BtnModificaRezervare
            // 
            this.BtnModificaRezervare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(155)))), ((int)(((byte)(118)))));
            this.BtnModificaRezervare.FlatAppearance.BorderSize = 0;
            this.BtnModificaRezervare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificaRezervare.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificaRezervare.ForeColor = System.Drawing.Color.White;
            this.BtnModificaRezervare.Location = new System.Drawing.Point(306, 313);
            this.BtnModificaRezervare.Name = "BtnModificaRezervare";
            this.BtnModificaRezervare.Size = new System.Drawing.Size(94, 34);
            this.BtnModificaRezervare.TabIndex = 45;
            this.BtnModificaRezervare.Text = "Modifica";
            this.BtnModificaRezervare.UseVisualStyleBackColor = false;
            this.BtnModificaRezervare.Click += new System.EventHandler(this.BtnModificaRezervare_Click);
            // 
            // LblTitluModificareRezervare
            // 
            this.LblTitluModificareRezervare.AutoSize = true;
            this.LblTitluModificareRezervare.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitluModificareRezervare.ForeColor = System.Drawing.Color.White;
            this.LblTitluModificareRezervare.Location = new System.Drawing.Point(263, 32);
            this.LblTitluModificareRezervare.Name = "LblTitluModificareRezervare";
            this.LblTitluModificareRezervare.Size = new System.Drawing.Size(293, 32);
            this.LblTitluModificareRezervare.TabIndex = 23;
            this.LblTitluModificareRezervare.Text = "Modificare Rezervare";
            // 
            // UCModificareRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.PnlModificareRezervare);
            this.Name = "UCModificareRezervare";
            this.Size = new System.Drawing.Size(824, 515);
            this.Load += new System.EventHandler(this.UCModificareRezervare_Load);
            this.PnlModificareRezervare.ResumeLayout(false);
            this.PnlModificareRezervare.PerformLayout();
            this.PnlDateRezervare.ResumeLayout(false);
            this.PnlDateRezervare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlModificareRezervare;
        private System.Windows.Forms.Label LblCautareAvertisment;
        private System.Windows.Forms.TextBox TxtIDRezervare;
        private System.Windows.Forms.Label LblIDRezervare;
        private System.Windows.Forms.Button BtnCautaRezervare;
        private System.Windows.Forms.Panel PnlDateRezervare;
        private System.Windows.Forms.Label LblAvertisment;
        private System.Windows.Forms.Button BtnModificaRezervare;
        private System.Windows.Forms.Label LblTitluModificareRezervare;
        private System.Windows.Forms.DateTimePicker DtpCheckOut;
        private System.Windows.Forms.DateTimePicker DtpCheckIn;
        private System.Windows.Forms.Label LblCheckOut;
        private System.Windows.Forms.Label LblCheckIn;
        private System.Windows.Forms.TextBox TxtIDCamera;
        private System.Windows.Forms.Label LblIDCamera;
        private System.Windows.Forms.TextBox TxtCNPClient;
        private System.Windows.Forms.Label LblCNPClient;
    }
}
