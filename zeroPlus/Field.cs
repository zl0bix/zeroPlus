using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace zeroPlus
{
    internal class Field
    {
        Random _rnd = new Random();
        public bool SetArr(ref char[,] arr, int num, char ch)
        {
            //[0,0],[0,1],[0,2]
            //[1,0],[1,1],[1,2]
            //[2,0],[2,1],[2,2]
            
                switch(num)
                {
                case 1:
                    if (arr[0, 0] != 'O' || arr[0, 0] != 'X')
                    {
                        arr[0, 0] = ch;

                        return true;
                    }
                    return false;  
                        
                case 2:
                    if (arr[0, 1] != 'O' || arr[0, 1] != 'X')
                    {
                        arr[0, 1] = ch;

                        return true;
                    }
                    return false;

                case 3:
                    if (arr[0, 2] != 'O' || arr[0, 2] != 'X')
                    {
                        arr[0, 2] = ch;

                        return true;
                    }
                    return false;

                case 4:
                    if (arr[1, 0] != 'O' || arr[1, 0] != 'X')
                    {
                        arr[1, 0] = ch;

                        return true;
                    }
                    return false;
                case 5:
                    if (arr[1, 1] != 'O' || arr[1, 1] != 'X')
                    {
                        arr[1, 1] = ch;

                        return true;
                    }
                    return false;

                case 6:
                    if (arr[1, 2] != 'O' || arr[1, 2] != 'X')
                    {
                        arr[1, 2] = ch;

                        return true;
                    }
                    return false;

                case 7:
                    if (arr[2, 0] != 'O' || arr[2, 0] != 'X')
                    {
                        arr[2, 0] = ch;

                        return true;
                    }
                    return false;

                case 8:
                    if (arr[2, 1] != 'O' || arr[2, 1] != 'X')
                    {
                        arr[2, 1] = ch;

                        return true;
                    }
                    return false;

                case 9:
                    if (arr[2, 2] != 'O' || arr[2, 2] != 'X')
                    {
                        arr[2, 2] = ch;

                        return true;
                    }
                    return false;

                default:

                        return false;
            }                         
        }

        public bool ChekArr(int num)
        {
            if (num > 0 && num < 10)

                return true;

            else 

                return false;
        }
        public void DrowField(ref char[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        public bool IsWin(ref char[,] arr , char ch)
        {
            if (arr[0, 0] == ch && arr[0, 1] == ch && arr[0, 2] == ch)
            {
                Console.WriteLine("Выиграл игрок игравший за " + ch);
                return true;
            }
            else if (arr[1, 1] == ch && arr[1, 1] == ch && arr[1, 2] == ch)
            {
                Console.WriteLine("Выиграл игрок игравший за " + ch);
                return true;
            }
            else if (arr[2, 1] == ch && arr[2, 1] == ch && arr[2, 2] == ch)
            {
                Console.WriteLine("Выиграл игрок игравший за " + ch);
                return true;
            }
            else if (arr[0, 0] == ch && arr[1, 0] == ch && arr[2, 0] == ch)
            {
                Console.WriteLine("Выиграл игрок игравший за " + ch);
                return true;
            }
            else if (arr[1, 0] == ch && arr[1, 1] == ch && arr[1, 2] == ch)
            {
                Console.WriteLine("Выиграл игрок игравший за " + ch);
                return true;
            }
            else if (arr[2, 0] == ch && arr[2, 1] == ch && arr[2, 2] == ch)
            {
                Console.WriteLine("Выиграл игрок игравший за " + ch);
                return true;
            }
            else if (arr[0, 0] == ch && arr[1, 1] == ch && arr[2, 2] == ch)
            {
                Console.WriteLine("Выиграл игрок игравший за " + ch);
                return true;
            }
            else if (arr[2, 0] == ch && arr[1, 1] == ch && arr[0, 2] == ch)
            {
                Console.WriteLine("Выиграл игрок игравший за " + ch);
                return true;
            }
            else
                return false;

        }

        public bool OpponenеMove(ref char[,] arr, char ch)
        {
            int numX = _rnd.Next(0, 3);
            int numY = _rnd.Next(0, 3);
            if (arr[numX, numY] != ch && arr[numX, numY] != 'O')
            {
                arr[numX, numY] = 'O';

                return true;
            }
            else

               return false;

        }
    }
}
