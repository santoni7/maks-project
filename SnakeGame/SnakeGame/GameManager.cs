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
        enum GameState { Pause, Play, GameOver}

        private Queue<Cell> snake;
        private List<FoodCell> food;
        private HashSet<WallCell> walls;
        private Point direction;
        private GameState state;

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

            state = GameState.Play;    

            snake.Enqueue(new Cell(width / 2 - 4, height / 2));
            snake.Enqueue(new Cell(width / 2 - 3, height / 2));
            snake.Enqueue(new Cell(width / 2 - 2, height / 2));
            snake.Enqueue(new Cell(width / 2 - 1, height / 2));
        }

        public void Update(Point direction, bool pauseChange)
        {
            this.direction = direction;
            Cell next = snake.Peek();
            next.position = new Point(next.position.X + direction.X, next.position.Y + direction.Y);
            next = Bounding(next);
            
            if (walls.Contains(next))
            {
                state = GameState.GameOver;
            }
            if (food.Contains(next))
            {
                snake.Enqueue(snake.Peek());
            }
            if (pauseChange)
            {
                if (state == GameState.Play)
                    state = GameState.Pause;
                if (state == GameState.Pause)
                    state = GameState.Play;
            }
            if (state == GameState.Play)
            {
                var el = snake.Dequeue();
                el.position = next.position;
                snake.Enqueue(el);
            }
            
        }
        public void Draw(Graphics canvas)
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
                canvas.DrawRectangle(Pens.Gray, drawPosition.X, drawPosition.Y, cellW, cellH);
            }
        }
        public void UpdateCanvasSize(int width, int height)
        { 
            this.width_c = width;
            this.height_c = height;

            this.width = width / cellW;
            this.height = height / cellH;
        }

        private Cell Bounding(Cell cell)
        {
            if (cell.position.X > width)
                cell.position.X = 0;
            if (cell.position.X < 0)
                cell.position.X = width;
            if (cell.position.Y > height)
                cell.position.Y = 0;
            if (cell.position.Y < 0)
                cell.position.Y = height;
            return cell;
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
