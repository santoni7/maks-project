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
        private List<Cell> food;
        private List<Cell> walls;
        private Point direction;
        private GameState state;
        private Cell deletedSnakePart;
        private int UpdateCount;

        int width_c;//canvas size
        int height_c;

        int width;
        int height;

        public const int cellW = 20;
        public const int cellH = 20;

        bool useWalls;

        public GameManager(int canvas_width, int canvas_height, bool useWalls)
        {
            this.useWalls = useWalls;
            UpdateCanvasSize(canvas_width, canvas_height);

            snake = new List<Cell>();
            food = new List<Cell>();
            walls = new List<Cell>();

            state = GameState.Play;

            snake.Add(new Cell(width / 2 - 1, height / 2));
            snake.Add(new Cell(width / 2 - 2, height / 2));
            snake.Add(new Cell(width / 2 - 3, height / 2));
            snake.Add(new Cell(width / 2 - 4, height / 2));
            snake.Add(new Cell(width / 2 - 5, height / 2));

            CreateFood();

            deletedSnakePart = null;
            direction = new Point(1, 0);
            UpdateCount = 0;
        }

        public void Update(Point direction, bool pauseChange)
        {
            UpdateCount++;
            if (!Oposite(this.direction, direction))
                this.direction = direction;
            deletedSnakePart = new Cell(snake.Last().position);
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
                food.Remove(next);
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
                if (UpdateCount % 20 == 0)
                    CreateFood();
            }
            else
            {
                deletedSnakePart = null;
            }           
        }

        public void Draw(Graphics canvas)
        {
            Brush br = Brushes.White;
            Pen p = Pens.Gray;
            if (deletedSnakePart != null)
            {
                canvas.FillRectangle(Brushes.White, deletedSnakePart.position.X * cellW,
                    deletedSnakePart.position.Y * cellH, cellW, cellH);
                canvas.DrawRectangle(p, deletedSnakePart.position.X * cellW,
                    deletedSnakePart.position.Y * cellH, cellW, cellH);
                deletedSnakePart = null;
            }

            DrawCells(canvas, food, Color.White, Properties.Resources.food);
            DrawCells(canvas, walls, Color.Black);
            DrawCells(canvas, snake, Color.DarkGray);
        }
        
        private void DrawCells(Graphics canvas, List<Cell> cells, Color color, Image image = null)
        {
            foreach (Cell c in cells)
            {
                Point drawPosition = new Point(c.position.X * cellW, c.position.Y * cellH);
                if (image != null)
                    canvas.DrawImage(image, drawPosition.X, drawPosition.Y, cellW, cellH);
                else
                {
                    Brush b = new SolidBrush(color);
                    canvas.FillRectangle(b, drawPosition.X, drawPosition.Y, cellW, cellH);
                    canvas.DrawRectangle(Pens.Gray, drawPosition.X, drawPosition.Y, cellW, cellH);
                }
            }
        }

        public void DrawMap(Graphics canvas)
        {
            Pen p = Pens.Gray;
            for (int px = 0; px + cellW <= width_c; px += cellW)
            {
                for (int py = 0; py + cellH <= height_c; py += cellH)
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
            food.Add(position);
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
    }
}
