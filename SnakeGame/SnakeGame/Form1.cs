﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        Point direction = new Point(1, 0);
        bool spaceKey = false, mapDraw = true;
        

        GameManager game;
        Form parent;
        float gameSpeed = 1;
        public Form1(Form parent, float gameSpeed = 1, int width = 10, int height = 10, bool useWalls = false)
        {
            InitializeComponent();
            int w = width * GameManager.cellW + 1;
            int h = height * GameManager.cellH + 1;
            //pictureBox1.Width = w;
            //pictureBox1.Height = h;
            pictureBox1.ClientSize = new Size(w, h);
            Point margin = new Point(12, 12);
            pictureBox1.Location = margin;
            this.ClientSize = new Size(w + margin.X *2, h + margin.Y *2);
            game = new GameManager(w, h, useWalls, gameSpeed);
            pictureBox1.BackColor = Color.White;
            this.parent = parent;
            this.gameSpeed = gameSpeed;
            setGameSpeed(gameSpeed);
        }

        public void setGameSpeed(float gameSpeed)
        {
            const float defaultInterval = 200;
            timer1.Interval = (int) (defaultInterval / gameSpeed);
            timer2.Interval = timer1.Interval / 2;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            var key = e.KeyCode;
            switch (key)
            {
                case Keys.Up:
                    direction = new Point(0, -1);
                    break;
                case Keys.Down:
                    direction = new Point(0, 1);
                    break;
                case Keys.Left:
                    direction = new Point(-1, 0);
                    break;
                case Keys.Right:
                    direction = new Point(1, 0);
                    break;
                case Keys.Space:
                    spaceKey = true;
                    break;
            }
        }
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (mapDraw)
            {
                game.DrawMap(e.Graphics);
                mapDraw = false;
            }
            game.Draw(e.Graphics);
        }

        private void onGameOver()
        {
            game.State = GameManager.GameState.Pause;
            DialogResult res = MessageBox.Show("Your score: " + game.Score, "Game over!");
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(game.State == GameManager.GameState.GameOver)
            {
                onGameOver();
            }
            else
            {
                game.Update(direction, spaceKey);
            }
            spaceKey = false;
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            if (game != null)
            {
                game.UpdateCanvasSize(pictureBox1.Width, pictureBox1.Height);                
            }
            mapDraw = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //pictureBox1.Refresh();
            game.Draw(pictureBox1.CreateGraphics());
        }
        
    }
}
