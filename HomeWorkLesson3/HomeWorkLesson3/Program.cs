using System;

    class Program
    {
        static void Main(string[] args)
        {
            int x, y, yy, xx ;
            string z;
            string v = "Да";
            Console.WriteLine("Для домашнего задания взяти числа х = 10 и у = 12");

            Console.WriteLine("Введите X значение");
            x = Int32.Parse(Console.ReadLine());

            if (x != 10)
            {

                Console.WriteLine("Неверно указано число X для домашнего задания!");
                Console.WriteLine("Если вы хотите с вашими значениями введите  Да или Нет");
                z = Console.ReadLine();
                if (z != v )
                {

                    Console.WriteLine("Вы ввели нет, приложение закрыто");
                    Environment.Exit(0);


                }
                




            }

            Console.WriteLine("Введите Y значение");
            y = Int32.Parse(Console.ReadLine());  

            if (y != 12)
            {

                Console.WriteLine("Неверно указано число Y для домашнего задания!");
                Console.WriteLine("Если вы хотите с вашими значениями введите  Да или Нет");
                z = Console.ReadLine();
                if (z != v)
                {
                    Console.WriteLine("Вы ввели нет, приложение закрыто");
                    Environment.Exit(0);
                }

                

            }

            if ( x > y )
            {
                y = x;
                
            }

            int sum = x;
            if (x != y )

            {
                xx = x; 
                do
                {
                    xx += 1;
                   sum = sum + xx;
                }
                while ( xx != y);
            }
            Console.WriteLine($"Cумма = {sum}");
        }

    }