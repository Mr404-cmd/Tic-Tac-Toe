using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int player = 2;//even x turn; odd o turn
        public int turns = 0;//counting turn;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;//counting win for player;
        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }
                if (CheckDraw() == true)
                {
                    MessageBox.Show("Game Tie");
                    sd++;
                    NewGame();
                }
                if (CheckWinner() == true)
                {

                    if (button.Text == "X")
                    {
                        MessageBox.Show("X Won");

                        s1++;
                        NewGame();
                    }

                    else
                    {
                        if (button.Text == "O")
                        {
                            MessageBox.Show("O Won");
                            s2++;
                            NewGame();
                        }
                    }
                }
                
            }
        }




        private void Ebutton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Xwin.Text = "X: " + s1;
            Owin.Text = "O: " + s2;
            Draws.Text = "Draw : " + sd;
        }

        private void NewGame()
        {
            player = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            Xwin.Text = "X: " + s1;
            Owin.Text = "O: " + s2;
            Draws.Text = "Draw : " + sd;
        }

        private void Ngbutton_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        public bool CheckDraw()
        {
            if ((turns == 9) && CheckWinner() == false)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool CheckWinner()
        {
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && A00.Text != "")
            {
                return true;
            }
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && A10.Text != "")
            {
                return true;
            }
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "")
            {
                return true;
            }
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && A00.Text != "")
            {
                return true;
            }
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
            {
                return true;
            }
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
            {
                return true;
            }
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && A00.Text != "")
            {
                return true;
            }
            else if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && A02.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
