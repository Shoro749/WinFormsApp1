namespace WinFormsApp1
{
    public partial class LoginScreen : Form
    {
        string[] logins = new string[10];
        string[] passwords = new string[10];
        public LoginScreen()
        {
            InitializeComponent();
            logins[0] = "User";
            passwords[0] = "4321";
        }

        private void MainWindowLoad(object sender, EventArgs e)
        {

        }

        private void getInfoClick(object sender, EventArgs e)
        {
            MessageBox.Show("Login: Admin; Password: 1234;\nLogin: User; Password: 4321;");
        }

        private void b_loginClick(object sender, EventArgs e)
        {
            if (tb_login.Text == "Admin")
            {
                if (tb_password.Text == "1234")
                {
                    AdminScreen adminScreen = new AdminScreen();
                    adminScreen.Show();
                }
                else
                {
                    MessageBox.Show("Неправильний пароль!");
                }
            }
            else
            {
                for (int i = 0; i < logins.Length; i++)
                {
                    if (logins[i] == tb_login.Text)
                    {
                        if (passwords[i] == tb_password.Text)
                        {
                            UserScreen userScreen = new UserScreen();
                            userScreen.Show();
                        }
                        else
                        {
                            MessageBox.Show("Неправильний пароль!");
                        }
                        break;
                    }
                }
            }
        }

        private void ToRegistClick(object sender, EventArgs e)
        {
            RegistScreen registScreen = new RegistScreen();
            registScreen.StartPosition = FormStartPosition.CenterScreen;
            var res = registScreen.ShowDialog();
            if (res == DialogResult.OK)
            {
                for (int i = 0; i < logins.Length; i++)
                {
                    if (logins[i] == null)
                    {
                        logins[i] = registScreen.user.getLogin();
                        passwords[i] = registScreen.user.getPassword();
                        break;
                    }
                }
            }
        }
    }
}