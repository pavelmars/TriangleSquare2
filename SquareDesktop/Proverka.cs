using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareDesktop
{
    class Proverka
    {
        private string stroka;

        public Proverka(string Stroka) // #1 Конструктор класса
        {
            stroka = Stroka;
        }


        public bool Empty_Check() // Метод1. Проверка на пустые значения.
        {
            if ((stroka.Trim().Length > 0) && (stroka != "0"))
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
        public bool Space_Check() // Метод2. Проверка на пробелы.
        {
            int j = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == ' ')
                {
                    j++;
                }
            }
            if (j != 0) return (false);
            else return (true);
        }
        public bool DataCheck() // Метод3. Проверка на десятичные положительные числа.
        {
            double x;
            try
            {
                x = Convert.ToDouble(stroka);
            }
            catch (FormatException)
            {
                return (false);
            }
            if (x < 0) return (false);
            else return (true);
        }
    }
}
