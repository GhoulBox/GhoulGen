using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhoulGen_2021
{
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            settings x = new settings();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }
    }
}
