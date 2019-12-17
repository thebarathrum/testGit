using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_Klyuev_Alexander
{
    public partial class Auth : Form
    {
        string log = "admin";
        string pass = "admin";
        public Auth()
        {
            InitializeComponent();

        }

        private void Auth_Click(object sender, EventArgs e)
        {
            string Log = Reg.login;
            string Pass = Reg.password;
            if ((TB_Login.Text == Log) && (TB_Password.Text == Pass))
            {
                MessageBox.Show("You are successfully authorized.");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("A combination of log & pass are incorrect. Please, try again.");
                TB_Login.Text = "";
                TB_Password.Text = "";
            }
        }

        private void L_Reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Reg = new Reg();
            Reg.Show();
        }
    }
}
