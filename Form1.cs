namespace WinFormsApp1
{
    public partial class Cafe : Form
    {

        public Cafe()
        {
            InitializeComponent();
        }

        private void MainWindowLoad(object sender, EventArgs e)
        {

        }

        int[] arr = { 0,0,0,0,0,0,0,0};
        int temp = 0;

        private void b1_Click(object sender, EventArgs e)
        {
            Basket.Items.Add("Експрессо 15грн");
            temp += 15;
            arr[0] += 1;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Basket.Items.Add("Арабіка 10грн");
            temp += 10;
            arr[1] += 1;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Basket.Items.Add("Робуста 5грн");
            temp += 5;
            arr[2] += 1;    
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Basket.Items.Add("Кава в зернах 30грн");
            temp += 30;
            arr[3] += 1;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Basket.Items.Add("Кавові суміші 20грн");
            temp += 20;
            arr[4] += 1;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Basket.Items.Add("Кава молота 25грн");
            temp += 25;
            arr[5] += 1;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Basket.Items.Add("Drip Coffee 10грн");
            temp += 10;
            arr[6] += 1;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Basket.Items.Add("French Press 12грн");
            temp += 12;
            arr[7] += 1;
        }

        private void RenewClick(object sender, EventArgs e)
        {
            tb_ResultPrice.Text = Convert.ToString(temp);
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            Basket.Items.Clear();
            temp = 0;
            tb_ResultPrice.Text = Convert.ToString(temp);
        }

        private void ChackedChanged(object sender, EventArgs e)
        {
            if (cb_isDiscount.Checked)
            {
                tb_Discount.Enabled = true;
            }
            else
            {
                tb_Discount.Text = "";
                tb_Discount.Enabled = false;
            }
        }

        private void bt_CheckClick(object sender, EventArgs e)
        {
            Check check = new Check(arr);
            check.StartPosition = FormStartPosition.CenterScreen;
            check.Show();
        }
    }
}