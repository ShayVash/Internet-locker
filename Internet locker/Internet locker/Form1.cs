using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Internet_locker
{
    public partial class Form1 : Form
    {
        bool AdminChange;
        bool adminShow;
        public Form1()
        {
            InitializeComponent();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            label1.Hide();
            textBox1.Text = "";
            textBox1.Hide();
            firstTimeCheacker();
        }

        void firstTimeCheacker()
        {
            if (Properties.Settings.Default.passwordSet == true)
            {
                button2.Show();
                button3.Show();
                textBox1.Text = "";
            }
            else
            {
                button1.Show();
                textBox1.Show();
                label1.Show();
                textBox1.Text = "";
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.passwordSet = true;
            Properties.Settings.Default.Password = textBox1.Text;

            label1.Hide();
            textBox1.Hide();
            button1.Hide();
            button2.Show();
            button3.Show();
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            label1.Text = "please enter password";
            label1.Show();
            button4.Show();
            button2.Hide();
            button3.Hide();
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            label1.Text = "please enter password";
            label1.Show();
            button5.Show();
            button2.Hide();
            button3.Hide();
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Properties.Settings.Default.Password)
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = "ipconfig";
                info.Arguments = "/release";
                info.WindowStyle = ProcessWindowStyle.Hidden;
                Process p = Process.Start(info);
            }
            {
               MessageBox.Show("password is inccorect");
            }
            if (AdminChange == false)
            {
                textBox1.Hide();
                label1.Hide();
                button4.Hide();
                button5.Hide();
                button2.Show();
                button3.Show();
                textBox1.Text = "";
            }
            if (AdminChange == true)
            {
                button4.Hide();
                button5.Hide();
                button2.Hide();
                button3.Hide();
                AdminChange = false;
            }
            if (adminShow == true)
            {
                button5.Hide();
                button2.Hide();
                button3.Hide();
                textBox1.Text = Properties.Settings.Default.Password;
                label1.Show();
                textBox1.Show();
                button4.Show();
                adminShow = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Properties.Settings.Default.Password)
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = "ipconfig";
                info.Arguments = "/renew";
                info.WindowStyle = ProcessWindowStyle.Hidden;
                Process p = Process.Start(info);
            }
            else
            {
                MessageBox.Show("password inccorect");
            }
            textBox1.Hide();
            label1.Hide();
            button4.Hide();
            button5.Hide();
            button2.Show();
            button1.Hide();
            button3.Show();
            textBox1.Text = "";
        }
    }
}
