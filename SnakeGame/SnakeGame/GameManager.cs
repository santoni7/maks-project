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

        private List<Cell> snake;
        private List<FoodCell> food;
        private HashSet<WallCell> walls;
        private Point direction;
        private GameState state;
        private Cell deleted;

        int width_c;//canvas size
        int height_c;

        int width;
        int height;

        const int cellW = 25;
        const int cellH = 25;

        public GameManager(int canvas_width, int canvas_height)
        {
            UpdateCanvasSize(canvas_width, canvas_height);

            snake = new List<Cell>();
            food = new List<FoodCell>();
            walls = new HashSet<WallCell>();

            state = GameState.Play;

            snake.Add(new Cell(width / 2 - 1, height / 2));
            snake.Add(new Cell(width / 2 - 2, height / 2));
            snake.Add(new Cell(width / 2 - 3, height / 2));
            snake.Add(new Cell(width / 2 - 4, height / 2));
            snake.Add(new Cell(width / 2 - 5, height / 2));

            deleted = null;
            direction = new Point(1, 0);
        }

        public void Update(Point direction, bool pauseChange)
        {
            if (!Oposite(this.direction, direction))
                this.direction = direction;
            deleted = new Cell(snake.Last().position);
            Cell next = new Cell(snake.Last().position);
            Cell head = snake.First();
            next.position = new Point(head.position.X + this.direction.X, head.position.Y + this.direction.Y);
            next = Bounding(next);
            
            if (walls.Contains(next))
            {
                state = GameState.GameOver;
            }
            if (food.Contains(next))
            {
                snake.Add(snake.Last());
            }
            if (snake.Take(snake.Count - 1).Contains(next))
            {
                state = GameState.GameOver;
            }
            if (pauseChange)
            {
                if (state == GameState.Play)
                    state = GameState.Pause;
                else if (state == GameState.Pause)
                    state = GameState.Play;
            }
            if (state == GameState.Play)
            {
                snake.RemoveAt(snake.Count - 1);
                snake.Insert(0,next);
            }
            
        }
        public void Draw(Graphics canvas)
        {
            Brush br = Brushes.White;
            Pen p = Pens.Gray;
            if (deleted != null)
            {
                canvas.FillRectangle(Brushes.White, deleted.position.X * cellW,
                    deleted.position.Y * cellH, cellW, cellH);
                canvas.DrawRectangle(p, deleted.position.X * cellW,
                    deleted.position.Y * cellH, cellW, cellH);
            }
            
            foreach (Cell c in snake)
            {
                Point drawPosition = new Point(c.position.X * cellW, c.position.Y * cellH);
                Brush b = new SolidBrush(Color.DarkGray);
                canvas.FillRectangle(b, drawPosition.X, drawPosition.Y, cellW, cellH);
                canvas.DrawRectangle(Pens.Gray, drawPosition.X, drawPosition.Y, cellW, cellH);
            }
        }

        public void DrawMap(Graphics canvas)
        {
            Pen p = Pens.Gray;
            for (int px = 0; px + cellW < width_c; px += cellW)
            {
                for (int py = 0; py + cellH < height_c; py += cellH)
                {
                    canvas.DrawRectangle(p, new Rectangle(px, py, cellW, cellH));
                }
            }
        }

        private bool Oposite(Point dir1, Point dir2)
        {
            if (dir1.X + dir2.X == 0 && dir1.Y == 0)
                return true;
            if (dir1.Y + dir2.Y == 0 && dir1.X == 0)
                return true;
            return false;
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
            if (cell.position.X > width - 1)
                cell.position.X = 0;
            if (cell.position.X < 0)
                cell.position.X = width - 1;
            if (cell.position.Y > height - 1)
                cell.position.Y = 0;
            if (cell.position.Y < 0)
                cell.position.Y = height - 1;
            return cell;
        }

        private void CreateFood()
        {
            Random rand = new Random();
            Cell position = new Cell(rand.Next(width), rand.Next(height));
            while (walls.Contains(position) || food.Contains(position) || snake.Contains(position))
                position = new Cell(rand.Next(width), rand.Next(height));
            food.Add((FoodCell)position);
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
            public override bool Equals(object obj)
            {
                return ((Cell)obj).position == this.position;
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
