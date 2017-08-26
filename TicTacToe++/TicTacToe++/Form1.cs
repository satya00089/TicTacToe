using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe__
{
    public partial class Form1 : Form
    {
        bool turn = true;
        bool against_computer = false;
        int turn_count = 0;
        int player1_win = 0, player2_win = 0, player3_win = 0;
        static string player1, player2;
        static String level1;

        public Form1()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(10000);
            InitializeComponent();
            t.Abort();
        }
        public void StartForm()
        {
            Application.Run(new Form6());
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((p1.Text == "player1") && (p2.Text == "player2"))
            {
                MessageBox.Show("You must specify the 'players' name before start the GAME!!! \n Type computer(for play with computer) ");
            }
            else
            {
                Button b = (Button)sender;
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";

                turn = !turn;
                b.Enabled = false;
                turn_count++;
                checkForWinner();                
            }

            if ((!turn) && (against_computer))
            {
                computer_make_move();
            }
        }

        private void computer_make_move()
        {
            Button move = null;

            move = look_for_win_or_block("O");//look for win
            if (move == null)
            {
                move = look_for_win_or_block("X");//look for block
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    }//end of if
                }//end of if
            }//end of if
            move.PerformClick();
        }
        private Button look_for_win_or_block(string mark)
        {
            Console.WriteLine("looking for win or block:" + mark);
            //HORIZONTAL TESTS
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            //VERTICAL TESTS
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;


        }

        private Button look_for_corner()
        {
            Console.WriteLine("Looking for corner");
            if (level1 == "easy")
            {
                if (A1.Text == "O")
                {
                    if (A3.Text == "")
                        return A3;
                    if (C3.Text == "")
                        return C3;
                    if (C1.Text == "")
                        return C1;
                }

                if (A3.Text == "O")
                {
                    if (A1.Text == "")
                        return A1;
                    if (C3.Text == "")
                        return C3;
                    if (C1.Text == "")
                        return C1;
                }

                if (C1.Text == "O")
                {
                    if (A3.Text == "")
                        return A3;
                    if (C3.Text == "")
                        return C3;
                    if (A1.Text == "")
                        return A1;
                }

                if (C3.Text == "O")
                {
                    if (A3.Text == "")
                        return A3;
                    if (C1.Text == "")
                        return C1;
                    if (A1.Text == "")
                        return A1;
                }

                if (B2.Text == "")
                    return B2;
                if (A1.Text == "")
                    return A1;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
                if (C3.Text == "")
                    return C3;

                return null;
            }
            else if(level1 == "medium")
            {
                if (A1.Text == "X" && C3.Text == "X" || A3.Text == "X" && C1.Text == "X")
                {
                    if (A2.Text == "")
                        return A2;
                    if (B3.Text == "")
                        return B3;
                    if (B1.Text == "")
                        return B1;
                    if (C2.Text == "")
                        return C2;
                }
                if (A1.Text == "O")
                {
                    if (A3.Text == "")
                        return A3;
                    if (C3.Text == "")
                        return C3;
                    if (C1.Text == "")
                        return C1;
                }

                if (A3.Text == "O")
                {
                    if (A1.Text == "")
                        return A1;
                    if (C3.Text == "")
                        return C3;
                    if (C1.Text == "")
                        return C1;
                }

                if (C1.Text == "O")
                {
                    if (A3.Text == "")
                        return A3;
                    if (C3.Text == "")
                        return C3;
                    if (A1.Text == "")
                        return A1;
                }

                if (C3.Text == "O")
                {
                    if (A3.Text == "")
                        return A3;
                    if (C1.Text == "")
                        return C1;
                    if (A1.Text == "")
                        return A1;
                }

                if (B2.Text == "")
                    return B2;
                if (A1.Text == "")
                    return A1;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
                if (C3.Text == "")
                    return C3;

                return null;
            }
            else if(level1 == "hard")
            {
                if (A1.Text == "X" && C3.Text == "X" || A3.Text == "X" && C1.Text == "X")
                {
                    if (A2.Text == "")
                        return A2;
                    if (B3.Text == "")
                        return B3;
                    if (B1.Text == "")
                        return B1;
                    if (C2.Text == "")
                        return C2;
                }
                if (A1.Text == "X" && C2.Text == "X")
                {
                    if (C1.Text == "")
                        return C1;
                }
                else if (A3.Text == "X" && C2.Text == "X")
                {
                    if (C3.Text == "")
                        return C3;
                }
                else if (A1.Text == "X" && B3.Text == "X")
                {
                    if (A3.Text == "")
                        return A3;
                }
                else if (C1.Text == "X" && B3.Text == "X")
                {
                    if (C3.Text == "")
                        return C3;
                }
                if (A1.Text == "O")
                {
                    if (A3.Text == "")
                        return A3;
                    if (C3.Text == "")
                        return C3;
                    if (C1.Text == "")
                        return C1;
                }

                if (A3.Text == "O")
                {
                    if (A1.Text == "")
                        return A1;
                    if (C3.Text == "")
                        return C3;
                    if (C1.Text == "")
                        return C1;
                }

                if (C1.Text == "O")
                {
                    if (A3.Text == "")
                        return A3;
                    if (C3.Text == "")
                        return C3;
                    if (A1.Text == "")
                        return A1;
                }

                if (C3.Text == "O")
                {
                    if (A3.Text == "")
                        return A3;
                    if (C1.Text == "")
                        return C1;
                    if (A1.Text == "")
                        return A1;
                }

                if (B2.Text == "")
                    return B2;
                if (A1.Text == "")
                    return A1;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
                if (C3.Text == "")
                    return C3;

                return null;
            }
            else
            {
                if (A1.Text == "O")
                {
                    if (A3.Text == "")
                        return A3;
                    if (C3.Text == "")
                        return C3;
                    if (C1.Text == "")
                        return C1;
                }

                if (A3.Text == "O")
                {
                    if (A1.Text == "")
                        return A1;
                    if (C3.Text == "")
                        return C3;
                    if (C1.Text == "")
                        return C1;
                }

                if (C1.Text == "O")
                {
                    if (A3.Text == "")
                        return A3;
                    if (C3.Text == "")
                        return C3;
                    if (A1.Text == "")
                        return A1;
                }

                if (C3.Text == "O")
                {
                    if (A3.Text == "")
                        return A3;
                    if (C1.Text == "")
                        return C1;
                    if (A1.Text == "")
                        return A1;
                }

                if (B2.Text == "")
                    return B2;
                if (A1.Text == "")
                    return A1;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
                if (C3.Text == "")
                    return C3;

                return null;
            }
        }

        private Button look_for_open_space()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }//end if
            }

            return null;
        }

        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            //horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;


            //vertical checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            //diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == B2.Text) && (B2.Text == A3.Text) && (!C1.Enabled))
                there_is_a_winner = true;


            if (there_is_a_winner)
            {
                disableButton();
                player1 = p1.Text;
                player2 = p2.Text;
                String winner = "";
                if (turn)
                {
                    winner = player2;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                    progressBar2.Value = progressBar2.Value + 10;
                    player2_win++;
                    if (player2_win == 10)
                    {
                        reset();
                        progressBar2.Value = 0;
                    }
                }
                else
                {
                    winner = player1;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                    progressBar1.Value = progressBar1.Value + 10;
                    player1_win++;
                    if (player1_win == 10)
                    {
                        reset();
                        progressBar1.Value = 0;
                    }
                }

                Form5.setPlayerName(winner);
                
                Form5 f5 = new Form5();
                f5.ShowDialog();
                
                
                newGame();

            }//end of if
            else
            {
                if (turn_count == 9)
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    progressBar3.Value = progressBar3.Value + 10;
                    player3_win++;
                    if (player3_win == 10)
                    {
                        reset();
                        progressBar3.Value = 0;
                    }
                    MessageBox.Show("Draw!", "Bummer");
                    newGame();
                }
            }
        }//end of checkForWiner

        private void Form1_Load(object sender, EventArgs e)
        {

            setPlayerDefaultToolStripMenuItem.PerformClick();
            helpProvider1 = new System.Windows.Forms.HelpProvider();
            helpProvider1.SetShowHelp(p1, true);
            helpProvider1.SetHelpString(p1, "Enter player1 name");
            helpProvider1.SetShowHelp(p2, true);
            helpProvider1.SetHelpString(p2, "Enter player2 name OR If you want to play with computer then write on textbox 'computer'." );

        }

        private void setPlayerDefaultToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            p1.Text = "Satya";
            p2.Text = "Computer";
        }

        private void p2_TextChanged(object sender, EventArgs e)
        {
            if (p2.Text.ToUpper() == "COMPUTER")
                against_computer = true;
            else
                against_computer = false;
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                }//end of try
                catch { }
            }//end of foreach
        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }//end of try
                catch { }
            }//end of foreach
        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";

            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";

            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setPlayerDefaultsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            p1.Text = "Satya";
            p2.Text = "Computer";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button_enter(object sender, EventArgs e)
        {            
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }//end of if
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }//end of if
        }

        private void aboutUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (p2.Text == "Computer")
            {
                Form7 f7 = new Form7();
                f7.ShowDialog();
            }
            else
            {
                button1.Enabled = false;
            }
            
        }

        private void disableButton()
        {

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }//end of try
                catch { }
            }//end of foreach
        }

        private void levelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (p2.Text == "Computer")
            {
                Form7 f7 = new Form7();
                f7.ShowDialog();
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void levelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (p2.Text == "Computer")
            {
                Form7 f7 = new Form7();
                f7.ShowDialog();
            }
            else
            {
                button1.Enabled = false;
            }
        }

       

        private void reset()
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";
        }

        private void newGame()
        {
            turn = true;
            turn_count = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }//end of try
                catch { }
            }//end of foreach

        }
        public static void level(String n1)
        {
            level1 = n1;
        }
    }
}