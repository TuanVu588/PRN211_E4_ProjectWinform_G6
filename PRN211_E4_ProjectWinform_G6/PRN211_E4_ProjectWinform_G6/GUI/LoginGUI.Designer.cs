namespace PRN211_E4_ProjectWinform_G6.GUI
{
    partial class LoginGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 416);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.lbExit);
            this.panel2.Controls.Add(this.lbAdmin);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Controls.Add(this.tbUsername);
            this.panel2.Controls.Add(this.lbPassword);
            this.panel2.Controls.Add(this.lbUserName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(314, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 416);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "BookShop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUserName.ForeColor = System.Drawing.Color.DimGray;
            this.lbUserName.Location = new System.Drawing.Point(24, 164);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(130, 32);
            this.lbUserName.TabIndex = 3;
            this.lbUserName.Text = "UserName : ";
            // 
            // lbPassword
            // 
            this.lbPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lbPassword.Location = new System.Drawing.Point(24, 220);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(118, 32);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password : ";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(160, 161);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(250, 27);
            this.tbUsername.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(162, 222);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(248, 27);
            this.tbPassword.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbAdmin
            // 
            this.lbAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbAdmin.ForeColor = System.Drawing.Color.DimGray;
            this.lbAdmin.Location = new System.Drawing.Point(221, 360);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(75, 32);
            this.lbAdmin.TabIndex = 8;
            this.lbAdmin.Text = "Admin";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(64, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nice Staff";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(42, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 42);
            this.label6.TabIndex = 3;
            this.label6.Text = "Large  Collection";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(64, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nice Service";
            // 
            // lbExit
            // 
            this.lbExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbExit.Location = new System.Drawing.Point(431, 9);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(27, 32);
            this.lbExit.TabIndex = 9;
            this.lbExit.Text = "X";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // LoginGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginGUI";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lbExit;
        private Label lbAdmin;
        private Button button1;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Label lbPassword;
        private Label lbUserName;
    }
}