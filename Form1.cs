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
            Random rnd = new Random();
            while (true )
            {
                int attemp = 1;
                while (true)
                {
                    var result = MessageBox.Show($"���� �����: {rnd.Next(0, 2000)}?", "Game", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show($"����'���� ������ ���� ������ �� {attemp} �����!", "End", MessageBoxButtons.OK);
                        break;
                    }
                    attemp++;
                }
                var restart = MessageBox.Show("�� ������ ��������� ���?", "End", MessageBoxButtons.YesNo);
                if (restart == DialogResult.No) { break; }
            }
            this.Close();
        }
    }
}