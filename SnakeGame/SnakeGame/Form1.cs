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
        bool spaceKey = false;
        

        GameManager game;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.PreviewKeyDown += PictureBox1_PreviewKeyDown;
        }

        private void PictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var key = e.KeyCode;
            if (keyDirs.Contains(key))
            {
                switch (key)
                {
                    case Keys.Up:
                        direction = new Point(0, 1);
                        break;
                    case Keys.Down:
                        direction = new Point(0, -1);
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

        DateTime _lastDraw;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int dt = 0;
            game.Draw(dt, e.Graphics);
        }
    }
}
