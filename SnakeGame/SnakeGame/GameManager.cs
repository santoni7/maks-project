﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class GameManager
    {
        private List<Cell> snake;
        private List<FoodCell> food;
        private HashSet<WallCell> walls;

        public void Update(int dt)
        {
            // TODO
            throw new NotImplementedException();
        }
        public void Draw(int dt, Graphics canvas)
        {
            // TODO
            throw new NotImplementedException();
        }


        class Cell
        {
            Point position;
            // ...
        }
        class FoodCell : Cell
        {

        }
        class WallCell : Cell
        {

        }
    }
}
