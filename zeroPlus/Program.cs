using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zeroPlus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Field field = new Field();

            char[,] chars =
                {   {'.','.','.' },
                    {'.','.','.' },
                    {'.','.','.' }
                };
            int number;
            do
            {
                Console.Write("Введите номер поля -> ");

                if(int.TryParse(Console.ReadLine(), out number))

                field.SetArr(ref chars, number,'X');
            }
            while (!field.ChekArr(number));
            
           
            field.DrowField(ref chars);
        }
    }
}
