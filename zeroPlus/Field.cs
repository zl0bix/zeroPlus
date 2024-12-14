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
        public void SetArr(ref char[,] arr, int num, char ch)
        {
            //[0,0],[0,1],[0,2]
            //[1,0],[1,1],[1,2]
            //[2,0],[2,1],[2,2]
            
                switch(num)
                {
                    case 1:
                         arr[0, 0] = ch;
                         break;
                        
                    case 2:
                        arr[0, 1] = ch;
                        break;

                case 3:
                        arr[0, 2] = ch;
                        break;

                case 4:
                        arr[1, 0] = ch;
                        break;
                case 5:
                        arr[1, 1] = ch;
                        break;

                case 6:
                        arr[1, 2] = ch;
                        break;

                case 7:
                        arr[2, 0] = ch;
                        break;

                case 8:
                        arr[2, 1] = ch;
                        break;

                case 9:
                        arr[2, 2] = ch;
                        break;

                default:
                        break;
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
            if (arr[0,1] == ch && arr[0,2] == ch)

                return true;
            else if()
        }
    }
}
