namespace WinFormsApp1
{
    partial class ChangeScreen
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
            tb_nameGood = new TextBox();
            tb_priceGood = new TextBox();
            b1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Назва товару";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 54);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Ціна товару";
            // 
            // tb_nameGood
            // 
            tb_nameGood.Location = new Point(110, 20);
            tb_nameGood.Name = "tb_nameGood";
            tb_nameGood.Size = new Size(140, 23);
            tb_nameGood.TabIndex = 2;
            // 
            // tb_priceGood
            // 
            tb_priceGood.Location = new Point(110, 51);
            tb_priceGood.Name = "tb_priceGood";
            tb_priceGood.Size = new Size(140, 23);
            tb_priceGood.TabIndex = 3;
            // 
            // b1
            // 
            b1.Location = new Point(25, 89);
            b1.Name = "b1";
            b1.Size = new Size(225, 35);
            b1.TabIndex = 4;
            b1.Text = "Додати";
            b1.UseVisualStyleBackColor = true;
            b1.Click += ChangeClick;
            // 
            // ChangeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 139);
            Controls.Add(b1);
            Controls.Add(tb_priceGood);
            Controls.Add(tb_nameGood);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangeScreen";
            Text = "Змінити товар";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_nameGood;
        private TextBox tb_priceGood;
        private Button b1;
    }
}