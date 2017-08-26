using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe__
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "http://www.facebook.com/Imsatya18");
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "http://www.facebook.com/Imsatya18");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "http://www.twitter.com");
        }
    }
}
