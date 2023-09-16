namespace WinFormsApp1
{
    partial class Form1
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(188, 55);
            label1.Name = "label1";
            label1.Size = new Size(373, 31);
            label1.TabIndex = 0;
            label1.Text = "Вы довольны своей зарплатой?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.FlatAppearance.MouseDownBackColor = Color.Lime;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(188, 265);
            button1.Name = "button1";
            button1.Size = new Size(97, 40);
            button1.TabIndex = 1;
            button1.Text = "Так";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.FlatAppearance.MouseDownBackColor = Color.Red;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(464, 265);
            button2.Name = "button2";
            button2.Size = new Size(97, 40);
            button2.TabIndex = 2;
            button2.Text = "Ні";
            button2.UseVisualStyleBackColor = false;
            button2.MouseMove += button2_MouseMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 461);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += MainWindowLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}