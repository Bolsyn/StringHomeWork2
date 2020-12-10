using System;

namespace StringHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка.
            // Программа должна сосчитать количество введенных пользователем пробелов.

            string word;
            int spaces = 0;

            do
            {
                word = Console.ReadLine();
                if (word.Contains(" "))
                {
                    spaces++;
                }
            }
            while (!word.EndsWith('.'));
            Console.WriteLine(spaces);
            // 2.Ввести с клавиатуры номер трамвайного билета(6 - значное число) и про-верить является ли данный билет 
            // счастливым(если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх,
            // то этот билет считается счастливым).

            string ticket;
            ticket = Console.ReadLine();
            int ticketNumber = Int32.Parse(ticket);
            int tmpTicketNumber = ticketNumber / 1000;
            ticketNumber %= 1000;
            int sumFirst = tmpTicketNumber % 10 + (tmpTicketNumber % 100) / 10 + (tmpTicketNumber % 1000) / 100;
            int sumSecond = ticketNumber % 10 + (ticketNumber % 100) / 10 + (ticketNumber % 1000) / 100;
            if (sumFirst == sumSecond)
            {
                Console.WriteLine("Lucky");
            }
            else
            {
                Console.WriteLine("UnLucky");
            }

            // 3.Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32.
            // Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.

            string sentence;
            int lengthSentence;
            sentence = Console.ReadLine();
            char[] chars = sentence.ToCharArray();
            lengthSentence = chars.Length;
            for (int i = 0; i < lengthSentence; i++)
            {
                if (chars[i] > 'a' && chars[i] < 'z')
                {
                    chars[i] = (char)((int)chars[i] + 32);
                }
                else if (chars[i] > 'A' && chars[i] < 'Z')
                {
                    chars[i] = (char)((int)chars[i] - 32);
                }
            }

            // 4.Даны целые положительные числа A и B(A<B). Вывести все целые числа от A до B включительно;
            // каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное его значению. Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
            //     3 3 3
            //     4 4 4 4
            //     5 5 5 5 5
            //     6 6 6 6 6 6
            //     7 7 7 7 7 7 7

            int A = 3;
            int B = 7;
            int a = A; // Ввод счетчика
            if (A < B)
            {
                while (A <= B)
                {
                    while (a != 0)
                    {
                        Console.Write(A);
                        Console.Write(" ");
                        a--;
                    }
                    Console.WriteLine();
                    A++;
                    a = A;
                }
            }

            // 5.Дано целое число N(> 0), найти число, полученное при прочтении числа N справа налево. 
            // Например, если было введено число 345, то программа должна вывести число 543.

            int N = 345;
            int result = 0;
            while (N > 0)
            {
                result *= 10;
                result += N % 10;
                N /= 10;
            }
        }
    }
}