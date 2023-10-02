namespace WinFormsApp1
{
    partial class Check
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
            lbPrice = new Label();
            tb_price = new TextBox();
            lb_bill = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 313);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 3;
            label1.Text = "грн";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(12, 313);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(83, 15);
            lbPrice.TabIndex = 2;
            lbPrice.Text = "Загальна ціна";
            // 
            // tb_price
            // 
            tb_price.Location = new Point(101, 310);
            tb_price.Name = "tb_price";
            tb_price.ReadOnly = true;
            tb_price.Size = new Size(130, 23);
            tb_price.TabIndex = 1;
            // 
            // lb_bill
            // 
            lb_bill.FormattingEnabled = true;
            lb_bill.ItemHeight = 15;
            lb_bill.Location = new Point(12, 12);
            lb_bill.Name = "lb_bill";
            lb_bill.Size = new Size(259, 289);
            lb_bill.TabIndex = 0;
            // 
            // Check
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 348);
            Controls.Add(label1);
            Controls.Add(tb_price);
            Controls.Add(lbPrice);
            Controls.Add(lb_bill);
            Name = "Check";
            Text = "Чек";
            Load += Check_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbPrice;
        private TextBox tb_price;
        private ListBox lb_bill;
        private Label label1;
    }
}