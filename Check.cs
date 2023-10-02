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
    public partial class Check : Form
    {
        int[] arr2 = new int[8];
        public Check(int[] arr)
        {
            InitializeComponent();
            arr2 = arr;
        }

        private void Check_Load(object sender, EventArgs e)
        {
            string str;
            int sum = 0;
            if (arr2[0] > 0)
            {
                str = "Експрессо - х" + arr2[0] + " = " + arr2[0] * 15 + "грн";
                lb_bill.Items.Add(str);
                sum += arr2[0] * 15;
            }
            if (arr2[1] > 0)
            {
                str = "Арабіка - х" + arr2[1] + " = " + arr2[1] * 10 + "грн";
                lb_bill.Items.Add(str);
                sum += arr2[1] * 10;
            }
            if (arr2[2] > 0)
            {
                str = "Робуста - х" + arr2[2] + " = " + arr2[2] * 5 + "грн";
                lb_bill.Items.Add(str);
                sum += arr2[2] * 5;
            }
            if (arr2[3] > 0)
            {
                str = "Кава в зернах - х" + arr2[3] + " = " + arr2[3] * 30 + "грн";
                lb_bill.Items.Add(str);
                sum += arr2[3] * 30;
            }
            if (arr2[4] > 0)
            {
                str = "Кавові суміші - х" + arr2[4] + " = " + arr2[4] * 20 + "грн";
                lb_bill.Items.Add(str);
                sum += arr2[4] * 20;
            }
            if (arr2[5] > 0)
            {
                str = "Кава молота - х" + arr2[5] + " = " + arr2[5] * 25 + "грн";
                lb_bill.Items.Add(str);
                sum += arr2[5] * 25;
            }
            if (arr2[6] > 0)
            {
                str = "Drip Coffee - х" + arr2[6] + " = " + arr2[6] * 10 + "грн";
                lb_bill.Items.Add(str);
                sum += arr2[6] * 10;
            }
            if (arr2[7] > 0)
            {
                str = "French Press - х" + arr2[7] + " = " + arr2[7] * 12 + "грн";
                lb_bill.Items.Add(str);
                sum += arr2[7] * 12;
            }
            tb_price.Text = Convert.ToString(sum);
        }
    }
}
