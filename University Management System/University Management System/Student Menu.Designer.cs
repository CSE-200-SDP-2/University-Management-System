
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.course = new System.Windows.Forms.TabPage();
            this.result = new System.Windows.Forms.TabPage();
            this.settings = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 131);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.course);
            this.tabControl1.Controls.Add(this.result);
            this.tabControl1.Controls.Add(this.settings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 567);
            this.tabControl1.TabIndex = 1;
            // 
            // course
            // 
            this.course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.course.Location = new System.Drawing.Point(4, 30);
            this.course.Name = "course";
            this.course.Padding = new System.Windows.Forms.Padding(3);
            this.course.Size = new System.Drawing.Size(948, 533);
            this.course.TabIndex = 0;
            this.course.Text = "Courses";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.result.Location = new System.Drawing.Point(4, 30);
            this.result.Name = "result";
            this.result.Padding = new System.Windows.Forms.Padding(3);
            this.result.Size = new System.Drawing.Size(948, 533);
            this.result.TabIndex = 1;
            this.result.Text = "Result";
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.settings.Location = new System.Drawing.Point(4, 30);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(948, 533);
            this.settings.TabIndex = 2;
            this.settings.Text = "Settings";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 567);
            this.panel2.TabIndex = 2;
            // 
            // Student_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(956, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Student_Menu";
            this.Text = "Student_Menu";
            this.Load += new System.EventHandler(this.Student_Menu_Load);
            this.tabControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage course;
        private System.Windows.Forms.TabPage result;
        private System.Windows.Forms.TabPage settings;
        private System.Windows.Forms.Panel panel2;
    }
}