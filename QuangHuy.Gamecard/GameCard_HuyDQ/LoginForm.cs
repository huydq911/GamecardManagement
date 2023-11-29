using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCard_HuyDQ
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text; 
            AccountService se = new AccountService(); ;

            MemberAccount account = se.CheckLogin(email, password);
            if (account == null)
            {
                MessageBox.Show("Login failed. Please check your credentials",
                                 "Wrong credentials", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }

            if (account.Role != 2 && account.Role != 3 && account.Role != 1 && account.Role != 4)
            {
                MessageBox.Show("You have no permission to access this function!",
                                "Access denied", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                if (account.Role == 2)
                {
                    StaffForm staffForm = new StaffForm();
                    staffForm.Show();
                    this.Hide();
                }
                else if (account.Role == 3 || account.Role == 1)
                {
                    GamecardManagerForm gamecardManagerFrom = new GamecardManagerForm();
                    gamecardManagerFrom.Show();
                    this.Hide();
                }
                else if (account.Role == 4)
                {
                    MemberForm memberForm = new MemberForm();
                    memberForm.Show();
                    this.Hide();
                }
                return;
            }
        }
    }
}
