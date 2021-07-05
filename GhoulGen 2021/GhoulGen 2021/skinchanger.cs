using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace GhoulGen_2021
{
    public partial class skinchanger : Form
    {
        public skinchanger()
        {
            InitializeComponent();
            Region = Region.FromHrgn(global.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void skinchanger_Load(object sender, EventArgs e)
        {
            DialogResult warning = MessageBox.Show("Other People Can See The Skin In-Game, And You Have A Chance Of Getting Banned. If You Press Yes, You Agree To Take Full Responsibility To What Happens To Your Account.", "GhoulGen 2021", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (warning)
            {
                case DialogResult.No:
                    Main newform = new Main();
                    this.Hide();
                    newform.ShowDialog();
                    this.Close();
                    break;
            }
            new Thread(new ThreadStart(this.rgb)).Start();
        }


        private void label1_Click(object sender, EventArgs e) => Application.Exit();

        private void label2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void skinchanger_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                global.ReleaseCapture();
                global.SendMessage(Handle, 0xA1, 0x2, 0);
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
    }
}
