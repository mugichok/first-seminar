// Console.Clear();
// Console.Write("Введите первое число: ");
// int n = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{n} + {m} = {n + m}");


// Console.Clear();
// Console.Write("Введите первое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// // Фигурные скобки ставятся, когда внутри цикла выполняется более одной строчки кода
// if(n>m)
//     Console.WriteLine($"{n} наибольшее число");

// else if(m>n)
//     Console.WriteLine($"{m} наибольшее число");

// else
//     Console.WriteLine("Вы ввели равные числа");

// int i = 1;
// while(i < 10)
// {
//     Console.Write($"{i} ");
//     i++;
// }

// int i = 1;
// do
// {
//     Console.Write($"{i} ");
//     i++;
// }
// while(i < 10);

// for(int i = 0; i<10; i++)
//     Console.Write($"{i} ");

// Console.WriteLine();

// for(int i = 10; i>0; i--)
//     Console.Write($"{i} ");

// Console.WriteLine();

// for(int i = 0; i<10; i+=2)
//     Console.Write($"{i} ");

// Console.WriteLine();


// первая задача
// Console.Write("Введите число ");
// int x = int.Parse(Console.ReadLine()!);
// Console.WriteLine(x*x);

//вторая задача
// Console.Clear();
// Console.Write("Введите первое число ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число ");
// int m = int.Parse(Console.ReadLine()!);
// if(m == n*n)
//     Console.WriteLine("Второе число является квадратом первого");

// else
//     Console.WriteLine("Второе число Не является квадратом первого");

// третья задача

// Console.Clear();
// Console.Write("Введите номер дня недели ");
// int n = int.Parse(Console.ReadLine()!);
// while(n<1 || n>7)
// {
//     Console.Write("Вы ошиблись!\nВведите номер дня недели ");
//     n = int.Parse(Console.ReadLine()!);
// }
// if(n==1)
//     Console.Write("Понедельник");

// else if(n==2)
//     Console.Write("Вторник");

// else if(n==3)
//     Console.Write("Среда");

// else if(n==4)
//     Console.Write("Четверг");

// else if(n==5)
//     Console.Write("Пятница");

// else if(n==6)
//     Console.Write("Суббота");

// else
//     Console.Write("Воскресенье");

// четвёртая задача

// Console.Clear();
// Console.Write("Введите число ");
// int x = int.Parse(Console.ReadLine()!);
// for(int i = x*(-1); i <= x; i++)
//     Console.Write(i);

// пятая задача
Console.Clear();
Console.Write("Введите число ");
int x = int.Parse(Console.ReadLine()!);
while(x<100 || x>999)
{
    Console.Write("Вы ошиблись!\nВведите число ");
    x = int.Parse(Console.ReadLine()!);
}
Console.WriteLine(x % 10);

