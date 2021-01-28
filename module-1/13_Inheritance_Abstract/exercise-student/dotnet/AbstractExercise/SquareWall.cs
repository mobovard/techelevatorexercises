using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    class SquareWall : RectangleWall
    {
               
        public SquareWall(string name, string color, int sideLength)
            : base(name, color, sideLength, sideLength)
        {        }

        public override string ToString()
        {
            return ($"{base.Name} ({base.Height}x{base.Length}) square");
        }



    }
}
