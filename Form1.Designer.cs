namespace WinFormsApp1
{
    partial class Cafe
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
            Menu = new GroupBox();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Basket = new ListBox();
            gb_payable = new GroupBox();
            b_printcheck = new Button();
            cb_isDiscount = new CheckBox();
            tb_Discount = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tb_ResultPrice = new TextBox();
            Menu.SuspendLayout();
            gb_payable.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Controls.Add(button8);
            Menu.Controls.Add(button7);
            Menu.Controls.Add(button6);
            Menu.Controls.Add(button5);
            Menu.Controls.Add(button4);
            Menu.Controls.Add(button3);
            Menu.Controls.Add(button2);
            Menu.Controls.Add(button1);
            Menu.Location = new Point(375, 12);
            Menu.Name = "Menu";
            Menu.Size = new Size(413, 426);
            Menu.TabIndex = 0;
            Menu.TabStop = false;
            Menu.Text = "Меню";
            // 
            // button8
            // 
            button8.Location = new Point(158, 278);
            button8.Name = "button8";
            button8.Size = new Size(109, 100);
            button8.TabIndex = 7;
            button8.Text = "French Press 12 грн";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(19, 278);
            button7.Name = "button7";
            button7.Size = new Size(109, 100);
            button7.TabIndex = 6;
            button7.Text = "Drip Coffee 10 грн";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(297, 149);
            button6.Name = "button6";
            button6.Size = new Size(110, 100);
            button6.TabIndex = 5;
            button6.Text = "  Кава   молота   25 грн";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(158, 149);
            button5.Name = "button5";
            button5.Size = new Size(109, 100);
            button5.TabIndex = 4;
            button5.Text = "Кавові  суміші    20 грн";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(19, 149);
            button4.Name = "button4";
            button4.Size = new Size(109, 100);
            button4.TabIndex = 3;
            button4.Text = "Кава в зернах 30 грн";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(297, 22);
            button3.Name = "button3";
            button3.Size = new Size(110, 101);
            button3.TabIndex = 2;
            button3.Text = "  Робуста  5 грн";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(158, 22);
            button2.Name = "button2";
            button2.Size = new Size(109, 101);
            button2.TabIndex = 1;
            button2.Text = " Арабіка  10 грн";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(19, 22);
            button1.Name = "button1";
            button1.Size = new Size(108, 101);
            button1.TabIndex = 0;
            button1.Text = "Еспрессо 15 грн";
            button1.UseVisualStyleBackColor = true;
            // 
            // Basket
            // 
            Basket.FormattingEnabled = true;
            Basket.ItemHeight = 15;
            Basket.Location = new Point(12, 12);
            Basket.Name = "Basket";
            Basket.Size = new Size(357, 289);
            Basket.TabIndex = 2;
            // 
            // gb_payable
            // 
            gb_payable.Controls.Add(b_printcheck);
            gb_payable.Controls.Add(cb_isDiscount);
            gb_payable.Controls.Add(tb_Discount);
            gb_payable.Controls.Add(label2);
            gb_payable.Controls.Add(label1);
            gb_payable.Controls.Add(tb_ResultPrice);
            gb_payable.Location = new Point(12, 311);
            gb_payable.Name = "gb_payable";
            gb_payable.Size = new Size(357, 127);
            gb_payable.TabIndex = 3;
            gb_payable.TabStop = false;
            gb_payable.Text = "До сплати";
            // 
            // b_printcheck
            // 
            b_printcheck.Location = new Point(6, 74);
            b_printcheck.Name = "b_printcheck";
            b_printcheck.Size = new Size(345, 38);
            b_printcheck.TabIndex = 5;
            b_printcheck.Text = "Друкувати чек";
            b_printcheck.UseVisualStyleBackColor = true;
            // 
            // cb_isDiscount
            // 
            cb_isDiscount.AutoSize = true;
            cb_isDiscount.Location = new Point(336, 33);
            cb_isDiscount.Name = "cb_isDiscount";
            cb_isDiscount.Size = new Size(15, 14);
            cb_isDiscount.TabIndex = 4;
            cb_isDiscount.UseVisualStyleBackColor = true;
            // 
            // tb_Discount
            // 
            tb_Discount.Location = new Point(255, 29);
            tb_Discount.Name = "tb_Discount";
            tb_Discount.Size = new Size(68, 23);
            tb_Discount.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 32);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Знижка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Загальна сума";
            // 
            // tb_ResultPrice
            // 
            tb_ResultPrice.Location = new Point(99, 29);
            tb_ResultPrice.Name = "tb_ResultPrice";
            tb_ResultPrice.ReadOnly = true;
            tb_ResultPrice.Size = new Size(69, 23);
            tb_ResultPrice.TabIndex = 0;
            // 
            // Cafe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(gb_payable);
            Controls.Add(Basket);
            Controls.Add(Menu);
            Name = "Cafe";
            Text = "Кафе";
            Load += MainWindowLoad;
            Menu.ResumeLayout(false);
            gb_payable.ResumeLayout(false);
            gb_payable.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Menu;
        private ListBox Basket;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private GroupBox gb_payable;
        private TextBox tb_Discount;
        private Label label2;
        private Label label1;
        private TextBox tb_ResultPrice;
        private Button b_printcheck;
        private CheckBox cb_isDiscount;
    }
}