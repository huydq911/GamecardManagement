namespace GameCard_HuyDQ
{
    partial class LoginForm
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
            lblAppName = new Label();
            gbLoginForm = new GroupBox();
            lblSignIn = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblPassword = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            gbLoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppName.Location = new Point(266, 26);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(328, 46);
            lblAppName.TabIndex = 20;
            lblAppName.Text = "GameCardManager";
            // 
            // gbLoginForm
            // 
            gbLoginForm.BackColor = Color.LimeGreen;
            gbLoginForm.Controls.Add(lblSignIn);
            gbLoginForm.Controls.Add(txtPassword);
            gbLoginForm.Controls.Add(btnLogin);
            gbLoginForm.Controls.Add(lblPassword);
            gbLoginForm.Controls.Add(txtEmail);
            gbLoginForm.Controls.Add(lblEmail);
            gbLoginForm.FlatStyle = FlatStyle.Flat;
            gbLoginForm.Location = new Point(255, 88);
            gbLoginForm.Name = "gbLoginForm";
            gbLoginForm.Size = new Size(339, 363);
            gbLoginForm.TabIndex = 19;
            gbLoginForm.TabStop = false;
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignIn.Location = new Point(117, 21);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(109, 38);
            lblSignIn.TabIndex = 17;
            lblSignIn.Text = "Sign In";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(61, 224);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(220, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 192, 192);
            btnLogin.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(61, 289);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(219, 44);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Sign in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(57, 196);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 20);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(61, 139);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 27);
            txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(55, 108);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(849, 502);
            Controls.Add(lblAppName);
            Controls.Add(gbLoginForm);
            Name = "LoginForm";
            Text = "LoginForm";
            gbLoginForm.ResumeLayout(false);
            gbLoginForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private GroupBox gbLoginForm;
        private Label lblSignIn;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblPassword;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}