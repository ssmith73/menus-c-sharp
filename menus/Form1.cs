using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void òpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Really Quit?","Exit",MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }
    }
}
