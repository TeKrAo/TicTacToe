using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace TicTacToe2
{
    public partial class Form1 : Form
    {
        private char[,] board;
        private char currentPlayer;
        private bool gameEnded;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            board = new char[3, 3];
            currentPlayer = 'X';
            gameEnded = false;
            ClearBoard();
        }

        private void ClearBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                    Controls("button" + (row * 3 + col + 1), true)[0].Text = "_";
                }
            }
        }

        private bool CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return true;
                if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return true;
            }
            if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return true;
            if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return true;

            return false;
        }

        private bool CheckDraw()
        {
            foreach (char cell in board)
            {
                if (cell == ' ')
                    return false;
            }
            return true;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (gameEnded) return;

            Button button = (Button)sender;
            int index = int.Parse(button.Name.Substring(6)) - 1;
            int row = index / 3;
            int col = index % 3;

            if (board[row, col] == ' ')
            {
                board[row, col] = currentPlayer;
                button.Text = currentPlayer.ToString();

                if (CheckWin())
                {
                    label1.Text = currentPlayer + " wins!";
                    gameEnded = true;
                }
                else if (CheckDraw())
                {
                    label1.Text = "It's a draw!";
                    gameEnded = true;
                }
                else
                {
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}

