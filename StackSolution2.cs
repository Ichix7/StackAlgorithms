using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_Winden
{
    class Program
    {
        public static int[] Numbers = new int[] { 1, 3, 6, 7, 9, 12, 13, 18 };

        static void Main(string[] args)
        {
            string answer = " ";
            do
            {
                Console.WriteLine("Please Choose step: Push(P) Pop(O) Top(T) Quit (Q): ");
                answer = Console.ReadLine().ToUpper();

                if (answer == "P")
                {
                    Console.WriteLine("Number?:");
                    string ans = Console.ReadLine();
                    int add = Convert.ToInt32(ans);
                    MyStack.Push(add);
                }
                if (answer == "O")
                {
                    MyStack.Pop();
                }
                if (answer == "T")
                {
                    MyStack.Top();
                }
                Console.WriteLine("Complete: Press Enter");
                Console.ReadLine();
                Console.Clear();

            } while (answer != "Q");
        
        /*
        Random rand = new Random();
        int choice = rand.Next(0, 7);
        Console.WriteLine("Number Goal: {0}", Numbers[choice]);                       
        Linear(Numbers[choice]);
        Binary(Numbers[choice]);
        */
        Console.ReadLine();
        }



        static void doubler()
        {
            Console.Write("Give me a POSITIVE Number: ");
            int Posnum = Convert.ToInt32(Console.ReadLine());
            do
            {

                Posnum = Posnum / 2;
                int dble2 = Posnum * Posnum;

                Console.Write("Number {0} ", Posnum);
                Console.WriteLine("doubled {0}", dble2);


            } while (Posnum != 0);
            Console.WriteLine("<Press Enter>");
        }

        static void Linear(int x)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for(int i = 0; i < Numbers.Length-1; i++)
            {
                if( Numbers[i] == x)
                {
                    Console.WriteLine("\nYour Number: {0}", Numbers[i]);
                    Console.WriteLine("At spot: {0}", i);
                }
            }
            watch.Stop();
            Console.WriteLine("Elapsed Time: {0}", watch.Elapsed);
        }

        static void Binary(int x)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int Average = 0;
            int min = 0;
            int max = Numbers.Length - 1;

            do {                
                Average = (min + max) / 2;
                if (Numbers[Average] == x)
                {
                    Console.WriteLine("\nYour Number: {0}", x);
                    Console.WriteLine("At spot: {0}", Average);
                }
                else if (Numbers[Average] < x)
                {
                    min = Average + 1;
                }
                else { max = Average - 1; }

            }while(Numbers[Average] != x);
            watch.Stop();
            Console.WriteLine("Elapsed Time: {0}", watch.Elapsed);
        }
    }
    class MyStack
    {
        public static List<int> numbers = new List<int>();

        public static void Push(int x)
        {
                numbers.Add(x);
            
        }

        public static void Pop()
        {
            if (numbers.Count != 0)
            {
                numbers.RemoveAt(numbers.Count() - 1);
            }
        }

        public static void Top()
        {
            numbers.ForEach(Console.WriteLine);
        }

    }
}
