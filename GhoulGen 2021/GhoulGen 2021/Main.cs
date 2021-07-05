using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;


namespace GhoulGen_2021
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Region = Region.FromHrgn(global.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string userName = username.Text;
            string fortnite = textBox1.Text;
          
            if (Directory.Exists(fortnite))
            {
                Directory.Delete(fortnite, true);
            } else
            {
                MessageBox.Show("Invalid File Path!", "GhoulGen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (comboBox1.Text)
            {
                case "1,000":
                    if(username.Text == "")
                    {
                        MessageBox.Show("You Didn't Enter A Username!", "GhoulGen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        MessageBox.Show("Adding 1,000 Vbucks To " + userName + " !");
                        MessageBox.Show("Sucessful, You May Now Launch Fortnite!", "GhoulGen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    break;
                  
                case "5,000":
                    if (username.Text == "")
                    {
                        MessageBox.Show("You Didn't Enter A Username!", "GhoulGen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Adding 5,000 Vbucks To " + userName + " !");
                        MessageBox.Show("Sucessful, You May Now Launch Fortnite!", "GhoulGen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "10,000":
                    if (username.Text == "")
                    {
                        MessageBox.Show("You Didn't Enter A Username!", "GhoulGen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Adding 10,000 Vbucks To " + userName + " !");
                        MessageBox.Show("Sucessful, You May Now Launch Fortnite!", "GhoulGen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                default:
                    MessageBox.Show("You Didn't Select An Amount Of Vbucks!");
                    break;
            }

        }
        private void rgb()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            int rgbamount = 1;
            int r = 255;
            int g = 0;
            int b = 0;
            for (; ; )
            {
                this.BackColor = Color.FromArgb(r, g, b);
                bool flag = r > 0 && b == 0;
                if (flag)
                {
                    r -= rgbamount;
                    g += rgbamount;
                }
                bool flag2 = g > 0 && r == 0;
                if (flag2)
                {
                    g -= rgbamount;
                    b += rgbamount;
                }
                bool flag3 = b > 0 && g == 0;
                if (flag3)
                {
                    b -= rgbamount;
                    r += rgbamount;
                }
                Thread.Sleep(5);
            }
        }

        private void Main_Load(object sender, EventArgs e) 
        {
            new Thread(new ThreadStart(this.rgb)).Start();
        }


        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                global.ReleaseCapture();
                global.SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }


        private void label4_Click(object sender, EventArgs e)=> Application.Exit();

        private void label5_Click(object sender, EventArgs e)=> this.WindowState = FormWindowState.Minimized;



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            settings newForm = new settings();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            skinchanger x = new skinchanger();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }
    }
}
