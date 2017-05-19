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
        private Queue<Cell> snake;
        private List<FoodCell> food;
        private HashSet<WallCell> walls;
        private Point direction;

        int width;
        int height;

        public GameManager(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Update(Point direction)
        {
            this.direction = direction;
            Cell next = snake.Peek();
            next.position.Offset(direction);
            if (walls.Contains(next))
            
            throw new NotImplementedException();
        }
        public void Draw(int dt, Graphics canvas)
        {

        }


        class Cell
        {
            public Point position;
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
