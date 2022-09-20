using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            bool running = true;

            while (running == true)
            {
                Console.WriteLine("1. Addera\n2. Subtrahera\n3. Dividera\n4. Multiplicera\n5. Avsluta program");
                Console.Write("Välj alternativ: ");
                option = Convert.ToInt32(Console.ReadLine());

                if(option == 5)
                {
                    running = false;
                    break;
                }

                Console.Write("Mata in första tal: ");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mata in andra tal: ");
                int tal2 = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Addera(tal1, tal2);
                        break;
                    case 2:
                        Subtrahera(tal1, tal2);
                        break;
                    case 3:
                        Dividera(tal1, tal2);
                        break;
                    case 4:
                        Multiplicera(tal1, tal2);
                        break;

                }

            }
        }

        static void Addera(int arg1, int arg2)
        {
            int summa = arg1 + arg2;
            Console.WriteLine(arg1 + " + " + arg2 + " är lika med " + summa);
        }

        static void Subtrahera(int arg1, int arg2)
        {
            int summa = arg1 - arg2;
            Console.WriteLine(arg1 + " - " + arg2 + " är lika med " + summa);
        }

        static void Dividera(int arg1, int arg2)
        { 
            try
            {
                int summa = arg1 / arg2;
                Console.WriteLine(arg1 + " / " + arg2 + " är lika med " + summa);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Det går inte att dela med 0");
            }
        }

        static void Multiplicera(int arg1, int arg2)
        {
            int summa = arg1 * arg2;
            Console.WriteLine(arg1 + " * " + arg2 + " är lika med " + summa);
        }
    }
}
