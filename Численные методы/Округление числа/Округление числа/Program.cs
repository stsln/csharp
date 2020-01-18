using System;

namespace Округление_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //данное число
            Console.Write("Введите число для округления: ");
            double num = Convert.ToDouble(Console.ReadLine());
            //перевод числа в массив
            char[] arr = num.ToString().ToCharArray();
            Console.Write("Нулевой индекс массива: ");
            Console.WriteLine(arr[0]);
            //целая часть
            int num1 = (int)(num);
            string num2 = Convert.ToString(num1);
            //длина целой части
            int num3 = num2.Length;
            Console.Write("Размер целой части: ");
            Console.WriteLine(num3);

            //до какого цифры после запятой
            Console.Write("Введите до какой цифры нужно округлить число: ");
            int n = Convert.ToInt32(Console.ReadLine()) + 1 + num3 - 1; //до какой цифры + длина целой части + запятая - начинается с нулевого символа
            Console.Write("До индекса: ");
            Console.WriteLine(n);

            //число для проверки
            var ocrug1 = arr[n + 1];
            //число для округления
            var ocrug2 = arr[n];
            Console.WriteLine(Convert.ToInt32(ocrug2));
            //в int
            string slovo1 = "";
            for (int i = 0; i < n; ++i) //n - 1
            {
                slovo1 += arr[i];
            }

            Console.WriteLine(slovo1);

            if (ocrug1 > 5)
            {
                ocrug2 += Convert.ToChar(1);
            }
            else if (ocrug1 < 5)
            {
                ocrug2 += Convert.ToChar(0);
            }
            else
            {
                if (ocrug2 % 2 == 0)
                {
                    ocrug2 += Convert.ToChar(0);
                }
                else
                {
                    ocrug2 += Convert.ToChar(1);
                }
            }
            //в var
            int ocrug4 = Convert.ToInt32(ocrug2.ToString());

            string slovo0 = slovo1 + Convert.ToString(ocrug4);
            Console.WriteLine("Полученное число: " + slovo0);


            //через for вывести все символы массива до n-ой - 1 цифры
            //сделать проверку через if
            //добавить к полученной строке цифру для округления
            //вывести число

            //есть проблема с нулями и пример не сходится с программой 67,382≈67,38.
            //не работает округление до десятных получается на 1 больше
            //и другие
        }
    }
}
