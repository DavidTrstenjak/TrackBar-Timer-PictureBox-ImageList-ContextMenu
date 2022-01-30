using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuStrip_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cTRLDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        // klik na opciju LijevoDesno

        private void lijevoDesnoToolStripMenuItem_Click(object sender, EventArgs e)

        {

            textBox1.Text = textBox2.Text;

        }

        // klik na opciju DesnoLijevo

        private void desnoLijevoToolStripMenuItem_Click(object sender, EventArgs e)

        {

            textBox2.Text = textBox1.Text;

        }
    }
}
