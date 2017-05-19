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

        const int cellW = 50;
        const int cellH = 50;

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
            Pen p = Pens.Gray;
            for(int px = 0; px < width; px += cellW)
            {
                for(int py = 0; py < height; py += cellH)
                {
                    canvas.DrawRectangle(p, new Rectangle(px, py, cellW, cellH));
                }
            }
            foreach (Cell c in snake)
            {
                Point drawPosition = new Point(c.position.X * cellW, c.position.Y * cellH);
                canvas.FillRectangle(Brushes.Fuchsia, drawPosition.X, drawPosition.Y, cellW, cellH);
            }
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
