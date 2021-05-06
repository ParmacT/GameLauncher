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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(Tor);
        }

        private void Farcry_Click(object sender, EventArgs e)
        {
            Process.Start(FarCry5);
        }

        private void Beat_Saber_Click(object sender, EventArgs e)
        {
            Process.Start(Beatsaber);
        }

        private void Bn_Click(object sender, EventArgs e)
        {
            Process.Start(Boneworks);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start(Steamv);
        }
    }
}
