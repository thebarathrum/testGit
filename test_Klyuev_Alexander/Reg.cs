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
    public partial class Reg : Form
    {
        public static string login;
        public static string password;
        public Reg()
        {
            InitializeComponent();
        }

        private void Sign_Up_Click(object sender, EventArgs e)
        {
            if ((TB_Login.Text == "") || (TB_Password.Text == ""))
            {
                MessageBox.Show("Both field must be filled.");
            }
            else
            {
                login = TB_Login.Text;
                password = TB_Password.Text;
                MessageBox.Show("You are successfully registered an user account");
                this.Visible = false;
            }
        }
    }
    
}
