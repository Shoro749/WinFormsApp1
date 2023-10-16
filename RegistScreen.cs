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
    public partial class RegistScreen : Form
    {
        public Users user { get; set; }
        public RegistScreen()
        {
            InitializeComponent();
        }

        private void RegisterClick(object sender, EventArgs e)
        {
            try
            {
                if (tb_log == null)
                {
                    throw new Exception("Ви не ввели логін!");
                }
                else if (tb_password == null)
                {
                    throw new Exception("Ви не ввели пароль!");
                }
                else if (tb_chpass == null)
                {
                    throw new Exception("Ви не ввели пароль!");
                }
                else if (tb_chpass.Text == tb_password.Text)
                {
                    user = new Users(tb_log.Text, tb_password.Text);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else { throw new Exception("Паролі не співпадають!"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
