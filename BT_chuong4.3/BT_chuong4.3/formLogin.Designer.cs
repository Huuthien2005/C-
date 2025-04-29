namespace BT_chuong4._3
{
    partial class formLogin
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
            lblUser = new Label();
            lblPassword = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnEsc = new Button();
            btnSignin = new Button();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(87, 77);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(138, 25);
            lblUser.TabIndex = 0;
            lblUser.Text = "Tên Đăng Nhập:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(87, 131);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(265, 77);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(203, 31);
            txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(265, 131);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(208, 31);
            txtPassword.TabIndex = 1;
            // 
            // btnEsc
            // 
            btnEsc.Location = new Point(298, 200);
            btnEsc.Name = "btnEsc";
            btnEsc.Size = new Size(112, 34);
            btnEsc.TabIndex = 2;
            btnEsc.Text = "Đóng";
            btnEsc.UseVisualStyleBackColor = true;
            btnEsc.Click += btnEsc_Click;
            // 
            // btnSignin
            // 
            btnSignin.Location = new Point(134, 200);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(112, 34);
            btnSignin.TabIndex = 2;
            btnSignin.Text = "Đăng Nhập";
            btnSignin.UseVisualStyleBackColor = true;
            btnSignin.Click += btnSignin_Click;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(610, 316);
            Controls.Add(btnSignin);
            Controls.Add(btnEsc);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Name = "formLogin";
            Text = "Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPassword;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnEsc;
        private Button btnSignin;
    }
}