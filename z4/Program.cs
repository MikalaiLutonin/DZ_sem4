// ========= Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введи число А:");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введи число B:");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {A} в степени {B} равно {GetStepen(A, B)}");


int GetStepen(int number, int stepen)
{
int vozvedenie = Convert.ToInt32(Math.Pow(number, stepen));
    return vozvedenie;
}





//========= Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Clear();
// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// int s4etchik = 1;
// int sum = 0;

// Console.WriteLine($"Сумма цифр этого числа равна {Summa(N)}");


// int Summa(int number)
// {
// for (int i = 10; N / i != 0; i = i * 10)   //определяем количество цифр в числе
// {
//     s4etchik = s4etchik + 1;
// }
// // Console.WriteLine(s4etchik);

// int[] array = new int[s4etchik];           //создали пустой массив из подсчитанного количества цифр


// for (int i = 0; i < s4etchik; i++)        //заполняем пустой массив цифрами введенного числа
// {
//     array[i] = N % 10;
//     // Console.WriteLine(array[i]);
//     N = N / 10;
// }

// for (int i = 0; i < array.Length; i++)         //считаем сумму элементов массива
// {
//     sum = sum + array[i];
//     }
// // Console.Write(sum);

// return sum;
// }





//=========== Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.Clear();
// array_8();


// void array_8()
// {
//     int[] array = new int[8];          //объявили пустой массив из 8 элементов

//     for (int i = 0; i < 8; i++)        //заполнем массив рандомныими числами
//     {
//         array[i] = new Random().Next(0, 100);
//     }


//     Console.Write($"Рандомный массив из 8 элементов: ");

//     for (int i = 0; i < 8; i++)        //вывод массива на экран
//     {
//         Console.Write($" {array[i]}");
//     }

// }

