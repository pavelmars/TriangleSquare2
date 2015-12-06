using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareDesktop
{
    class Triangle90
    {
        // вычисление площади прямоугольного треугольника:
        private double perimetr;
        private double a,b,c;
        private double square = 0;
        private double kat1 = 0;
        private double kat2 = 0;
        private double hypotenuse = 0;

        public Triangle90(double Perimetr) // #1 Конструктор класса
        {
            perimetr = Perimetr;
        }

        public Triangle90(double A, double B, double C) // #2 Конструктор класса
        {
            a = A;
            b = B;
            c = C;
        }

        public double SquareCalculate1() // Метод #1 класса. 
        {                                // Расчёт площади равнобедренного треугольника.
            square = Math.Pow(perimetr, 2) / (2 * Math.Pow((Math.Sqrt(2) + 2), 2));
            return (square);
        }

        public bool Katets()
        {
            double maximum = Math.Max(Math.Max(a, b), c); // гипотенуза.
            double minimum = Math.Min(Math.Min(a, b), c); // наименьший из катетов.

            kat1 = minimum;
            kat2 = a + b + c - minimum - maximum; // периметр минус две известные стороны.
            hypotenuse = maximum;

            if (Math.Pow(kat1, 2) + Math.Pow(kat2, 2) == Math.Pow(hypotenuse, 2))
            {
                return (true);
            }
            else 
            { 
                return (false); 
            }
        }



        public double SquareCalculate2() // Метод #2 класса. 
        {                                // Расчёт площади треугольника по 3м сторонам.
            Katets();
            square =  kat1 * kat2/2;
            return (square);
        }
    }
}
