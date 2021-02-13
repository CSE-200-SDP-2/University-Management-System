
namespace University_Management_System
{
    partial class Teacher_Menu
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
            this.tchcourse = new System.Windows.Forms.TabPage();
            this.tchmark = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tchviewresult = new System.Windows.Forms.TabPage();
            this.tchsettings = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.courselist = new System.Windows.Forms.TabPage();
            this.studentlist = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.insertresult = new System.Windows.Forms.TabPage();
            this.modresult = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tchcourse.SuspendLayout();
            this.tchmark.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tchcourse);
            this.tabControl1.Controls.Add(this.tchmark);
            this.tabControl1.Controls.Add(this.tchviewresult);
            this.tabControl1.Controls.Add(this.tchsettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 157);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(968, 591);
            this.tabControl1.TabIndex = 0;
            // 
            // tchcourse
            // 
            this.tchcourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.tchcourse.Controls.Add(this.tabControl2);
            this.tchcourse.Location = new System.Drawing.Point(4, 30);
            this.tchcourse.Name = "tchcourse";
            this.tchcourse.Padding = new System.Windows.Forms.Padding(3);
            this.tchcourse.Size = new System.Drawing.Size(960, 557);
            this.tchcourse.TabIndex = 0;
            this.tchcourse.Text = "Course";
            // 
            // tchmark
            // 
            this.tchmark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.tchmark.Controls.Add(this.tabControl3);
            this.tchmark.Location = new System.Drawing.Point(4, 30);
            this.tchmark.Name = "tchmark";
            this.tchmark.Padding = new System.Windows.Forms.Padding(3);
            this.tchmark.Size = new System.Drawing.Size(960, 557);
            this.tchmark.TabIndex = 1;
            this.tchmark.Text = "Result sheet";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 157);
            this.panel1.TabIndex = 1;
            // 
            // tchviewresult
            // 
            this.tchviewresult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.tchviewresult.Location = new System.Drawing.Point(4, 30);
            this.tchviewresult.Name = "tchviewresult";
            this.tchviewresult.Size = new System.Drawing.Size(960, 557);
            this.tchviewresult.TabIndex = 2;
            this.tchviewresult.Text = "View Result";
            // 
            // tchsettings
            // 
            this.tchsettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.tchsettings.Location = new System.Drawing.Point(4, 30);
            this.tchsettings.Name = "tchsettings";
            this.tchsettings.Size = new System.Drawing.Size(960, 557);
            this.tchsettings.TabIndex = 3;
            this.tchsettings.Text = "Settings";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.courselist);
            this.tabControl2.Controls.Add(this.studentlist);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(954, 551);
            this.tabControl2.TabIndex = 0;
            // 
            // courselist
            // 
            this.courselist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.courselist.Location = new System.Drawing.Point(4, 30);
            this.courselist.Name = "courselist";
            this.courselist.Padding = new System.Windows.Forms.Padding(3);
            this.courselist.Size = new System.Drawing.Size(946, 517);
            this.courselist.TabIndex = 0;
            this.courselist.Text = "Course List";
            // 
            // studentlist
            // 
            this.studentlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.studentlist.Location = new System.Drawing.Point(4, 30);
            this.studentlist.Name = "studentlist";
            this.studentlist.Padding = new System.Windows.Forms.Padding(3);
            this.studentlist.Size = new System.Drawing.Size(946, 517);
            this.studentlist.TabIndex = 1;
            this.studentlist.Text = "Student List";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.insertresult);
            this.tabControl3.Controls.Add(this.modresult);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(3, 3);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(954, 551);
            this.tabControl3.TabIndex = 0;
            // 
            // insertresult
            // 
            this.insertresult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.insertresult.Location = new System.Drawing.Point(4, 30);
            this.insertresult.Name = "insertresult";
            this.insertresult.Padding = new System.Windows.Forms.Padding(3);
            this.insertresult.Size = new System.Drawing.Size(946, 517);
            this.insertresult.TabIndex = 0;
            this.insertresult.Text = "Insert Result";
            // 
            // modresult
            // 
            this.modresult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.modresult.Location = new System.Drawing.Point(4, 30);
            this.modresult.Name = "modresult";
            this.modresult.Padding = new System.Windows.Forms.Padding(3);
            this.modresult.Size = new System.Drawing.Size(946, 517);
            this.modresult.TabIndex = 1;
            this.modresult.Text = "Modify Result";
            // 
            // Teacher_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(968, 748);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Teacher_Menu";
            this.Text = "Teacher_Menu";
            this.tabControl1.ResumeLayout(false);
            this.tchcourse.ResumeLayout(false);
            this.tchmark.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tchcourse;
        private System.Windows.Forms.TabPage tchmark;
        private System.Windows.Forms.TabPage tchviewresult;
        private System.Windows.Forms.TabPage tchsettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage courselist;
        private System.Windows.Forms.TabPage studentlist;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage insertresult;
        private System.Windows.Forms.TabPage modresult;
    }
}