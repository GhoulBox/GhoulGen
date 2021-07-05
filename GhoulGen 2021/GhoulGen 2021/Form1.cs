using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace GhoulGen_2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(global.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)=> Process.Start("https://pastebin.com/raw/sq3BS8DS");

        private void button1_Click(object sender, EventArgs e)
        {
            int tries = 0;
            while(tries < 3)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please Enter A Key!", "GhoulGen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    if (textBox1.Text == "2u9z02.0j3z9w.02uzxu")
                    {
                        MessageBox.Show("Correct Key! Loading GhoulGen...", "GhoulGen", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Main newform = new Main();
                        this.Hide();
                        newform.ShowDialog();
                        this.Close();
                        break;
                    }
                    else
                    {
                        tries++;
                        MessageBox.Show("Incorrect Key!", "GhoulGen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                global.ReleaseCapture();
                global.SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void label3_Click(object sender, EventArgs e) => Application.Exit();

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We have decided to add a key system as our stock is LIMITED, and we want to avoid people spamming to bypass the cooldown timer. It is very easy to get a key. Simply press the get key button. This process takes no more than 30 seconds.", "GhoulGen 2021", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
