using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string first;
                first = Console.ReadLine();
                char[] second = first.ToCharArray(0, first.Length);
                int action = 0;
                int a, b, c = 0;
                string fr = "", sc = "";
                for (int i = 0; i < first.Length; i++)
                {
                    switch (second[i])
                    {
                        case '+':
                            action = 1;
                            break;
                        case '-':
                            action = 2;
                            break;
                        case '*':
                            action = 3;
                            break;
                        case '/':
                            action = 4;
                            break;
                        default:
                            if (action == 0)
                            {
                                fr += Char.ToString(second[i]);
                            }
                            else
                            {
                                sc += Char.ToString(second[i]);
                            }
                            break;
                    }
                }
                a = int.Parse(fr);
                b = int.Parse(sc);
                switch (action)
                {
                    case 1:
                        c = a + b;
                        break;
                    case 2:
                        c = a - b;
                        break;
                    case 3:
                        c = a * b;
                        break;
                    case 4:
                        c = a / b;
                        break;
                }

                Console.WriteLine(c);
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}

