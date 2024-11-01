using Microsoft.VisualBasic.Logging;
using System.Globalization;

namespace Pong
{
    public partial class Form1 : Form
    {
        int ballX = 10; 
        int ballY = 10; 
        int playerSpeed = 10; 
        int aiSpeed = 6; 
        int scorePlayer = 0; 
        int scoreAI = 0;

        private int Pallete;
        private int kulka;

        public Form1(int pallete, int ball)
        {
            kulka = ball;
            Pallete = pallete;

            if(kulka > 2 && pallete > 0)
            {
                ballX = kulka;
                ballY = kulka;
                aiSpeed = pallete;
            }
            else {
                ballX = 5;
                ballY = 5;
                aiSpeed = 6;
            }

            InitializeComponent();
            gameTimer.Start();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.W && Paddle1.Top > 0)
            {
                Paddle1.Top -= playerSpeed;
            }
            if (e.KeyCode == Keys.S && Paddle1.Bottom < ClientSize.Height)
            {
                Paddle1.Top += playerSpeed;
            }
        }

        int xd = 0;





        private Random rnd = new Random();
        private int aiDelayCounter = 0; 
        private int aiDelay = 0; 




        private void gameTimer_Tick(object sender, EventArgs e)
        {

            if(scorePlayer == 3 || scoreAI == 3)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                gameTimer.Enabled = false;

                zapisywanie();


            }

            label2.Text = scorePlayer.ToString();
            label3.Text = scoreAI.ToString();

            Ball.Left += ballX;
            Ball.Top += ballY;

      
            aiDelayCounter++;

  
            if (aiDelayCounter >= 60) 
            {
                aiDelay = rnd.Next(10, 15);
                aiDelayCounter = 0; 
            }

           
            if (aiDelay > 0)
            {
                aiDelay--; 
            }
            else
            {
                if (Ball.Top < Paddle2.Top && Paddle2.Top > 0)
                {
                    Paddle2.Top -= aiSpeed; 
                }
                else if (Ball.Bottom > Paddle2.Bottom && Paddle2.Bottom < ClientSize.Height)
                {
                    Paddle2.Top += aiSpeed; 
                }
            }

         
            if (Ball.Top <= 0 || Ball.Bottom >= ClientSize.Height)
            {
                ballY = -ballY;
            }

            if (Ball.Bounds.IntersectsWith(Paddle1.Bounds) || Ball.Bounds.IntersectsWith(Paddle2.Bounds))
            {
                ballX = -ballX;
            }

            if (Ball.Left <= 0)
            {
                scoreAI++;
                ResetBall();
            }

            if (Ball.Right >= ClientSize.Width)
            {
                scorePlayer++;
                ResetBall();
            }
        }

        private void ResetBall()
        {
            Ball.Left = (ClientSize.Width / 2) - (Ball.Width / 2); 
            Ball.Top = (ClientSize.Height / 2) - (Ball.Height / 2);
            ballX = -ballX; 
        }

        void zapisywanie()
        {
            var plik = new StreamWriter("wyniki.txt", true);
            plik.WriteLine($"{scorePlayer}:{scoreAI}:{DateTime.Now.ToBinary()}");
            plik.Close();
        }




    }
}
