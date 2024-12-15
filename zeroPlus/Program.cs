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

            bool isWin = false;

            while (!isWin)
            {   
                Console.Clear();
                field.DrowField(ref chars);
                //do
                Console.Write("\n1 2 3\n4 5 6\n7 8 9\nВведите номер поля согласно схеме -> ");

                if (int.TryParse(Console.ReadLine(), out number))
                {

                    field.SetArr(ref chars, number, 'X');
                }
                while (!field.SetArr(ref chars, number, 'X'))
                {
                    Console.Write("\n1 2 3\n4 5 6\n7 8 9\nВведите номер поля согласно схеме -> ");

                    if (int.TryParse(Console.ReadLine(), out number))
                    {

                        field.SetArr(ref chars, number, 'X');
                    }
                    Console.Clear();
                    field.DrowField(ref chars);
                }

                if (field.IsWin(ref chars, 'X'))
                {
                    isWin = true;

                    continue;
                }
                    while(!field.OpponenеMove(ref chars,'X'))
                    {
                        field.OpponenеMove(ref chars, 'X');
                        
                    }

                if (field.IsWin(ref chars, 'O'))
                {
                    isWin = true;

                    continue;
                }



                //while (!isWin);
            }

            
            field.DrowField(ref chars);
            Console.WriteLine("Молодец!!!");            
        }
    }
}
