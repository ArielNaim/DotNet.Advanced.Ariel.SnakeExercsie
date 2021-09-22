using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Advanced.Ariel.SnakeExercsie
{
    public abstract class Shape
    {

        public int Width { get; set; }
        public int Length { get; set; }
        
        public Location InitalLocation { get; set; }
       
        public List<Location> locations = new List<Location>();

        public abstract char DisplayChar { get; }

        public void SetRandomPosition(int boardWidth, int boardHeight)
        {
            InitalLocation = new Location();
            InitalLocation.Top = Util.GetRandomNumber(0, boardHeight - Width);
            InitalLocation.Left = Util.GetRandomNumber(0, boardWidth - Length);
        }
        public bool IsOverlap(Shape shape)
        {
            foreach (var loaction in shape.locations)
            {
                foreach (var innerLoaction in locations)
                {
                    if(loaction.Top == innerLoaction.Top && loaction.Left == innerLoaction.Left)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public abstract void SetShapeSize();
        public abstract void SetLocations();

        public virtual void Draw()
        {
           
            foreach (var location in locations)
            {
                Console.SetCursorPosition(location.Left, location.Top);
                Console.Write(DisplayChar);
            }
        }
        public virtual void Delete()
        {
            foreach (var location in locations)
            {
                Console.SetCursorPosition(location.Left, location.Top);
                Console.Write(" ");
            }

        }
    }
}

