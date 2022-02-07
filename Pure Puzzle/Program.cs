using System;

namespace Pure_Puzzle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bredde = 8;

            for (int i = 0; i < bredde; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine("");

            for (int i = 0; i < bredde; i++)
            {
                if (i == 0 || i == 7)
                {
                    Console.Write(" ");

                } else Console.Write("#");
            }
            Console.WriteLine("");

            for (int i = 0; i < bredde; i++)
            {
                if (i == 0 || i == 1 || i == 6 || i == 7)
                {
                    Console.Write(" ");

                } else Console.Write("#");
            }
            Console.WriteLine("");

            for (int i = 0; i < bredde; i++)
            {
                if (i == 0 || i == 1 || i == 2 || i == 5 || i == 6 || i == 7)
                {
                    Console.Write(" ");

                } else Console.Write("#");

            }
            Console.WriteLine(" ");
            Console.WriteLine("Neste forsøk:");
            Console.WriteLine(" ");

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    
                    if(j>i)Console.Write(" ");
                    else Console.Write("#");
                    
                }
                Console.WriteLine("");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Neste forsøk:");
            Console.WriteLine(" ");

            string[] draw = {
             "#", "-", "-", "-", "-", "-", "-", "#", 
             "-", "#", "-", "-", "-", "-", "#", "-", 
             "-", "-", "#", "-", "-", "#", "-", "-", 
             "-", "-", "-", "#", "#", "-", "-", "-", 
             "-", "-", "-", "#", "#", "-", "-", "-", 
             "-", "-", "#", "-", "-", "#", "-", "-", 
             "-", "#", "-", "-", "-", "-", "#", "-", 
             "#", "-", "-", "-", "-", "-", "-", "#", 
            };

            for (int i = 0; i < draw.Length; i++)
            {
                if (i == 8 || i == 16 || i == 24 || i == 32 || i == 40 || i == 48 || i == 56) Console.WriteLine("");
                Console.Write(draw[i]);
            }
        }
 
    }
}
