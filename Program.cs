// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

using static System.Console;

Clear();
WriteLine("Задача 2");
WriteLine("Введите 2 числа");
int num1=Convert.ToInt32(ReadLine());
int num2=Convert.ToInt32(ReadLine());
if (num1>num2){
    WriteLine($"max = {num1}, min = {num2}");
}
else {
    WriteLine($"max = {num2}, min = {num1}");
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

WriteLine("");
WriteLine("Задача 4");
WriteLine("Введите 3 числа");
int num3=Convert.ToInt32(ReadLine());
int num4=Convert.ToInt32(ReadLine());
int num5=Convert.ToInt32(ReadLine());
int max=num3;
if (max<num4) {
    max=num4;
}
if (max<num5) {
    max=num5;
}
WriteLine($"Максимальное число {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

WriteLine("");
WriteLine("Задача 6");
WriteLine("Введите число");
int num6=Convert.ToInt32(ReadLine());
int rem=num6%2;
if (rem==0) {
    WriteLine("число четное");
}
else {
    WriteLine("число нечетное");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

WriteLine("");
WriteLine("Задача 8");
WriteLine("Ведите число");
int num7=Convert.ToInt32(ReadLine());
if (num7==0) {
    WriteLine("Единственное четное число сам 0");
}
if (num7==1) {
    WriteLine("Нет четных чисел");
}
if (num7>1) {
    int even1=2;
    while (even1<=num7) {
        Write($"{even1} ");
        even1+=2;
    }
}
if (num7<0) {
    int even2=0;
    while (even2>=num7) {
        Write($"{even2}");
        even2-=2;
    }
}