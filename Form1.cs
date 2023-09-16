namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainWindowLoad(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ми й не сумнівались, що ви так думаєте!");
            this.Close();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Top -= e.Y;
            button2.Left += e.X;
            if (button2.Top < -10 || button2.Top > 816)
                button2.Top = 60;
            if (button2.Left < -80 || button2.Left > 500)
                button2.Left = 120;
        }
    }
}