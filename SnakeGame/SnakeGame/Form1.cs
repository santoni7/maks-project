using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        GameManager game;
        public Form1()
        {
            InitializeComponent();
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
