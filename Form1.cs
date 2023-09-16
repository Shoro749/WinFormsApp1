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

        private void MouseCoordinates(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.Button == MouseButtons.Left)
            {
                this.Close();
            }

            int x = e.X;
            int y = e.Y;

            button1.Text = "X = " + x + ", Y = " + y;
        }

        private void RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int x = Size.Width;
                int y = Size.Height;

                button1.Text = "Довжина = " + y + "\nШирина = " + x;
            }
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            label1.Text = "X = " + x;
            label2.Text = "Y = " + y;
        }
    }
}