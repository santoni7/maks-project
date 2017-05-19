using System;
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
        SortedSet<Keys> keyDirs = new SortedSet<Keys>() { Keys.Down, Keys.Up, Keys.Left, Keys.Right };
        Point direction = new Point(1, 0);
        bool spaceKey = false, mapDraw = true;
        

        GameManager game;
        public Form1()
        {
            InitializeComponent();
            game = new GameManager(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.BackColor = Color.White;
        }
        
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            var key = e.KeyCode;
            if (keyDirs.Contains(key))
            {
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
                }
                return;
            }
            if (key == Keys.Space)
                spaceKey = true;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Update(direction, spaceKey);
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            if (game != null)
            {
                game.UpdateCanvasSize(pictureBox1.Width, pictureBox1.Height);                
            }
            mapDraw = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //pictureBox1.Refresh();
            game.Draw(pictureBox1.CreateGraphics());
        }
    }
}
