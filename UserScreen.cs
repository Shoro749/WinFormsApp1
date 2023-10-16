using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UserScreen : Form
    {
        public Good good3 { get; set; }
        int index;
        public UserScreen()
        {
            InitializeComponent();
            gb_payment.Hide();
            gb_bill.Hide();
            good3 = new Good("Toy", 50);
            lb_userGoods.Items.Add(good3);
        }

        private void ClickBuy(object sender, EventArgs e)
        {
            if (lb_userGoods.SelectedItems != null)
            {
                index = lb_userGoods.SelectedIndex;
                gb_payment.Show();
            }
            else { MessageBox.Show("Виберіть товар!"); }
        }

        private void ToPayClick(object sender, EventArgs e)
        {
            try
            {
                if (tb_number.Text == null)
                {
                    throw new Exception("Ви не ввели номер карти!");
                }
                else if (tb_validity == null)
                {
                    throw new Exception("Ви не ввели термін дії!");
                }
                else if (tb_code == null)
                {
                    throw new Exception("Ви не ввели код карти!");
                }
                else
                {
                    gb_payment.Hide();
                    lb_userGoods.Items[index] = good3;
                    tb_billName.Text = good3.getName();
                    tb_billPrice.Text = Convert.ToString(good3.getPrice());
                    lb_userGoods.Items.Remove(index);
                    gb_bill.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
