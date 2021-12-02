using System;

namespace TP1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Multiplication();
            OddResult();
            AskUserForParameter();
            Prime();
            Fibonacci();
            Factorial();
            for (int i = -3 ; i <= 3; i++)
            {
                try
                {
                    Console.WriteLine(10 / PowerFunction(i));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            Square(1,5);
            tree(6);
        }
            
        
        static void Multiplication()
        {
            Console.Write("Exercice 1 partie 1 : \n");
            for (int n = 1; n <= 10; n++)
            for (int i = 1; i <= 10; i++)
                Console.Write(n + "*" + i + "=" + n * i + "\n");
        }

        static void OddResult()
        {
            Console.Write("\nPartie 2 : \n\n");
            for (int n = 1; n <= 10; n++)
            for (int i = 1; i <= 10; i++)
                if (i % 2 != 0 && n % 2 != 0)
                {
                    Console.Write(n + "*" + i + "=" + n * i + "\n");
                }
        }

        private static int AskUserForParameter()
        {
            Console.Write("\nPartie 3 :\n\n");
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            for (int i = 1; i <= 10; i++)
                Console.Write(result + "*" + i + "=" + result * i + "\n");
            return result;
        }

        private static void Prime()
        {
            Console.Write("\nExo 2 Partie 1 : \n\n");
            for (var i = 2; i <= 1000; i++)
            {
                bool isPrimeNb = true;

                for (var j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNb = false;
                        break;
                    }
                }

                if (isPrimeNb)
                {
                    Console.Write(i + " - ");
                }
            }
        }

        private static void Fibonacci()
        {
            Console.Write("\nPartie 2 :\n\n");
            Console.WriteLine("Please write fibonacci value and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            int a = 0, b = 1, c = 0;  
            Console.Write("{0} {1}", a,b);  
            for (int i = 2; i < result; i++)  
            {  
                c = a + b;  
                Console.Write("{0}", c);  
                a = b;  
                b = c;  
            }  

        }

        private static void Factorial()
        {
            int i, fact = 1;
            Console.WriteLine("Please write a number value and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            for (i = 1; i <= result; i++)
            {
                fact *= i;
            }
            Console.Write("Factorial of " +result+" is : "+fact);  
        }

        private static int PowerFunction(int x)
        {
            return (int) (Math.Pow(x, 2) - 4);
        }
        
        private static void Square(int n, int m)
        {
            int flag = 0;
            if (n == 1 || m == 1)
            {
                Console.Write("0");
                return;
            }
            string tabs = new string('-', (n - 2));
            Console.Write("0" + tabs + "0\n");
            for(int cpt1=0; cpt1<m-2; ++cpt1)
            {
                Console.Write("|");
                for (int cpt2 = 0; cpt2< n - 2; cpt2++)
                {
                    if (flag==0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    flag = ++flag % 3;

                }
                Console.Write("|\n");
                flag = ++flag % 3;
            }
            Console.Write('0' + tabs  + "0\n");
        }

        static void tree(int size)
        {
            int size_line = (size*2)-1;
            int nb_star = 1;
            for(int cpt=0; cpt < size; ++cpt)
            {
                Console.Write( (new string(' ', (size_line-nb_star)/2)) + (new string('*', nb_star)));
                Console.Write("\n");
                nb_star = nb_star+2;
            }

            Console.Write((new string(' ', (size_line - 3) / 2)) + "| |");
        }
    }
    
}
