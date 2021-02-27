
namespace University_Management_System
{
    partial class Change_Password
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
            this.confirmPass = new System.Windows.Forms.Button();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.newPasscon = new System.Windows.Forms.TextBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmPass
            // 
            this.confirmPass.FlatAppearance.BorderSize = 0;
            this.confirmPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.confirmPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmPass.ForeColor = System.Drawing.Color.White;
            this.confirmPass.Location = new System.Drawing.Point(735, 345);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(108, 31);
            this.confirmPass.TabIndex = 20;
            this.confirmPass.Text = "Confirm";
            this.confirmPass.UseVisualStyleBackColor = true;
            this.confirmPass.Click += new System.EventHandler(this.confirmPass_Click);
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass.ForeColor = System.Drawing.Color.White;
            this.showPass.Location = new System.Drawing.Point(735, 290);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(113, 21);
            this.showPass.TabIndex = 19;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // newPass
            // 
            this.newPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.newPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPass.ForeColor = System.Drawing.Color.White;
            this.newPass.Location = new System.Drawing.Point(589, 219);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(259, 23);
            this.newPass.TabIndex = 17;
            this.newPass.TextChanged += new System.EventHandler(this.newPass_TextChanged);
            // 
            // newPasscon
            // 
            this.newPasscon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.newPasscon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPasscon.ForeColor = System.Drawing.Color.White;
            this.newPasscon.Location = new System.Drawing.Point(589, 255);
            this.newPasscon.Name = "newPasscon";
            this.newPasscon.Size = new System.Drawing.Size(259, 23);
            this.newPasscon.TabIndex = 18;
            this.newPasscon.TextChanged += new System.EventHandler(this.newPasscon_TextChanged);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.White;
            this.panel18.Location = new System.Drawing.Point(413, 279);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(440, 4);
            this.panel18.TabIndex = 15;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.Location = new System.Drawing.Point(413, 243);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(440, 4);
            this.panel17.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(410, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 23);
            this.label14.TabIndex = 13;
            this.label14.Text = "New Password       :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(410, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 23);
            this.label15.TabIndex = 14;
            this.label15.Text = "Confirm Password :";
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1262, 595);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.newPasscon);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Change_Password";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.Change_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmPass;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.TextBox newPasscon;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}