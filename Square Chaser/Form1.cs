using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace Square_Chaser
{
    public partial class game : Form
    {
        //Global variables

        //drawing
        Rectangle player1 = new Rectangle(50, 170, 40, 40);
        Rectangle player2 = new Rectangle(290, 170, 40, 40);


        Rectangle pointy = new Rectangle(180, 185, 12, 2);
        Rectangle pointx = new Rectangle(185, 180, 2, 12);
        Rectangle speedboost = new Rectangle(185, 300, 12, 12);

        Pen bluepen = new Pen(Color.White);

        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush YellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush FuchsiaBrush = new SolidBrush(Color.Fuchsia);
        SolidBrush darkredBrush = new SolidBrush(Color.DarkRed);


        //player info
        int player1Speed = 5;
        int player2Speed = 5;

        int player1Score = 0;
        int player2Score = 0;

        //soundPlayer
        SoundPlayer soundPlayer = new SoundPlayer();


        //ball location
        Random readomnum = new Random();

        //key input
        bool wPressed = false;
        bool sPressed = false;
        bool dPressed = false;
        bool aPressed = false;

        bool upPressed = false;
        bool downPressed = false;
        bool leftPressed = false;
        bool rightPressed = false;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;

                case Keys.Left:
                    leftPressed = false;
                    break;
                case Keys.Right:
                    rightPressed = false;
                    break;
                case Keys.Down:
                    downPressed = false;
                    break;
                case Keys.Up:
                    upPressed = false;
                    break;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;


                case Keys.Left:
                    leftPressed = true;
                    break;
                case Keys.Right:
                    rightPressed = true;
                    break;
                case Keys.Down:
                    downPressed = true;
                    break;
                case Keys.Up:
                    upPressed = true;
                    break;
            }

        }

        //game timer
        private void gameTimer_Tick_1(object sender, EventArgs e)
        {

            //Move player 1
            if (wPressed == true && player1.Y > 0)
            {
                player1.Y -= player1Speed;
            }

            if (sPressed == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += player1Speed;
            }

            if (dPressed == true && player1.X < this.Width - player1.Width)
            {
                player1.X += player1Speed;
            }

            if (aPressed == true && player1.X < this.Width - player1.Width)
            {
                player1.X -= player1Speed;
            }

            //Move player 2
            if (upPressed == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
            }

            if (downPressed == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += player2Speed;
            }

            if (leftPressed == true && player2.X < this.Width - player2.Width)
            {
                player2.X -= player2Speed;
            }

            if (rightPressed == true && player2.X < this.Width - player2.Width)
            {
                player2.X += player2Speed;
            }

            //right wall
            if (player1.X > 330)
            {
                player1.X = 329;
            }
            if (player2.X > 330)
            {
                player2.X = 329;
            }
            //left wall
            if (player1.X < 15)
            {
                player1.X = 16;
            }
            if (player2.X < 15)
            {
                player2.X = 16;
            }
            //top wall
            if (player1.Y < 15)
            {
                player1.Y = 16;
            }
            if (player2.Y < 15)
            {
                player2.Y = 16;
            }
            //bottom wall
            if (player1.Y > 330)
            {
                player1.Y = 329;
            }
            if (player2.Y > 330)
            {
                player2.Y = 329;
            }

            //points
            if (player1.IntersectsWith(pointy))
            {
                pointy.X = readomnum.Next(15, 350);
                pointy.Y = readomnum.Next(15, 350);
                pointx.X = pointy.X + 5;
                pointx.Y = pointy.Y - 5;

                soundPlayer = new SoundPlayer(Properties.Resources.experimental_8_bit_sound_270302);
                soundPlayer.Play();
                player1Score++;
            }
            else if (player2.IntersectsWith(pointy))
            {
                pointy.X = readomnum.Next(15, 350);
                pointy.Y = readomnum.Next(15, 350);
                pointx.X = pointy.X + 5;
                pointx.Y = pointy.Y - 5;


                soundPlayer = new SoundPlayer(Properties.Resources.experimental_8_bit_sound_270302);
                soundPlayer.Play();
                player2Score++;
            }

            if (player1.IntersectsWith(speedboost))
            {
                speedboost.X = readomnum.Next(15, 350);
                speedboost.Y = readomnum.Next(15, 350);
                speedboost.X = speedboost.X + 5;
                speedboost.Y = speedboost.Y - 5;

                soundPlayer = new SoundPlayer(Properties.Resources._8_bit_game_sfx_sound_21_269970);
                soundPlayer.Play();
                player1Speed = 4 + 2;
                speedtime.Enabled = true;
            }
            else if (player2.IntersectsWith(speedboost))
            {

                speedboost.X = readomnum.Next(15, 350);
                speedboost.Y = readomnum.Next(15, 350);
                speedboost.X = speedboost.X + 5;
                speedboost.Y = speedboost.Y - 5;

                soundPlayer = new SoundPlayer(Properties.Resources._8_bit_game_sfx_sound_21_269970);
                soundPlayer.Play();
                player1Speed = 4 + 2;
                speedtime.Enabled = true;
            }

            Refresh();

            if (player1Score == 5)
            {
                gameTimer.Stop();
            }
            if (player2Score == 5)
            {
                gameTimer.Stop();
            }
        }

        public game()
        {
            InitializeComponent();

            pointy.X = readomnum.Next(15, 350);
            pointy.Y = readomnum.Next(15, 350);
            pointx.X = pointy.X + 5;
            pointx.Y = pointy.Y - 5;

            speedboost.X = readomnum.Next(15, 350);
            speedboost.Y = readomnum.Next(15, 350);


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //points
            this.Text = $"player1: {player1Score}                            player2: {player2Score}";

            if (player1Score == 5)
            {
                this.Text = $"player1 wins";
                soundPlayer = new SoundPlayer(Properties.Resources.gamestart_272829);
                soundPlayer.Play();
            }

            if (player2Score == 5)
            {
                this.Text = $"player2 wins";
                soundPlayer = new SoundPlayer(Properties.Resources.gamestart_272829);
                soundPlayer.Play();
            }

            //drawing 
            e.Graphics.FillRectangle(redBrush, player1);
            e.Graphics.FillRectangle(darkredBrush, player2);
            e.Graphics.FillRectangle(YellowBrush, pointy);
            e.Graphics.FillEllipse(FuchsiaBrush, speedboost);
            e.Graphics.FillRectangle(YellowBrush, pointx);
            e.Graphics.DrawRectangle(bluepen, 15, 15, 350, 350);
        }

        private void speedtime_Tick(object sender, EventArgs e)
        {
            speedtime.Enabled = false;

            player1Speed = 4;
            player2Speed = 4;
        }

        private void game_Load(object sender, EventArgs e)
        {

        }
    }
}
