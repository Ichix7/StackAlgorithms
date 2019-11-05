using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystack
{
    class Program
    {



        static void Main(string[] args)
        {
            string answer ="";
            do
            {
                Console.Write("Please Enter Word: ");
                answer = Console.ReadLine();
                answer.ToCharArray();

                foreach(char Letter in answer)
                {
                    MyStack.Push(Letter);
                }
                

                
                foreach (char Letter in answer)
                {
                    MyStack.Pop();
                }
                
                
                MyStack.Top();

                Console.WriteLine("<Press Enter>");
                Console.ReadLine();
                Console.Clear();
                /*
                if (answer == "P")
                {
                    Console.WriteLine("?:");
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
                */
            } while (answer != "Q");
        }


    }
    class MyStack
    {
        public static string[] Word = new string[50];
        public static string word1 = "";
        public static string[] BackWord = new string[50];
        public static string word2 = "";
        public static int I = 0;
        public static int p = 0;

        public static void Push(char x)
        {
            if (!IsFull())
            {
                if (I < 0)
                {
                    I = 0;
                }
                Word[I] = x.ToString();
                I++;
            }
        }
        
        public static void Pop()
        {
            if (!IsEmpty())
            {
                if (I >= 0)
                {
                    BackWord[p] = Word[I - 1];
                    I--;
                    p++;
                }

            }
        }

        public static void Top()
        {

            if (IsPal())
            {
                Console.WriteLine(word1);
                Console.WriteLine(word2);
                Console.WriteLine("Congrats its Palindrome!");
            }
            Array.Clear(Word, 0, Word.Length);
            word1 = "";
            Array.Clear(BackWord, 0, BackWord.Length);
            word2 = "";

        }

        public static bool IsEmpty()
        {
            if (I < 0 && p < 0) { return true; }
            return false;
        }
        public static bool IsFull()
        {
            if (I > 25 && p > 25) { return true; }
            return false;
        }
        public static bool IsPal()
        {
            for (int i = 0; i < Word.Length; i++)
            {
                word1 += Word[i];
            }
            for (int i = 0; i < BackWord.Length; i++)
            {
                word2 += BackWord[i];
            }

            if (word1 == word2)
            {

                return true;
            }
            return false;
        }
    }
}