using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        stGameStatus GameStatus;
        enPlayerTurn PlayerTurn = enPlayerTurn.Player1;

        public enum enPlayerTurn
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }

        private void PrintGame(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen Pen = new Pen(White);
            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 400, 200, 800, 200);
            e.Graphics.DrawLine(Pen, 400, 300, 800, 300);
            e.Graphics.DrawLine(Pen, 530, 100, 530, 400);
            e.Graphics.DrawLine(Pen, 660, 100, 660, 400);
        }

        void StopButtons()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        void EndGame()
        {

            laPlayerTurn.Text = "Game Over";
            switch (GameStatus.Winner)
            {

                case enWinner.Player1:

                    laWinner.Text = "Player1";
                    break;

                case enWinner.Player2:

                    laWinner.Text = "Player2";
                    break;

                default:

                    laWinner.Text = "Draw";
                    break;

            }

            StopButtons();
            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

            bool CheckValues(Button Value1, Button Value2, Button Value3)
        {
            if (Value1.Tag.ToString() != "?" && Value1.Tag.ToString() == Value2.Tag.ToString() && Value1.Tag.ToString() == Value3.Tag.ToString())
            {
                Value1.BackColor = Color.GreenYellow;
                Value2.BackColor = Color.GreenYellow;
                Value3.BackColor = Color.GreenYellow;

                if (Value1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }

            GameStatus.GameOver = false;
            return false;
        }

        public void CheckWinner()
        {
            if (CheckValues(btn1, btn2, btn3))
                return;
            if(CheckValues(btn4 , btn5 , btn6))
                return;
            if (CheckValues(btn7 , btn8 , btn9))
                return;
            if (CheckValues(btn1 , btn4 , btn7))
                return;
            if (CheckValues(btn2 , btn5 , btn8))
                return;
            if (CheckValues(btn3, btn6, btn9))
                return;
            if (CheckValues(btn1 , btn5 , btn9))
                return;
            if (CheckValues(btn3 , btn5 , btn7))
                return;

        }

       public void ChangeImage(Button Btn)
        {
            if (Btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayerTurn.Player1:

                        Btn.Image = Properties.Resources.X;
                        PlayerTurn = enPlayerTurn.Player2;
                        laPlayerTurn.Text = "Player2";
                        Btn.Tag = "X";
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;

                    case enPlayerTurn.Player2:

                        Btn.Image = Properties.Resources.O;
                        PlayerTurn = enPlayerTurn.Player1;
                        laPlayerTurn.Text = "Player1";
                        Btn.Tag = "O";
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;


                }
            }
            else
            {
                MessageBox.Show("Wrong Choice! Please Select another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount == 9)
            {
                GameStatus.Winner = enWinner.Draw;
                GameStatus.GameOver = true;
                EndGame();
            }
        }

       private void RestartButton(Button button)
        {
            button.Enabled = true;
            button.BackColor = Color.Black;
            button.Image = Properties.Resources.question_mark_96;
            button.Tag = "?";
        }

        private void RestartGame()
        {
            RestartButton(btn1);
            RestartButton(btn2);
            RestartButton(btn3);
            RestartButton(btn4);
            RestartButton(btn5);
            RestartButton(btn6);
            RestartButton(btn7);
            RestartButton(btn8);
            RestartButton(btn9);

            PlayerTurn = enPlayerTurn.Player1;
            laPlayerTurn.Text = "Player1";
            GameStatus.PlayCount = 0;
            GameStatus.Winner = enWinner.GameInProgress;
            laWinner.Text = "In Progress";
        }

        private void Clicked_Boutton(object sender, EventArgs e)
        {
            ChangeImage(((Button)sender));
        }

        private void bRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
