
namespace InterfataUtilizator_WindowsForms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Navbar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MesajParola = new System.Windows.Forms.Label();
            this.PanelCamere = new System.Windows.Forms.Panel();
            this.InfoSetari = new System.Windows.Forms.ToolTip(this.components);
            this.ButonModificareCamera = new System.Windows.Forms.Button();
            this.ButonCautareCamera = new System.Windows.Forms.Button();
            this.ButonAfisareCamere = new System.Windows.Forms.Button();
            this.ButonAdaugareCamera = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.PnlAddCamera = new System.Windows.Forms.Panel();
            this.BtnAdaugaCamera = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Navbar.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.AuthPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.PanelCamere.SuspendLayout();
            this.PnlAddCamera.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(435, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daniel Lupaștean © 2021";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 634);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 34);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1042, 34);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(859, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Daniel Lupastean © 2021";
            // 
            // Navbar
            // 
            this.Navbar.BackColor = System.Drawing.Color.Silver;
            this.Navbar.Controls.Add(this.btnExit);
            this.Navbar.Controls.Add(this.label3);
            this.Navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Navbar.Location = new System.Drawing.Point(0, 0);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(1042, 47);
            this.Navbar.TabIndex = 3;
            this.Navbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Navbar_MouseDown);
            this.Navbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Navbar_MouseMove);
            this.Navbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Navbar_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hotel";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.MainPanel.Controls.Add(this.PanelCamere);
            this.MainPanel.Controls.Add(this.button5);
            this.MainPanel.Controls.Add(this.button4);
            this.MainPanel.Controls.Add(this.button3);
            this.MainPanel.Controls.Add(this.button2);
            this.MainPanel.Controls.Add(this.button1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPanel.Location = new System.Drawing.Point(0, 47);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1042, 587);
            this.MainPanel.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "Angajati";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Clienti";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Rezervari";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Camere";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AuthPanel
            // 
            this.AuthPanel.AutoSize = true;
            this.AuthPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.AuthPanel.Controls.Add(this.MesajParola);
            this.AuthPanel.Controls.Add(this.panel5);
            this.AuthPanel.Controls.Add(this.label4);
            this.AuthPanel.Location = new System.Drawing.Point(0, 47);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(1042, 587);
            this.AuthPanel.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(9, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parola";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Location = new System.Drawing.Point(408, 275);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(206, 37);
            this.panel5.TabIndex = 2;
            // 
            // MesajParola
            // 
            this.MesajParola.AutoSize = true;
            this.MesajParola.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesajParola.ForeColor = System.Drawing.Color.Firebrick;
            this.MesajParola.Location = new System.Drawing.Point(444, 320);
            this.MesajParola.Name = "MesajParola";
            this.MesajParola.Size = new System.Drawing.Size(0, 17);
            this.MesajParola.TabIndex = 3;
            // 
            // PanelCamere
            // 
            this.PanelCamere.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelCamere.Controls.Add(this.PnlAddCamera);
            this.PanelCamere.Controls.Add(this.ButonModificareCamera);
            this.PanelCamere.Controls.Add(this.ButonCautareCamera);
            this.PanelCamere.Controls.Add(this.ButonAfisareCamere);
            this.PanelCamere.Controls.Add(this.ButonAdaugareCamera);
            this.PanelCamere.Location = new System.Drawing.Point(160, 0);
            this.PanelCamere.Name = "PanelCamere";
            this.PanelCamere.Size = new System.Drawing.Size(881, 586);
            this.PanelCamere.TabIndex = 5;
            // 
            // ButonModificareCamera
            // 
            this.ButonModificareCamera.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButonModificareCamera.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.edit_icon;
            this.ButonModificareCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButonModificareCamera.FlatAppearance.BorderSize = 0;
            this.ButonModificareCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonModificareCamera.Location = new System.Drawing.Point(488, 0);
            this.ButonModificareCamera.Name = "ButonModificareCamera";
            this.ButonModificareCamera.Size = new System.Drawing.Size(44, 43);
            this.ButonModificareCamera.TabIndex = 3;
            this.ButonModificareCamera.UseVisualStyleBackColor = false;
            // 
            // ButonCautareCamera
            // 
            this.ButonCautareCamera.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButonCautareCamera.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.search_icon1;
            this.ButonCautareCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButonCautareCamera.FlatAppearance.BorderSize = 0;
            this.ButonCautareCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonCautareCamera.Location = new System.Drawing.Point(438, 0);
            this.ButonCautareCamera.Name = "ButonCautareCamera";
            this.ButonCautareCamera.Size = new System.Drawing.Size(44, 43);
            this.ButonCautareCamera.TabIndex = 2;
            this.ButonCautareCamera.UseVisualStyleBackColor = false;
            // 
            // ButonAfisareCamere
            // 
            this.ButonAfisareCamere.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButonAfisareCamere.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.show_icon1;
            this.ButonAfisareCamere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButonAfisareCamere.FlatAppearance.BorderSize = 0;
            this.ButonAfisareCamere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonAfisareCamere.Location = new System.Drawing.Point(388, 0);
            this.ButonAfisareCamere.Name = "ButonAfisareCamere";
            this.ButonAfisareCamere.Size = new System.Drawing.Size(44, 43);
            this.ButonAfisareCamere.TabIndex = 1;
            this.ButonAfisareCamere.UseVisualStyleBackColor = false;
            // 
            // ButonAdaugareCamera
            // 
            this.ButonAdaugareCamera.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButonAdaugareCamera.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.plus_icon1;
            this.ButonAdaugareCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButonAdaugareCamera.FlatAppearance.BorderSize = 0;
            this.ButonAdaugareCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonAdaugareCamera.Location = new System.Drawing.Point(338, 0);
            this.ButonAdaugareCamera.Name = "ButonAdaugareCamera";
            this.ButonAdaugareCamera.Size = new System.Drawing.Size(44, 43);
            this.ButonAdaugareCamera.TabIndex = 0;
            this.ButonAdaugareCamera.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.settings_icon1;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(68, 535);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 30);
            this.button5.TabIndex = 4;
            this.InfoSetari.SetToolTip(this.button5, "Setari");
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources._4177409791543238955_128;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1004, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PnlAddCamera
            // 
            this.PnlAddCamera.Controls.Add(this.BtnAdaugaCamera);
            this.PnlAddCamera.Location = new System.Drawing.Point(29, 50);
            this.PnlAddCamera.Name = "PnlAddCamera";
            this.PnlAddCamera.Size = new System.Drawing.Size(824, 514);
            this.PnlAddCamera.TabIndex = 4;
            // 
            // BtnAdaugaCamera
            // 
            this.BtnAdaugaCamera.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnAdaugaCamera.FlatAppearance.BorderSize = 0;
            this.BtnAdaugaCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdaugaCamera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdaugaCamera.Location = new System.Drawing.Point(359, 467);
            this.BtnAdaugaCamera.Name = "BtnAdaugaCamera";
            this.BtnAdaugaCamera.Size = new System.Drawing.Size(94, 34);
            this.BtnAdaugaCamera.TabIndex = 0;
            this.BtnAdaugaCamera.Text = "Adauga";
            this.BtnAdaugaCamera.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1042, 668);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Navbar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AuthPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Opacity = 0.99D;
            this.Text = "Administrare Hotel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Navbar.ResumeLayout(false);
            this.Navbar.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.PanelCamere.ResumeLayout(false);
            this.PnlAddCamera.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Navbar;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label MesajParola;
        private System.Windows.Forms.Panel PanelCamere;
        private System.Windows.Forms.ToolTip InfoSetari;
        private System.Windows.Forms.Button ButonAdaugareCamera;
        private System.Windows.Forms.Button ButonModificareCamera;
        private System.Windows.Forms.Button ButonCautareCamera;
        private System.Windows.Forms.Button ButonAfisareCamere;
        private System.Windows.Forms.Panel PnlAddCamera;
        private System.Windows.Forms.Button BtnAdaugaCamera;
    }
}

