using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Advanced.Ariel.SnakeExercsie
{
    public class Board
    {
        public int Width { get; set; }
        public int Height { get; set; }
      
        private List<Shape> _shapes;
        private Snake _lastSnake;


        public void Init()
        {
            Console.SetWindowSize(Width, Height);
            _shapes = new List<Shape>();
        }
        public bool IsOverLap(Shape newShape)
        {
            foreach (var shape in _shapes)
            {
                if (shape.IsOverlap(newShape))
                {
                    return true;
                }
            }
            return false;
        }
        public bool AddShape(Shape shape)
        {
            if (!IsOverLap(shape))
            {
                _shapes.Add(shape);
                shape.Draw();
                return true;
            }
            return false;
        }
        public bool AddNewSnake(Snake snake)
        {
            if (AddShape(snake))
            {

                ChangOldSnakeColor();
                _lastSnake = snake;
                return true;
            }
            return false;
        }

        private void ChangOldSnakeColor()
        {
            if (_lastSnake != null)
            {
                _lastSnake.DrawOldSnake();
            }
        }

        public void Reset()
        {
            _lastSnake = null;
            var snakes = _shapes.Where(s => s is Snake);
            foreach (var snake in snakes)
            {
                snake.Delete();
            }
            _shapes.RemoveAll(s => s is Snake);

        }
        public int NumOfShaps()
        {
            return _shapes.Where(s => s is not Snake).Count();
        }

      

    }
}
