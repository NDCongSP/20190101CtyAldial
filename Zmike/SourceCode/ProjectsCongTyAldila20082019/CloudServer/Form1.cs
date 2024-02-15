using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudServer
{
    public partial class Form1 : Form
    {
        string ipCloud = "";
        public Form1()
        {
            InitializeComponent();
            ipCloud = ConfigurationManager.AppSettings["Ipcloud"];
            iWebPort1.ServerIP = ipCloud.Trim();
            label2.Text = ipCloud;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            notifyIcon1.Visible = true;
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Do you want to exit this program?",
               "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                Environment.Exit(1);
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            notifyIcon1.Visible = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }
    }
}
