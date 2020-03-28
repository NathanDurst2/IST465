using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class PasswordReset : Form
    {
        User user;
        public PasswordReset(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            string hash = SqliteDataAccess.VerifyPassword(user.Username)[0].Password;
            if(SecurePasswordHasher.Verify(tbCurrent.Text, hash))
            {
                if(tbNew1.Text == tbNew2.Text && tbCurrent.Text != tbNew1.Text)
                {
                    SqliteDataAccess.SetUserPassword(SecurePasswordHasher.Hash(tbNew1.Text), user.Username);
                    MessageBox.Show("Password changed successfully");
                    this.Close();
                }
                else if(tbNew1.Text != tbNew2.Text)
                {
                    MessageBox.Show("New passwords do not match. Try again");
                }
                else if (tbCurrent.Text == tbNew1.Text)
                {
                    MessageBox.Show("Your new password cannot be the same as your old password. Try again");
                }
            }
            else
            {
                MessageBox.Show("Incorrect password! Please enter the valid current password.");
            }
        }
    }
}
