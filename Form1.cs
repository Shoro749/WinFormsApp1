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
            string text = "��'�: �����";
            string title = "Resume";
            int temp = text.Length;
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            text = "³�: 30 ����";
            temp += text.Length;
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            text = "�����: ��������, ������ �� ���������";
            temp += text.Length;
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            text = "����� ������: ϳ����� ���� � ���� ������";
            temp += text.Length;
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            text = "����������: �����, �������, �������";
            temp += text.Length;
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            text = "����: ����������� � ����������� ��� ������� � ����� ������.";
            temp += text.Length;
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            text = "������ ����� �������: ";
            temp += text.Length;
            MessageBox.Show(text + Convert.ToString(temp / 6), title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}