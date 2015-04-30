using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 1;
            int clumns = 1;
            while (clumns < 9)
            {
                //   Console.WriteLine("clumns =" + clumns);
                //   Console.WriteLine("clumns % 2 =" + (clumns%2));
                rows = 1;
                if ((clumns % 2) == 1)
                {
                    while (rows < 9)
                    {
                        //Console.WriteLine("rows1 =" + rows);
                        switch (rows)
                        {
                            case 1:
                                Console.Write("X");
                                break;
                            case 2:
                                Console.Write("O");
                                break;
                            case 3:
                                Console.Write("X");
                                break;
                            case 4:
                                Console.Write("O");
                                break;
                            case 5:
                                Console.Write("X");
                                break;
                            case 6:
                                Console.Write("O");
                                break;
                            case 7:
                                Console.Write("X");
                                break;
                            case 8:
                                Console.WriteLine("O");
                                break;

                            default:
                                break;
                        }
                        rows++;
                    } 
                }
                else
                {
                  //  Console.WriteLine("rows2 =" + rows);
                    while (rows < 9)
                    {
                        switch (rows)
                        {
                            case 1:
                                Console.Write("O");
                                break;
                            case 2:
                                Console.Write("X");
                                break;
                            case 3:
                                Console.Write("O");
                                break;
                            case 4:
                                Console.Write("X");
                                break;
                            case 5:
                                Console.Write("O");
                                break;
                            case 6:
                                Console.Write("X");
                                break;
                            case 7:
                                Console.Write("O");
                                break;
                            case 8:
                                Console.WriteLine("X");
                                break;

                            default:
                                break;
                        }
                        rows++;
                    }
                }
             clumns++; 
            }
         
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();    
        }
    }
}
