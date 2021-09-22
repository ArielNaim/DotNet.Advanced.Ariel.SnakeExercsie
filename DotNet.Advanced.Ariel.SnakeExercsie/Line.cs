using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Advanced.Ariel.SnakeExercsie
{
    public class Line : Rectangle
    {
        public override char DisplayChar => '=';


        public override void SetShapeSize()
        {
            Width = 1;
            Length = Util.GetRandomNumber(2, 11);
        }
     
      
    }
}
