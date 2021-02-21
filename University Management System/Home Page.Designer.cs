
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Page));
            this.navpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bubtlogo = new System.Windows.Forms.PictureBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.firstpic = new System.Windows.Forms.PictureBox();
            this.secondpic = new System.Windows.Forms.PictureBox();
            this.thirdpic = new System.Windows.Forms.PictureBox();
            this.fifthpic = new System.Windows.Forms.PictureBox();
            this.sixthpic = new System.Windows.Forms.PictureBox();
            this.lastpic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.navpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bubtlogo)).BeginInit();
            this.loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sixthpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastpic)).BeginInit();
            this.SuspendLayout();
            // 
            // navpanel
            // 
            this.navpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(237)))));
            this.navpanel.Controls.Add(this.label1);
            this.navpanel.Controls.Add(this.bubtlogo);
            this.navpanel.Controls.Add(this.loginbtn);
            this.navpanel.Controls.Add(this.logoutbtn);
            this.navpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navpanel.Location = new System.Drawing.Point(0, 0);
            this.navpanel.Name = "navpanel";
            this.navpanel.Size = new System.Drawing.Size(1284, 138);
            this.navpanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(837, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bangladesh University of Business  and Technology";
            // 
            // bubtlogo
            // 
            this.bubtlogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(237)))));
            this.bubtlogo.BackgroundImage = global::University_Management_System.Properties.Resources.BUBT_Logo;
            this.bubtlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bubtlogo.Location = new System.Drawing.Point(0, 0);
            this.bubtlogo.Name = "bubtlogo";
            this.bubtlogo.Size = new System.Drawing.Size(109, 138);
            this.bubtlogo.TabIndex = 0;
            this.bubtlogo.TabStop = false;
            this.bubtlogo.Click += new System.EventHandler(this.bubtlogo_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginbtn.BackColor = System.Drawing.Color.Transparent;
            this.loginbtn.FlatAppearance.BorderSize = 0;
            this.loginbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(1133, 80);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(82, 38);
            this.loginbtn.TabIndex = 6;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutbtn.FlatAppearance.BorderSize = 0;
            this.logoutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.Location = new System.Drawing.Point(1133, 80);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(82, 38);
            this.logoutbtn.TabIndex = 7;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 138);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(4);
            this.panel.Size = new System.Drawing.Size(1284, 5);
            this.panel.TabIndex = 1;
            // 
            // loginpanel
            // 
            this.loginpanel.Controls.Add(this.firstpic);
            this.loginpanel.Controls.Add(this.secondpic);
            this.loginpanel.Controls.Add(this.thirdpic);
            this.loginpanel.Controls.Add(this.fifthpic);
            this.loginpanel.Controls.Add(this.sixthpic);
            this.loginpanel.Controls.Add(this.lastpic);
            this.loginpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginpanel.Location = new System.Drawing.Point(0, 143);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(1284, 586);
            this.loginpanel.TabIndex = 2;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginpanel_Paint);
            // 
            // firstpic
            // 
            this.firstpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstpic.Image = ((System.Drawing.Image)(resources.GetObject("firstpic.Image")));
            this.firstpic.Location = new System.Drawing.Point(0, 0);
            this.firstpic.Name = "firstpic";
            this.firstpic.Size = new System.Drawing.Size(1284, 586);
            this.firstpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstpic.TabIndex = 5;
            this.firstpic.TabStop = false;
            // 
            // secondpic
            // 
            this.secondpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondpic.Image = ((System.Drawing.Image)(resources.GetObject("secondpic.Image")));
            this.secondpic.Location = new System.Drawing.Point(0, 0);
            this.secondpic.Name = "secondpic";
            this.secondpic.Size = new System.Drawing.Size(1284, 586);
            this.secondpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondpic.TabIndex = 4;
            this.secondpic.TabStop = false;
            // 
            // thirdpic
            // 
            this.thirdpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdpic.Image = ((System.Drawing.Image)(resources.GetObject("thirdpic.Image")));
            this.thirdpic.Location = new System.Drawing.Point(0, 0);
            this.thirdpic.Name = "thirdpic";
            this.thirdpic.Size = new System.Drawing.Size(1284, 586);
            this.thirdpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thirdpic.TabIndex = 3;
            this.thirdpic.TabStop = false;
            // 
            // fifthpic
            // 
            this.fifthpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fifthpic.Image = ((System.Drawing.Image)(resources.GetObject("fifthpic.Image")));
            this.fifthpic.Location = new System.Drawing.Point(0, 0);
            this.fifthpic.Name = "fifthpic";
            this.fifthpic.Size = new System.Drawing.Size(1284, 586);
            this.fifthpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fifthpic.TabIndex = 2;
            this.fifthpic.TabStop = false;
            // 
            // sixthpic
            // 
            this.sixthpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixthpic.Image = ((System.Drawing.Image)(resources.GetObject("sixthpic.Image")));
            this.sixthpic.Location = new System.Drawing.Point(0, 0);
            this.sixthpic.Name = "sixthpic";
            this.sixthpic.Size = new System.Drawing.Size(1284, 586);
            this.sixthpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sixthpic.TabIndex = 1;
            this.sixthpic.TabStop = false;
            // 
            // lastpic
            // 
            this.lastpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastpic.Image = ((System.Drawing.Image)(resources.GetObject("lastpic.Image")));
            this.lastpic.Location = new System.Drawing.Point(0, 0);
            this.lastpic.Name = "lastpic";
            this.lastpic.Size = new System.Drawing.Size(1284, 586);
            this.lastpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lastpic.TabIndex = 0;
            this.lastpic.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 729);
            this.Controls.Add(this.loginpanel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.navpanel);
            this.MinimumSize = new System.Drawing.Size(1278, 736);
            this.Name = "Home_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Page_Load);
            this.navpanel.ResumeLayout(false);
            this.navpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bubtlogo)).EndInit();
            this.loginpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firstpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sixthpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navpanel;
        private System.Windows.Forms.Label label1;
//=======
        
//>>>>>>> 9f1d8c665ad665b8bcae7933d1858fce98d969c2
        private System.Windows.Forms.PictureBox bubtlogo;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Button loginbtn;
        public System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.PictureBox fifthpic;
        private System.Windows.Forms.PictureBox sixthpic;
        private System.Windows.Forms.PictureBox lastpic;
        private System.Windows.Forms.PictureBox firstpic;
        private System.Windows.Forms.PictureBox secondpic;
        private System.Windows.Forms.PictureBox thirdpic;
        private System.Windows.Forms.Timer timer1;
    }
}