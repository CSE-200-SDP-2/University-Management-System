﻿
namespace University_Management_System
{
    partial class Student_Menu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sturesult = new System.Windows.Forms.TabPage();
            this.stucourses = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settings = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.sturesult);
            this.tabControl1.Controls.Add(this.stucourses);
            this.tabControl1.Controls.Add(this.settings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 156);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 532);
            this.tabControl1.TabIndex = 0;
            // 
            // sturesult
            // 
            this.sturesult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.sturesult.Location = new System.Drawing.Point(4, 30);
            this.sturesult.Name = "sturesult";
            this.sturesult.Padding = new System.Windows.Forms.Padding(3);
            this.sturesult.Size = new System.Drawing.Size(972, 498);
            this.sturesult.TabIndex = 0;
            this.sturesult.Text = "Result";
            // 
            // stucourses
            // 
            this.stucourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.stucourses.Location = new System.Drawing.Point(4, 30);
            this.stucourses.Name = "stucourses";
            this.stucourses.Padding = new System.Windows.Forms.Padding(3);
            this.stucourses.Size = new System.Drawing.Size(972, 498);
            this.stucourses.TabIndex = 1;
            this.stucourses.Text = "Courses";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 156);
            this.panel1.TabIndex = 1;
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.settings.Location = new System.Drawing.Point(4, 30);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(972, 498);
            this.settings.TabIndex = 2;
            this.settings.Text = "Settings";
            // 
            // Student_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(980, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Student_Menu";
            this.Text = "Student_Menu";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sturesult;
        private System.Windows.Forms.TabPage stucourses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage settings;
    }
}