namespace WinFormsApp1
{
    partial class LoginScreen
    {
        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tb_login = new TextBox();
            b_login = new Button();
            b_reg = new Button();
            b_info = new Button();
            SuspendLayout();
            // 
            // tb_password
            // 
            tb_password.Location = new Point(67, 68);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(125, 23);
            tb_password.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "Логін";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // tb_login
            // 
            tb_login.Location = new Point(67, 30);
            tb_login.Name = "tb_login";
            tb_login.Size = new Size(125, 23);
            tb_login.TabIndex = 3;
            // 
            // b_login
            // 
            b_login.Location = new Point(12, 97);
            b_login.Name = "b_login";
            b_login.Size = new Size(180, 30);
            b_login.TabIndex = 4;
            b_login.Text = "Логін";
            b_login.UseVisualStyleBackColor = true;
            b_login.Click += b_loginClick;
            // 
            // b_reg
            // 
            b_reg.Location = new Point(12, 133);
            b_reg.Name = "b_reg";
            b_reg.Size = new Size(180, 30);
            b_reg.TabIndex = 5;
            b_reg.Text = "Зареєструватися";
            b_reg.UseVisualStyleBackColor = true;
            b_reg.Click += ToRegistClick;
            // 
            // b_info
            // 
            b_info.Location = new Point(176, 5);
            b_info.Name = "b_info";
            b_info.Size = new Size(20, 19);
            b_info.TabIndex = 6;
            b_info.Text = "i";
            b_info.UseVisualStyleBackColor = true;
            b_info.Click += getInfoClick;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(208, 179);
            Controls.Add(b_info);
            Controls.Add(b_reg);
            Controls.Add(b_login);
            Controls.Add(tb_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_password);
            Name = "LoginScreen";
            Text = "Login";
            Load += MainWindowLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_password;
        private Label label1;
        private Label label2;
        private TextBox tb_login;
        private Button b_login;
        private Button b_reg;
        private Button b_info;
    }
}