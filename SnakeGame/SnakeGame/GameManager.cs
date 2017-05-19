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

        int width;
        int height;

        public GameManager(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Update(Point direction, bool pauseChange)
        {
            this.direction = direction;
            Cell next = snake.Peek();
            next.position.Offset(direction);
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
            
            throw new NotImplementedException();
        }
        public void Draw(int dt, Graphics canvas)
        {

        }

        private Cell Bounding(Cell cell)
        {
            if (cell.position.X > width)
                cell.position.X = 0;
            if (cell.position.X < width)
                cell.position.X = width;
            if (cell.position.Y > height)
                cell.position.Y = 0;
            if (cell.position.Y < height)
                cell.position.Y = height;
            return cell;
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
