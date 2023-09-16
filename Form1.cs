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
            string text = "Ім'я: Андрій";
            string title = "Resume";
            int temp = text.Length;
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            text = "Вік: 30 років";
            temp += text.Length;
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            text = "Освіта: Бакалавр, галузь не визначена";
            temp += text.Length;
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            text = "Досвід роботи: Півтора роки у сфері послуг";
            temp += text.Length;
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            text = "Захоплення: Спорт, читання, подорожі";
            temp += text.Length;
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            text = "Мета: Розвиватися і покращувати свої навички в різних сферах.";
            temp += text.Length;
            title = Convert.ToString(temp/6);
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}