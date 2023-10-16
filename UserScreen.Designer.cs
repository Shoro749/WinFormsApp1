namespace WinFormsApp1
{
    partial class UserScreen
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
            lb_userGoods = new ListBox();
            groupBox1 = new GroupBox();
            b_pay = new Button();
            gb_payment = new GroupBox();
            b_toPay = new Button();
            tb_code = new TextBox();
            label3 = new Label();
            tb_validity = new TextBox();
            label2 = new Label();
            tb_number = new TextBox();
            label1 = new Label();
            gb_bill = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            tb_billName = new TextBox();
            tb_billPrice = new TextBox();
            groupBox1.SuspendLayout();
            gb_payment.SuspendLayout();
            gb_bill.SuspendLayout();
            SuspendLayout();
            // 
            // lb_userGoods
            // 
            lb_userGoods.FormattingEnabled = true;
            lb_userGoods.ItemHeight = 15;
            lb_userGoods.Location = new Point(383, 10);
            lb_userGoods.Name = "lb_userGoods";
            lb_userGoods.Size = new Size(405, 424);
            lb_userGoods.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(b_pay);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 95);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tools";
            // 
            // b_pay
            // 
            b_pay.Location = new Point(19, 34);
            b_pay.Name = "b_pay";
            b_pay.Size = new Size(309, 37);
            b_pay.TabIndex = 0;
            b_pay.Text = "Купити товар";
            b_pay.UseVisualStyleBackColor = true;
            b_pay.Click += ClickBuy;
            // 
            // gb_payment
            // 
            gb_payment.Controls.Add(b_toPay);
            gb_payment.Controls.Add(tb_code);
            gb_payment.Controls.Add(label3);
            gb_payment.Controls.Add(tb_validity);
            gb_payment.Controls.Add(label2);
            gb_payment.Controls.Add(tb_number);
            gb_payment.Controls.Add(label1);
            gb_payment.Location = new Point(12, 230);
            gb_payment.Name = "gb_payment";
            gb_payment.Size = new Size(354, 204);
            gb_payment.TabIndex = 2;
            gb_payment.TabStop = false;
            gb_payment.Text = "Оплата";
            // 
            // b_toPay
            // 
            b_toPay.Location = new Point(19, 151);
            b_toPay.Name = "b_toPay";
            b_toPay.Size = new Size(309, 38);
            b_toPay.TabIndex = 6;
            b_toPay.Text = "Оплатити";
            b_toPay.UseVisualStyleBackColor = true;
            b_toPay.Click += ToPayClick;
            // 
            // tb_code
            // 
            tb_code.Location = new Point(104, 111);
            tb_code.Name = "tb_code";
            tb_code.Size = new Size(224, 23);
            tb_code.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 114);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 4;
            label3.Text = "Код ";
            // 
            // tb_validity
            // 
            tb_validity.Location = new Point(104, 70);
            tb_validity.Name = "tb_validity";
            tb_validity.Size = new Size(224, 23);
            tb_validity.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 73);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Термін дії";
            // 
            // tb_number
            // 
            tb_number.Location = new Point(104, 30);
            tb_number.Name = "tb_number";
            tb_number.Size = new Size(224, 23);
            tb_number.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 33);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Номер карти";
            // 
            // gb_bill
            // 
            gb_bill.Controls.Add(tb_billPrice);
            gb_bill.Controls.Add(tb_billName);
            gb_bill.Controls.Add(label5);
            gb_bill.Controls.Add(label4);
            gb_bill.Location = new Point(12, 113);
            gb_bill.Name = "gb_bill";
            gb_bill.Size = new Size(354, 111);
            gb_bill.TabIndex = 7;
            gb_bill.TabStop = false;
            gb_bill.Text = "Чек";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 28);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 0;
            label4.Text = "Ви купили";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 61);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 1;
            label5.Text = "Ціна";
            // 
            // tb_billName
            // 
            tb_billName.Location = new Point(89, 25);
            tb_billName.Name = "tb_billName";
            tb_billName.ReadOnly = true;
            tb_billName.Size = new Size(239, 23);
            tb_billName.TabIndex = 2;
            // 
            // tb_billPrice
            // 
            tb_billPrice.Location = new Point(89, 58);
            tb_billPrice.Name = "tb_billPrice";
            tb_billPrice.ReadOnly = true;
            tb_billPrice.Size = new Size(239, 23);
            tb_billPrice.TabIndex = 3;
            // 
            // UserScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gb_bill);
            Controls.Add(gb_payment);
            Controls.Add(groupBox1);
            Controls.Add(lb_userGoods);
            Name = "UserScreen";
            Text = "UserScreen";
            groupBox1.ResumeLayout(false);
            gb_payment.ResumeLayout(false);
            gb_payment.PerformLayout();
            gb_bill.ResumeLayout(false);
            gb_bill.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lb_userGoods;
        private GroupBox groupBox1;
        private Button b_pay;
        private GroupBox gb_payment;
        private Button b_toPay;
        private TextBox tb_code;
        private Label label3;
        private TextBox tb_validity;
        private Label label2;
        private TextBox tb_number;
        private Label label1;
        private GroupBox gb_bill;
        private TextBox tb_billPrice;
        private TextBox tb_billName;
        private Label label5;
        private Label label4;
    }
}