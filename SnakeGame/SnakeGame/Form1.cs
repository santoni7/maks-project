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
        enum Dirs { Up, Down, Left, Right};
        Dirs direction = Dirs.Right;
        

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
                        direction = Dirs.Up;
                        break;
                    case Keys.Down:
                        direction = Dirs.Down;
                        break;
                    case Keys.Left:
                        direction = Dirs.Left;
                        break;
                    case Keys.Right:
                        direction = Dirs.Right;
                        break;
                }
            }
            
            game = new GameManager();
        }

        DateTime _lastDraw;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int dt = 0;
            game.Draw(dt, e.Graphics);
        }
    }
}
