using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace TicTacToe__
{
    public partial class Form5 : Form
    {
       static string winner;

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public Form5()  
        {
            InitializeComponent();
            player.URL = "satya1.m4a";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }


        public static void setPlayerName(String n1)
        {
            winner = n1;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            p1.Text = winner;
        }
    }
}
