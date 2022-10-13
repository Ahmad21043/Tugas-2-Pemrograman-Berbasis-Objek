using System;

namespace ConsoleApp1
{
    class Square
    {
        double _side;
        public double side
        {
            get
            {
                return Math.Round(_side, 2);
            }

            set
            {
                Console.WriteLine("Value to be set: " + value);

                if (value <= 0)
                {
                    return;
                }

                this._side = value;
            }
        }

        public double calcArea()
        {
            return _side * _side;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square 1:");
            Square square_1 = new Square();
            square_1.side = 2.12345; // setter

            Console.WriteLine("Side = " + square_1.side);// getter
            Console.WriteLine("Area = " + square_1.calcArea());

            Console.WriteLine("- - - - - -");
            Console.WriteLine("Square 2:");

            Square square_2 = new Square();
            square_2.side = -1; // setter

            Console.WriteLine("Side = " + square_2.side); // getter
        }
    }
}
/*
Output:
Square 1:
Value to be set: 2,12345
Side = 2,12
Area = 4,5090399025000005
- - - - - - 
Square 2:
Value to be set: -1
Side = 0
*/