﻿
namespace University_Management_System
{
    partial class Login
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
            this.aloginbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aname = new System.Windows.Forms.TextBox();
            this.apass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.loginas = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FPassbtn = new System.Windows.Forms.Button();
            this.showpass = new System.Windows.Forms.Button();
            this.hidepass = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aloginbtn
            // 
            this.aloginbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aloginbtn.BackColor = System.Drawing.Color.Transparent;
            this.aloginbtn.FlatAppearance.BorderSize = 0;
            this.aloginbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.aloginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aloginbtn.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aloginbtn.ForeColor = System.Drawing.Color.White;
            this.aloginbtn.Location = new System.Drawing.Point(345, 214);
            this.aloginbtn.Name = "aloginbtn";
            this.aloginbtn.Size = new System.Drawing.Size(99, 45);
            this.aloginbtn.TabIndex = 0;
            this.aloginbtn.Text = "Login";
            this.aloginbtn.UseVisualStyleBackColor = false;
            this.aloginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password  :";
            // 
            // aname
            // 
            this.aname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.aname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aname.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aname.ForeColor = System.Drawing.Color.White;
            this.aname.Location = new System.Drawing.Point(166, 62);
            this.aname.Name = "aname";
            this.aname.Size = new System.Drawing.Size(275, 24);
            this.aname.TabIndex = 3;
            this.aname.Tag = "";
            // 
            // apass
            // 
            this.apass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.apass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apass.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apass.ForeColor = System.Drawing.Color.White;
            this.apass.Location = new System.Drawing.Point(166, 112);
            this.apass.Name = "apass";
            this.apass.Size = new System.Drawing.Size(275, 24);
            this.apass.TabIndex = 4;
            this.apass.TextChanged += new System.EventHandler(this.apass_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.FPassbtn);
            this.panel1.Controls.Add(this.showpass);
            this.panel1.Controls.Add(this.hidepass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.loginas);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.aname);
            this.panel1.Controls.Add(this.apass);
            this.panel1.Controls.Add(this.aloginbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(394, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 271);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(238, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Login As";
            // 
            // loginas
            // 
            this.loginas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.loginas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loginas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginas.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginas.ForeColor = System.Drawing.SystemColors.Window;
            this.loginas.FormattingEnabled = true;
            this.loginas.Items.AddRange(new object[] {
            "Admin",
            "Teacher",
            "Student"});
            this.loginas.Location = new System.Drawing.Point(320, 169);
            this.loginas.Name = "loginas";
            this.loginas.Size = new System.Drawing.Size(121, 24);
            this.loginas.TabIndex = 7;
            this.loginas.SelectedIndexChanged += new System.EventHandler(this.loginas_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(54, 91);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(390, 4);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(54, 141);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(390, 4);
            this.panel3.TabIndex = 6;
            // 
            // FPassbtn
            // 
            this.FPassbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FPassbtn.FlatAppearance.BorderSize = 0;
            this.FPassbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.FPassbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FPassbtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPassbtn.ForeColor = System.Drawing.Color.White;
            this.FPassbtn.Location = new System.Drawing.Point(55, 214);
            this.FPassbtn.Name = "FPassbtn";
            this.FPassbtn.Size = new System.Drawing.Size(149, 28);
            this.FPassbtn.TabIndex = 13;
            this.FPassbtn.Text = "Forgot Password ?";
            this.FPassbtn.UseVisualStyleBackColor = true;
            this.FPassbtn.Click += new System.EventHandler(this.FPassbtn_Click);
            // 
            // showpass
            // 
            this.showpass.FlatAppearance.BorderSize = 0;
            this.showpass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.showpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showpass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showpass.Image = global::University_Management_System.Properties.Resources.show_password_icon_19;
            this.showpass.Location = new System.Drawing.Point(391, 98);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(53, 40);
            this.showpass.TabIndex = 10;
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.Click += new System.EventHandler(this.showpass_Click);
            // 
            // hidepass
            // 
            this.hidepass.FlatAppearance.BorderSize = 0;
            this.hidepass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.hidepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidepass.Image = global::University_Management_System.Properties.Resources.show_password_icon_182;
            this.hidepass.Location = new System.Drawing.Point(391, 98);
            this.hidepass.Name = "hidepass";
            this.hidepass.Size = new System.Drawing.Size(53, 40);
            this.hidepass.TabIndex = 9;
            this.hidepass.UseVisualStyleBackColor = true;
            this.hidepass.Click += new System.EventHandler(this.hidepass_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1284, 547);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1278, 586);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aloginbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aname;
        private System.Windows.Forms.TextBox apass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox loginas;
        private System.Windows.Forms.Button hidepass;
        public System.Windows.Forms.Button showpass;
        private System.Windows.Forms.Button FPassbtn;
    }
}