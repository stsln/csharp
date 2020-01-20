using System;

namespace Округление_числа
{
    class Program
    {
        static void Main(string[] args)
        {

            //Данное число
            Console.Write("Введите число для округления: ");
            double num = Convert.ToDouble(Console.ReadLine());

            //Перевод числа в массив
            char[] arr = num.ToString().ToCharArray();
            Console.WriteLine("Нулевой индекс массива: " + arr[0]);

            //Целая часть
            int num1 = (int)(num);
            string num2 = Convert.ToString(num1);
            //Длина целой части
            int num3 = num2.Length;
            Console.WriteLine("Размер целой части: " + num3);

            //До какой цифры после запятой
            Console.Write("Введите до какой цифры нужно округлить число: ");
            int n0 = Convert.ToInt32(Console.ReadLine());
            int n = n0 + num3 + 1 - 1; //до какой цифры + длина целой части + запятая - начинается с нулевого символа
            Console.WriteLine("По индекс: " + n);

            //slovo1 - это число до окугляющей цифры
            string slovo1 = "";
            for (int i = 0; i < n; ++i) //n - 1
            {
                slovo1 += arr[i];
            }
            Console.WriteLine("Число до окугляющей цифры: " + slovo1);

            if (n0 == 0)
            {

                //Число для проверки
                var ocrug1 = arr[n + 1];
                int ocrug11 = Convert.ToInt32(ocrug1.ToString());
                Console.WriteLine("Проверка по числу: " + ocrug11);

                //Число для округления
                var ocrug2 = arr[n - 1];
                int ocrug22 = Convert.ToInt32(ocrug2.ToString());
                Console.WriteLine("Число для округления: " + ocrug22);

                //Код для округления!

                if (ocrug11 >= 5)
                {
                    ocrug22 += 1;
                    Console.WriteLine("Цифра для добавления к slovo1: " + ocrug22);
                }
                else
                {
                    ocrug22 += 0;
                }

                //slovo1 - это число до окугляющей цифры
                string slovo2 = "";
                for (int i = 0; i < n - 1; ++i)
                {
                    slovo2 += arr[i];
                }
                Console.WriteLine("Число до окугляющей цифры: " + slovo2);

                string slovo0 = slovo2 + Convert.ToString(ocrug22);
                Console.WriteLine("Полученное число: " + slovo0);
            }
            else
            {
                //Число для проверки
                var ocrug1 = arr[n + 1];
                int ocrug11 = Convert.ToInt32(ocrug1.ToString());
                Console.WriteLine("Проверка по числу: " + ocrug11);

                //Число для округления
                var ocrug2 = arr[n];
                int ocrug22 = Convert.ToInt32(ocrug2.ToString());
                Console.WriteLine("Число для округления: " + ocrug22);

                //Код для округления!

                if (ocrug11 > 5)
                {
                    ocrug22 += 1;
                    Console.WriteLine("Цифра для добавления к slovo1: " + ocrug22);
                }
                else if (ocrug11 < 5)
                {
                    ocrug22 += 0;
                }
                else
                {
                    if (ocrug22 % 2 == 0)
                    {
                        ocrug22 += 0;
                    }
                    else
                    {
                        ocrug22 += 1;
                    }
                }

                string slovo0 = slovo1 + Convert.ToString(ocrug22);
                Console.WriteLine("Полученное число: " + slovo0);
            }
            //не работает 14,999 при 2 и 99,8 при 0 и 19,582 при 0 и т.п
			
        }
    }
}
