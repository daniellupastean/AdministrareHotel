
namespace InterfataUtilizator_WindowsForms
{
    partial class UCAdaugareAngajat
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
            this.PnlAddCamera = new System.Windows.Forms.Panel();
            this.cbxFunctieAngajat = new System.Windows.Forms.ComboBox();
            this.LblAdaugareAngajatAvertisment = new System.Windows.Forms.Label();
            this.LblTitluAdaugareAngajat = new System.Windows.Forms.Label();
            this.LblFunctieAngajat = new System.Windows.Forms.Label();
            this.TxtSalariuAngajat = new System.Windows.Forms.TextBox();
            this.LblSalariuAngajat = new System.Windows.Forms.Label();
            this.TxtCNPAngajat = new System.Windows.Forms.TextBox();
            this.LblCNPAngajat = new System.Windows.Forms.Label();
            this.TxtPrenumeAngajat = new System.Windows.Forms.TextBox();
            this.LblPrenumeAngajat = new System.Windows.Forms.Label();
            this.TxtNumeAngajat = new System.Windows.Forms.TextBox();
            this.LblNumeAngajat = new System.Windows.Forms.Label();
            this.BtnAdaugaAngajat = new System.Windows.Forms.Button();
            this.PnlAddCamera.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAddCamera
            // 
            this.PnlAddCamera.BackColor = System.Drawing.Color.Transparent;
            this.PnlAddCamera.Controls.Add(this.cbxFunctieAngajat);
            this.PnlAddCamera.Controls.Add(this.LblAdaugareAngajatAvertisment);
            this.PnlAddCamera.Controls.Add(this.LblTitluAdaugareAngajat);
            this.PnlAddCamera.Controls.Add(this.LblFunctieAngajat);
            this.PnlAddCamera.Controls.Add(this.TxtSalariuAngajat);
            this.PnlAddCamera.Controls.Add(this.LblSalariuAngajat);
            this.PnlAddCamera.Controls.Add(this.TxtCNPAngajat);
            this.PnlAddCamera.Controls.Add(this.LblCNPAngajat);
            this.PnlAddCamera.Controls.Add(this.TxtPrenumeAngajat);
            this.PnlAddCamera.Controls.Add(this.LblPrenumeAngajat);
            this.PnlAddCamera.Controls.Add(this.TxtNumeAngajat);
            this.PnlAddCamera.Controls.Add(this.LblNumeAngajat);
            this.PnlAddCamera.Controls.Add(this.BtnAdaugaAngajat);
            this.PnlAddCamera.Location = new System.Drawing.Point(0, 0);
            this.PnlAddCamera.Name = "PnlAddCamera";
            this.PnlAddCamera.Size = new System.Drawing.Size(824, 515);
            this.PnlAddCamera.TabIndex = 6;
            this.PnlAddCamera.VisibleChanged += new System.EventHandler(this.PnlAddCamera_VisibleChanged);
            // 
            // cbxFunctieAngajat
            // 
            this.cbxFunctieAngajat.BackColor = System.Drawing.SystemColors.Window;
            this.cbxFunctieAngajat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFunctieAngajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFunctieAngajat.FormattingEnabled = true;
            this.cbxFunctieAngajat.Items.AddRange(new object[] {
            "Administrator",
            "Contabil",
            "Receptioner",
            "Curatenie"});
            this.cbxFunctieAngajat.Location = new System.Drawing.Point(355, 287);
            this.cbxFunctieAngajat.Name = "cbxFunctieAngajat";
            this.cbxFunctieAngajat.Size = new System.Drawing.Size(234, 28);
            this.cbxFunctieAngajat.TabIndex = 25;
            // 
            // LblAdaugareAngajatAvertisment
            // 
            this.LblAdaugareAngajatAvertisment.AutoSize = true;
            this.LblAdaugareAngajatAvertisment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdaugareAngajatAvertisment.ForeColor = System.Drawing.Color.Firebrick;
            this.LblAdaugareAngajatAvertisment.Location = new System.Drawing.Point(286, 390);
            this.LblAdaugareAngajatAvertisment.Name = "LblAdaugareAngajatAvertisment";
            this.LblAdaugareAngajatAvertisment.Size = new System.Drawing.Size(0, 17);
            this.LblAdaugareAngajatAvertisment.TabIndex = 24;
            // 
            // LblTitluAdaugareAngajat
            // 
            this.LblTitluAdaugareAngajat.AutoSize = true;
            this.LblTitluAdaugareAngajat.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitluAdaugareAngajat.ForeColor = System.Drawing.Color.White;
            this.LblTitluAdaugareAngajat.Location = new System.Drawing.Point(270, 46);
            this.LblTitluAdaugareAngajat.Name = "LblTitluAdaugareAngajat";
            this.LblTitluAdaugareAngajat.Size = new System.Drawing.Size(262, 32);
            this.LblTitluAdaugareAngajat.TabIndex = 23;
            this.LblTitluAdaugareAngajat.Text = "Adaugare Angajat";
            // 
            // LblFunctieAngajat
            // 
            this.LblFunctieAngajat.AutoSize = true;
            this.LblFunctieAngajat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFunctieAngajat.ForeColor = System.Drawing.Color.White;
            this.LblFunctieAngajat.Location = new System.Drawing.Point(196, 288);
            this.LblFunctieAngajat.Name = "LblFunctieAngajat";
            this.LblFunctieAngajat.Size = new System.Drawing.Size(62, 20);
            this.LblFunctieAngajat.TabIndex = 16;
            this.LblFunctieAngajat.Text = "Functie";
            // 
            // TxtSalariuAngajat
            // 
            this.TxtSalariuAngajat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalariuAngajat.Location = new System.Drawing.Point(353, 331);
            this.TxtSalariuAngajat.Name = "TxtSalariuAngajat";
            this.TxtSalariuAngajat.Size = new System.Drawing.Size(236, 26);
            this.TxtSalariuAngajat.TabIndex = 15;
            // 
            // LblSalariuAngajat
            // 
            this.LblSalariuAngajat.AutoSize = true;
            this.LblSalariuAngajat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalariuAngajat.ForeColor = System.Drawing.Color.White;
            this.LblSalariuAngajat.Location = new System.Drawing.Point(193, 331);
            this.LblSalariuAngajat.Name = "LblSalariuAngajat";
            this.LblSalariuAngajat.Size = new System.Drawing.Size(86, 20);
            this.LblSalariuAngajat.TabIndex = 14;
            this.LblSalariuAngajat.Text = "Salariu (lei)";
            // 
            // TxtCNPAngajat
            // 
            this.TxtCNPAngajat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCNPAngajat.Location = new System.Drawing.Point(355, 242);
            this.TxtCNPAngajat.MaxLength = 13;
            this.TxtCNPAngajat.Name = "TxtCNPAngajat";
            this.TxtCNPAngajat.Size = new System.Drawing.Size(236, 26);
            this.TxtCNPAngajat.TabIndex = 6;
            // 
            // LblCNPAngajat
            // 
            this.LblCNPAngajat.AutoSize = true;
            this.LblCNPAngajat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCNPAngajat.ForeColor = System.Drawing.Color.White;
            this.LblCNPAngajat.Location = new System.Drawing.Point(195, 242);
            this.LblCNPAngajat.Name = "LblCNPAngajat";
            this.LblCNPAngajat.Size = new System.Drawing.Size(41, 20);
            this.LblCNPAngajat.TabIndex = 5;
            this.LblCNPAngajat.Text = "CNP";
            // 
            // TxtPrenumeAngajat
            // 
            this.TxtPrenumeAngajat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrenumeAngajat.Location = new System.Drawing.Point(355, 196);
            this.TxtPrenumeAngajat.Name = "TxtPrenumeAngajat";
            this.TxtPrenumeAngajat.Size = new System.Drawing.Size(236, 26);
            this.TxtPrenumeAngajat.TabIndex = 4;
            // 
            // LblPrenumeAngajat
            // 
            this.LblPrenumeAngajat.AutoSize = true;
            this.LblPrenumeAngajat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrenumeAngajat.ForeColor = System.Drawing.Color.White;
            this.LblPrenumeAngajat.Location = new System.Drawing.Point(195, 196);
            this.LblPrenumeAngajat.Name = "LblPrenumeAngajat";
            this.LblPrenumeAngajat.Size = new System.Drawing.Size(74, 20);
            this.LblPrenumeAngajat.TabIndex = 3;
            this.LblPrenumeAngajat.Text = "Prenume";
            // 
            // TxtNumeAngajat
            // 
            this.TxtNumeAngajat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeAngajat.Location = new System.Drawing.Point(354, 150);
            this.TxtNumeAngajat.Name = "TxtNumeAngajat";
            this.TxtNumeAngajat.Size = new System.Drawing.Size(236, 26);
            this.TxtNumeAngajat.TabIndex = 2;
            // 
            // LblNumeAngajat
            // 
            this.LblNumeAngajat.AutoSize = true;
            this.LblNumeAngajat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeAngajat.ForeColor = System.Drawing.Color.White;
            this.LblNumeAngajat.Location = new System.Drawing.Point(195, 151);
            this.LblNumeAngajat.Name = "LblNumeAngajat";
            this.LblNumeAngajat.Size = new System.Drawing.Size(52, 20);
            this.LblNumeAngajat.TabIndex = 1;
            this.LblNumeAngajat.Text = "Nume";
            // 
            // BtnAdaugaAngajat
            // 
            this.BtnAdaugaAngajat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(155)))), ((int)(((byte)(118)))));
            this.BtnAdaugaAngajat.FlatAppearance.BorderSize = 0;
            this.BtnAdaugaAngajat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdaugaAngajat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdaugaAngajat.ForeColor = System.Drawing.Color.White;
            this.BtnAdaugaAngajat.Location = new System.Drawing.Point(359, 437);
            this.BtnAdaugaAngajat.Name = "BtnAdaugaAngajat";
            this.BtnAdaugaAngajat.Size = new System.Drawing.Size(94, 34);
            this.BtnAdaugaAngajat.TabIndex = 0;
            this.BtnAdaugaAngajat.Text = "Adauga";
            this.BtnAdaugaAngajat.UseVisualStyleBackColor = false;
            this.BtnAdaugaAngajat.Click += new System.EventHandler(this.BtnAdaugaAngajat_Click);
            // 
            // UCAdaugareAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.PnlAddCamera);
            this.Name = "UCAdaugareAngajat";
            this.Size = new System.Drawing.Size(824, 515);
            this.Load += new System.EventHandler(this.UCAdaugareAngajat_Load);
            this.PnlAddCamera.ResumeLayout(false);
            this.PnlAddCamera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAddCamera;
        private System.Windows.Forms.Label LblAdaugareAngajatAvertisment;
        private System.Windows.Forms.Label LblTitluAdaugareAngajat;
        private System.Windows.Forms.Label LblFunctieAngajat;
        private System.Windows.Forms.TextBox TxtSalariuAngajat;
        private System.Windows.Forms.Label LblSalariuAngajat;
        private System.Windows.Forms.TextBox TxtCNPAngajat;
        private System.Windows.Forms.Label LblCNPAngajat;
        private System.Windows.Forms.TextBox TxtPrenumeAngajat;
        private System.Windows.Forms.Label LblPrenumeAngajat;
        private System.Windows.Forms.TextBox TxtNumeAngajat;
        private System.Windows.Forms.Label LblNumeAngajat;
        private System.Windows.Forms.Button BtnAdaugaAngajat;
        private System.Windows.Forms.ComboBox cbxFunctieAngajat;
    }
}
