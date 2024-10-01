namespace Pong
{
    public partial class Form1 : Form
    {
        int ballX = 5; // prêdkoœæ pi³ki w osi X
        int ballY = 5; // prêdkoœæ pi³ki w osi Y
        int playerSpeed = 10; // prêdkoœæ paddle gracza
        int aiSpeed = 5; // prêdkoœæ paddle AI
        int scorePlayer = 0; // wynik gracza
        int scoreAI = 0; 

        public Form1()
        {
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



        Random rnd = new Random();




        private void gameTimer_Tick(object sender, EventArgs e)
        {

            label2.Text = scorePlayer.ToString();

            label3.Text = scoreAI.ToString();    


            xd += 1;
            


            Ball.Left += ballX;
            Ball.Top += ballY;

            Paddle2.Top = Ball.Top - rnd.Next(1, 100);
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





    }
}
