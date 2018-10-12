using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_locker
{
    public partial class SetPassword : Form
    {
        Controls controls = new Controls();

        public SetPassword()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SetAllControls();
        }

        private void SetAllControls()
        {
            if (Properties.Settings.Default.passwordSet) { Title.Text = "Please enter your password"; }

            Title.Left = (this.Width / 2) - (Title.Width / 2) - 14;
            PasswordBox.Left = (this.Width / 2) - (PasswordBox.Width / 2) - 14;
            Done.Left = (this.Width / 2) - (Done.Width / 2) - 14;

            
        }
        private void SetUserPassword(object sender, EventArgs e)
        { 
            if (Properties.Settings.Default.passwordSet)
            {
                if (PasswordBox.Text.Equals(Properties.Settings.Default.Password))
                { 
                    controls.Show();
                    controls.DesktopLocation = this.DesktopLocation;
                    this.Hide();
                }
                else
                    MessageBox.Show("The password is incorrect!");
            }
            else
            {
                Properties.Settings.Default.Password = PasswordBox.Text;
                Properties.Settings.Default.passwordSet = true;
                Properties.Settings.Default.Save();

                controls.Show();
                controls.DesktopLocation = this.DesktopLocation;
                this.Hide();
            }
        }

    }
}
