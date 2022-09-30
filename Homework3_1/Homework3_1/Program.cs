using System;
using System.Collections;

namespace Quadrate
{
    class Program
    {
        static void Main(string[] args)
        {
            Square mf = new Square(5);
            mf.DrawSquare(); 
        }
        class Quadro
        {
            public int Base { get; set; }
        }
        interface ISimpleNAngle 
        {
            int Base { get; set; }
            int BaseSideAngle { get; set; }
            int NumberSide { get; set; }
        }
        class Square : ISimpleNAngle
        {
            public int Base { get; set; }
            public int BaseSideAngle { get; set; }
            public int NumberSide { get; set; }
            public Square(int numberSide)
            {
                NumberSide = numberSide;
                BaseSideAngle = 360 / numberSide;
            }
            public void DrawSquare()
            {
                char[] drawChar = new char[8] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
                for (int i = 1; i < drawChar.Length; i++)
                {
                    for (int j = 0; j < drawChar.Length; j++)
                    {
                        drawChar[j] = '*';
                    }
                    Console.WriteLine(drawChar);
                }
            }
    }   }
}
