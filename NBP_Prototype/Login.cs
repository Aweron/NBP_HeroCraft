using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBP_Prototype
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MongoManager mongo = new MongoManager();

            string user = txtNewUser.Text;
            string pass = txtNewPass.Text;

            if (user == "" || pass == "")
                System.Windows.Forms.MessageBox.Show("Enter username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (mongo.ProfileExistsInDB(user))
                System.Windows.Forms.MessageBox.Show("That username is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Profile profile = new Profile(user, pass);
                mongo.SaveProfile(profile);

                Main nextForm = new Main(profile);
                this.Hide();
                nextForm.ShowDialog();
                this.Show();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            MongoManager mongo = new MongoManager();

            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user == "" || pass == "")
                System.Windows.Forms.MessageBox.Show("Enter username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (mongo.ProfileExistsInDB(user))
                if (mongo.ProfileAuthentication(user, pass))
                {
                    Profile profile = mongo.GetProfileData(user);

                    Main nextForm = new Main(profile);
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Show();
                }
                else
                    System.Windows.Forms.MessageBox.Show("Password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                System.Windows.Forms.MessageBox.Show("Username is incorrect or doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
