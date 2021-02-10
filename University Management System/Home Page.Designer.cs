
namespace University_Management_System
{
    partial class Home_Page
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
            this.label1 = new System.Windows.Forms.Label();
            this.library = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.Button();
            this.teacher = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.library);
            this.panel1.Controls.Add(this.student);
            this.panel1.Controls.Add(this.teacher);
            this.panel1.Controls.Add(this.admin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 138);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bangladesh University of Business & Technology";
            // 
            // library
            // 
            this.library.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.library.Location = new System.Drawing.Point(697, 88);
            this.library.Name = "library";
            this.library.Size = new System.Drawing.Size(75, 23);
            this.library.TabIndex = 4;
            this.library.Text = "Library";
            this.library.UseVisualStyleBackColor = true;
            // 
            // student
            // 
            this.student.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.student.Location = new System.Drawing.Point(530, 88);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(75, 23);
            this.student.TabIndex = 3;
            this.student.Text = "Student ";
            this.student.UseVisualStyleBackColor = true;
            // 
            // teacher
            // 
            this.teacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teacher.Location = new System.Drawing.Point(383, 88);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(75, 23);
            this.teacher.TabIndex = 2;
            this.teacher.Text = "Teacher";
            this.teacher.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(198, 89);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(118, 23);
            this.admin.TabIndex = 1;
            this.admin.Text = "Fahad cudir vai";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::University_Management_System.Properties.Resources.BUBT_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 138);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 581);
            this.panel2.TabIndex = 1;
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 717);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Home_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
<<<<<<< HEAD
        private System.Windows.Forms.Button library;
        private System.Windows.Forms.Button student;
        private System.Windows.Forms.Button teacher;
        private System.Windows.Forms.Button admin;
=======
        private System.Windows.Forms.Button Librarybtn;
        private System.Windows.Forms.Button Studentbtn;
        private System.Windows.Forms.Button Teacherbtn;
        private System.Windows.Forms.Button Adminbtn;
>>>>>>> 9f1d8c665ad665b8bcae7933d1858fce98d969c2
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}