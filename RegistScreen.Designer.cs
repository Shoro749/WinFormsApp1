namespace WinFormsApp1
{
    partial class RegistScreen
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_chpass = new TextBox();
            tb_password = new TextBox();
            tb_log = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            b_regist = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 46);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Введіть логін";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 77);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Введіть пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 2;
            label3.Text = "Підтвердіть пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 139);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "Введіть номер";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 171);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 4;
            label5.Text = "Введіть країну";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(103, 9);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 5;
            label6.Text = "Регістрація";
            // 
            // tb_chpass
            // 
            tb_chpass.Location = new Point(130, 102);
            tb_chpass.Name = "tb_chpass";
            tb_chpass.Size = new Size(137, 23);
            tb_chpass.TabIndex = 6;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(130, 74);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(137, 23);
            tb_password.TabIndex = 7;
            // 
            // tb_log
            // 
            tb_log.Location = new Point(130, 43);
            tb_log.Name = "tb_log";
            tb_log.Size = new Size(137, 23);
            tb_log.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(130, 136);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(137, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(130, 168);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(137, 23);
            textBox5.TabIndex = 10;
            // 
            // b_regist
            // 
            b_regist.Location = new Point(12, 204);
            b_regist.Name = "b_regist";
            b_regist.Size = new Size(255, 40);
            b_regist.TabIndex = 11;
            b_regist.Text = "Зареєструватися";
            b_regist.UseVisualStyleBackColor = true;
            b_regist.Click += RegisterClick;
            // 
            // RegistScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 256);
            Controls.Add(b_regist);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(tb_log);
            Controls.Add(tb_password);
            Controls.Add(tb_chpass);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistScreen";
            Text = "RegistScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_chpass;
        private TextBox tb_password;
        private TextBox tb_log;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button b_regist;
    }
}