using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите уровень сложности (1 - легко, 2 - сложно, 3 - тяжело): ");
		int clox = Convert.ToInt32(Console.ReadLine());
		int a = 0;
		Random rnd = new Random();
		if (clox == 1)
		{
			a = rnd.Next(0, 50);
		}
		else if (clox == 2)
		{
			a = rnd.Next(0, 100);
		}
		else if (clox == 3)
		{
			a = rnd.Next(0, 200);
		}
		else
		{
			Console.WriteLine("Введите значение заново!");
		}
		
        bool bol = false;
		Console.WriteLine("Введи число чтобы играть: ");
        double znch = Convert.ToDouble(Console.ReadLine());
        while (bol == false)
        {
            if (znch != a)
            {
                if (znch > a)
                {
                    Console.WriteLine("Число угадно не верно! Загаданое число меньше. Введите значение заново: ");
                }
                else
				{
					Console.WriteLine("Число угадно не верно! Загаданое число больше. Введите значение заново: ");
				}
                znch = Convert.ToDouble(Console.ReadLine());
                bol = false;
            }
            else
            {
                Console.WriteLine("Число угадно!");
                bol = true;
            }
        }
    }
}