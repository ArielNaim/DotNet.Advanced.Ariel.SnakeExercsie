using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Advanced.Ariel.SnakeExercsie
{
    public class Managament
    {
        private const int BoardWidth = 80;
        private const int BoardHeight = 25;
        private int _score { get; set; }
        public Board _board;
        private Location _lastSnakeLocation;

        public void Init()
        {
            _board = new Board { Width = BoardWidth, Height = BoardHeight };
            _board.Init();
            AddInitShapes();
            AddInitSnake();
            StartGame();
            GameOver(_score);
            
            
            
        }
        private void StartGame()
        {
            while (_board.NumOfShaps() < 15)
            {
                int score = 0;
                var keyInfo = Console.ReadKey();
                var newSnake = GetNewSnake(keyInfo);
                if (newSnake != null)
                {
                    var isSuccess = _board.AddNewSnake(newSnake);
                    if (isSuccess)
                    {
                        _lastSnakeLocation = newSnake.InitalLocation;
                        Score(score);
                    }
                    else
                    {
                        _board.Reset();

                        int numOfTrys = 0;
                        do
                        {
                            numOfTrys++;
                        }
                        while (!AddShape() && numOfTrys < 30);
                        AddInitSnake();
                    }
                }
            }
        }

        private Snake GetNewSnake(ConsoleKeyInfo keyInfo)
        {
            Location newLocation = GetNewSnakeLocation(keyInfo);
            if (newLocation == null)
            {
                return null;
            }
            Snake newSnake = new Snake();
            newSnake.SetShapeSize();
            newSnake.InitalLocation = newLocation;
            newSnake.SetLocations();
            return newSnake;
        }
        private Location GetNewSnakeLocation(ConsoleKeyInfo keyInfo)
        {
            Location newSnakeLocation = new Location();
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    newSnakeLocation.Top = _lastSnakeLocation.Top - 1;
                    newSnakeLocation.Left = _lastSnakeLocation.Left;
                    break;
                case ConsoleKey.DownArrow:
                    newSnakeLocation.Top = _lastSnakeLocation.Top + 1;
                    newSnakeLocation.Left = _lastSnakeLocation.Left;
                    break;
                case ConsoleKey.RightArrow:
                    newSnakeLocation.Top = _lastSnakeLocation.Top;
                    newSnakeLocation.Left = _lastSnakeLocation.Left + 1;
                    break;
                case ConsoleKey.LeftArrow:
                    newSnakeLocation.Top = _lastSnakeLocation.Top;
                    newSnakeLocation.Left = _lastSnakeLocation.Left - 1;
                    break;
                default: return null;

            }
            return newSnakeLocation;
        }
        private void AddInitSnake()
        {
            bool isSuccess = false;

            while (!isSuccess)
            {
                Snake snake = new Snake();
                snake.SetShapeSize();
                snake.SetRandomPosition(BoardWidth, BoardHeight);
                snake.SetLocations();
                isSuccess = _board.AddNewSnake(snake);
                _lastSnakeLocation = snake.InitalLocation;
            }

        }


        private void AddInitShapes()
        {
            int numOfShapes = Util.GetRandomNumber(3, 7);
            do
            {
                var isSuccess = AddShape();
                if (isSuccess) numOfShapes--;
            }
            while (numOfShapes > 0);

        }
        private bool AddShape()
        {
            Shape newShape = GetRandomShape();
            newShape.SetShapeSize();
            newShape.SetRandomPosition(BoardWidth, BoardHeight);
            newShape.SetLocations();
            return _board.AddShape(newShape);
        }

        public Shape GetRandomShape()
        {
            Shape[] shapes = new Shape[4]
            {
                new Line(),
                new Triangle(),
                new Square(),
                new Rectangle()
            };
            var shapeIndex = Util.GetRandomNumber(0, 4);
            return shapes[shapeIndex];
        }
        public int Score(int score)
        {
            _score = score;
            score++;
            return _score;
        }
        public void GameOver(int score)
        {
            Console.WriteLine($"Game Over your score is :", score);
        }


    }


}


