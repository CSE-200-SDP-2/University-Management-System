
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
            this.passwordpanel = new System.Windows.Forms.Panel();
            this.securitypanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SecureQues = new System.Windows.Forms.TextBox();
            this.SecureAns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nextbtn = new System.Windows.Forms.Button();
            this.passwordpanel.SuspendLayout();
            this.securitypanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmPass
            // 
            this.confirmPass.FlatAppearance.BorderSize = 0;
            this.confirmPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.confirmPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmPass.ForeColor = System.Drawing.Color.White;
            this.confirmPass.Location = new System.Drawing.Point(410, 240);
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
            this.showPass.Location = new System.Drawing.Point(410, 185);
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
            this.newPass.Location = new System.Drawing.Point(269, 114);
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
            this.newPasscon.Location = new System.Drawing.Point(269, 150);
            this.newPasscon.Name = "newPasscon";
            this.newPasscon.Size = new System.Drawing.Size(259, 23);
            this.newPasscon.TabIndex = 18;
            this.newPasscon.TextChanged += new System.EventHandler(this.newPasscon_TextChanged);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.White;
            this.panel18.Location = new System.Drawing.Point(88, 174);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(440, 4);
            this.panel18.TabIndex = 15;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.Location = new System.Drawing.Point(88, 138);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(440, 4);
            this.panel17.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(85, 114);
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
            this.label15.Location = new System.Drawing.Point(85, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 23);
            this.label15.TabIndex = 14;
            this.label15.Text = "Confirm Password :";
            // 
            // passwordpanel
            // 
            this.passwordpanel.Controls.Add(this.label14);
            this.passwordpanel.Controls.Add(this.label15);
            this.passwordpanel.Controls.Add(this.confirmPass);
            this.passwordpanel.Controls.Add(this.panel17);
            this.passwordpanel.Controls.Add(this.showPass);
            this.passwordpanel.Controls.Add(this.panel18);
            this.passwordpanel.Controls.Add(this.newPass);
            this.passwordpanel.Controls.Add(this.newPasscon);
            this.passwordpanel.Location = new System.Drawing.Point(325, 105);
            this.passwordpanel.Name = "passwordpanel";
            this.passwordpanel.Size = new System.Drawing.Size(613, 384);
            this.passwordpanel.TabIndex = 21;
            // 
            // securitypanel
            // 
            this.securitypanel.Controls.Add(this.nextbtn);
            this.securitypanel.Controls.Add(this.SecureAns);
            this.securitypanel.Controls.Add(this.label3);
            this.securitypanel.Controls.Add(this.SecureQues);
            this.securitypanel.Controls.Add(this.label2);
            this.securitypanel.Controls.Add(this.label1);
            this.securitypanel.Location = new System.Drawing.Point(325, 105);
            this.securitypanel.Name = "securitypanel";
            this.securitypanel.Size = new System.Drawing.Size(613, 384);
            this.securitypanel.TabIndex = 22;
            this.securitypanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set a security question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Question :";
            // 
            // SecureQues
            // 
            this.SecureQues.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecureQues.ForeColor = System.Drawing.Color.Black;
            this.SecureQues.Location = new System.Drawing.Point(131, 111);
            this.SecureQues.Name = "SecureQues";
            this.SecureQues.Size = new System.Drawing.Size(424, 31);
            this.SecureQues.TabIndex = 2;
            // 
            // SecureAns
            // 
            this.SecureAns.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecureAns.ForeColor = System.Drawing.Color.Black;
            this.SecureAns.Location = new System.Drawing.Point(131, 178);
            this.SecureAns.Name = "SecureAns";
            this.SecureAns.Size = new System.Drawing.Size(424, 31);
            this.SecureAns.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Answer   :";
            // 
            // nextbtn
            // 
            this.nextbtn.FlatAppearance.BorderSize = 0;
            this.nextbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.nextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextbtn.ForeColor = System.Drawing.Color.White;
            this.nextbtn.Location = new System.Drawing.Point(384, 240);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(108, 31);
            this.nextbtn.TabIndex = 21;
            this.nextbtn.Text = "Next";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1262, 595);
            this.Controls.Add(this.securitypanel);
            this.Controls.Add(this.passwordpanel);
            this.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Change_Password";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.Change_Password_Load);
            this.passwordpanel.ResumeLayout(false);
            this.passwordpanel.PerformLayout();
            this.securitypanel.ResumeLayout(false);
            this.securitypanel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel passwordpanel;
        private System.Windows.Forms.Panel securitypanel;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.TextBox SecureAns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SecureQues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}