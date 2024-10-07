namespace Pong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Paddle1 = new Panel();
            Paddle2 = new Panel();
            Ball = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            SuspendLayout();
            // 
            // Paddle1
            // 
            Paddle1.BackColor = SystemColors.ActiveCaptionText;
            Paddle1.Location = new Point(12, 236);
            Paddle1.Name = "Paddle1";
            Paddle1.Size = new Size(10, 100);
            Paddle1.TabIndex = 0;
            // 
            // Paddle2
            // 
            Paddle2.BackColor = SystemColors.ActiveCaptionText;
            Paddle2.Location = new Point(762, 236);
            Paddle2.Name = "Paddle2";
            Paddle2.Size = new Size(10, 100);
            Paddle2.TabIndex = 1;
            // 
            // Ball
            // 
            Ball.BackColor = SystemColors.ActiveCaptionText;
            Ball.Location = new Point(383, 271);
            Ball.Name = "Ball";
            Ball.Size = new Size(20, 20);
            Ball.TabIndex = 2;
            Ball.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 29);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 65);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(710, 65);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Ball);
            Controls.Add(Paddle2);
            Controls.Add(Paddle1);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Paddle1;
        private Panel Paddle2;
        private PictureBox Ball;
        private System.Windows.Forms.Timer gameTimer;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
