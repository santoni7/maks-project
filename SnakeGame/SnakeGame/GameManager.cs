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

        int width_c;//canvas size
        int height_c;

        int width;
        int height;

        const int cellW = 25;
        const int cellH = 25;

        public GameManager(int canvas_width, int canvas_height)
        {
            UpdateCanvasSize(canvas_width, canvas_height);

            snake = new Queue<Cell>();
            food = new List<FoodCell>();
            walls = new HashSet<WallCell>();
                

            snake.Enqueue(new Cell(width / 2 - 4, height / 2));
            snake.Enqueue(new Cell(width / 2 - 3, height / 2));
            snake.Enqueue(new Cell(width / 2 - 2, height / 2));
            snake.Enqueue(new Cell(width / 2 - 1, height / 2));
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
            for(int px = 0; px + cellW < width_c; px += cellW)
            {
                for(int py = 0; py + cellH < height_c; py += cellH)
                {
                    canvas.DrawRectangle(p, new Rectangle(px, py, cellW, cellH));
                }
            }
            foreach (Cell c in snake)
            {
                Point drawPosition = new Point(c.position.X * cellW, c.position.Y * cellH);
                Brush b = new SolidBrush(Color.DarkGray);
                canvas.FillRectangle(b, drawPosition.X, drawPosition.Y, cellW, cellH);
            }
        }
        public void UpdateCanvasSize(int width, int height)
        { 
            this.width_c = width;
            this.height_c = height;

            this.width = width / cellW;
            this.height = height / cellH;
        }

        class Cell
        {
            public Point position;
            public Cell()
            {

            }
            public Cell(Point position)
            {
                this.position = position;
            }
            public Cell(int x, int y)
            {
                this.position = new Point(x, y);
            }
        }
        class FoodCell : Cell
        {

        }
        class WallCell : Cell
        {

        }
    }
}
