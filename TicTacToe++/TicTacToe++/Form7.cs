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
    public partial class Form7 : Form
    {
        
        public Form7()
        {
            InitializeComponent();
        }
        static String level2;

       
        
private void button1_Click(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked == true)
            {
                level2 = "easy";
                Form1.level(level2);                
            }
            else if (metroRadioButton2.Checked == true)
            {
                level2 = "medium";
                Form1.level(level2);                
            }
            else if (metroRadioButton3.Checked == true)
            {
                level2 = "hard";
                Form1.level(level2);
            }
            else
            {
                level2 = "easy";
                Form1.level(level2);
            }
            Close();
        }
    
            
    }
}
