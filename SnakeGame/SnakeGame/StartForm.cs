﻿using System;
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

        private void StartGame(float sp, int w, int h)
        {
            Form1 form = new Form1(this, sp, w, h);
            form.Show(this);
            this.Hide();
        }

        private void playBtn_Click(object sender, EventArgs e)
        { 
            float speed = 1;
            Size sz = new Size(10, 10);

            
            if (radioButton1.Checked) speed = 1;
            else if (radioButton2.Checked) speed = 3;
            else if (radioButton3.Checked) speed = 6;
            else speed = 10;
    
            if(rbSize1.Checked) { sz = new Size(16, 16); }
            else if(rbSize2.Checked) { sz = new Size(32, 32); }
            StartGame(speed, sz.Width, sz.Height);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            FormHelp help = new FormHelp();
            help.ShowDialog(this);
        }
    }
}
