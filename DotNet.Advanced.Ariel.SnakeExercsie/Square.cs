using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Advanced.Ariel.SnakeExercsie
{
    public class Square : Rectangle
    {
        public override char DisplayChar => '@';

        public override void SetShapeSize()
        {
            Width = Util.GetRandomNumber(3, 11); 
            Length = Width;
        }
      


    }

}
