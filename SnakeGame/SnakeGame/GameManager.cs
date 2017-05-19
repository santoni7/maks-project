using System;
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

        int width;
        int height;

        public GameManager(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Update(int dt)
        {
            // TODO
            throw new NotImplementedException();
        }
        public void Draw(int dt, Graphics canvas)
        {

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
