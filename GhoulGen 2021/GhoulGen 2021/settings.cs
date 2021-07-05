using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace GhoulGen_2021
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            Region = Region.FromHrgn(global.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        private void settings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                global.ReleaseCapture();
                global.SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TopMost = true;
                MessageBox.Show("TopMost Enabled", "GhoulGen 2021");
            }
            else
            {
                TopMost = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main newform = new Main();
            this.Hide();
            newform.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)=> Process.Start("com.epicgames.launcher://apps/Fortnite?action=launch");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("FortniteClient-Win64-Shipping"))
                {
                    proc.Kill();
                }
                MessageBox.Show("Fortnite Has Been Killed Sucessfully.", "GhoulGen 2021");
            }
            catch (Exception ex)
            {   
                MessageBox.Show(ex.Message);
            }
        }
    }
}
