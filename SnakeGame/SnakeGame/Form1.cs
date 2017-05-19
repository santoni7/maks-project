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
            game = new GameManager(pictureBox1.Width, pictureBox1.Height);
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
        }

        DateTime _lastDraw;
        DateTime _lastUpdate;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int dt = (DateTime.Now - _lastDraw).Milliseconds;
            game.Draw(dt, e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Update(0);
            pictureBox1.Refresh();
        }
    }
}
