using System;
using System.IO;
namespace LAB3._1OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fc = new StreamReader("e:\\C#\\input.txt");
            string s = fc.ReadLine().Trim();
            Console.WriteLine("Сontents:");
            Console.WriteLine(s);

            Console.WriteLine("Enter word:");
            string word = Console.ReadLine();
            string[] array = s.Split(".");
            foreach (string it in array)
            {
                if (it.Contains(word))
                {
                    Console.WriteLine(it);
                }
            }
            Console.ReadKey();
        }
    }
}
