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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartGame(float sp)
        {
            Form1 form = new Form1(this, sp);
            form.Show(this);
            this.Hide();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }
        
        private void playFastBtn_Click(object sender, EventArgs e)
        {
            StartGame(3);
        }

        private void playFastestBtn_Click(object sender, EventArgs e)
        {
            StartGame(5);
        }
    }
}
