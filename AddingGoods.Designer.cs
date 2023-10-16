namespace WinFormsApp1
{
    partial class AddingGoods
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
            tb_goodsName = new TextBox();
            tb_price = new TextBox();
            b1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Назва товару";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 55);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Ціна товару";
            // 
            // tb_goodsName
            // 
            tb_goodsName.Location = new Point(103, 18);
            tb_goodsName.Name = "tb_goodsName";
            tb_goodsName.Size = new Size(179, 23);
            tb_goodsName.TabIndex = 3;
            // 
            // tb_price
            // 
            tb_price.Location = new Point(103, 52);
            tb_price.Name = "tb_price";
            tb_price.Size = new Size(179, 23);
            tb_price.TabIndex = 4;
            // 
            // b1
            // 
            b1.Location = new Point(18, 91);
            b1.Name = "b1";
            b1.Size = new Size(264, 41);
            b1.TabIndex = 5;
            b1.Text = "Додати товар";
            b1.UseVisualStyleBackColor = true;
            b1.Click += adding;
            // 
            // AddingGoods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 153);
            Controls.Add(b1);
            Controls.Add(tb_price);
            Controls.Add(tb_goodsName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddingGoods";
            Text = "AddingGoods";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_goodsName;
        private TextBox tb_price;
        private Button b1;
    }
}