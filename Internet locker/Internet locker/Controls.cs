using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_locker
{
    public partial class Controls : Form
    {

        public Controls()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SetAllControls();
        }

        private void SetAllControls()
        {
            Lock.Top = (this.Height / 2) - (Lock.Height / 2) - 14;
            Unlock.Top = (this.Height / 2) - (Unlock.Height / 2) - 14;

            Lock.Left = (this.Width / 2) + (Lock.Width / 2) - 10;
            Unlock.Left = (this.Width / 4) - (Unlock.Width / 2) - 14;
        }
        private void Controls_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void LockUnlockControls(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
            ProcessStartInfo info = new ProcessStartInfo();
            Process p;

            switch (butt.Name)
            {
                case "Lock":
                    info.FileName = "ipconfig";
                    info.Arguments = "/release";
                    info.WindowStyle = ProcessWindowStyle.Hidden;
                    p = Process.Start(info);
                    MessageBox.Show("Internet Locked");
                    break;
                case "Unlock":
                    info.FileName = "ipconfig";
                    info.Arguments = "/renew";
                    info.WindowStyle = ProcessWindowStyle.Hidden;
                    p = Process.Start(info);
                    MessageBox.Show("Internet Unlocked");
                    break;
            }
        }
    }
}
