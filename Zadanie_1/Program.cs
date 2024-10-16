﻿
// Типы переменных:

/* 
   1. Числовые (целые)
    byte   размер = 1 ; значения от 0 до 255
    sbyte  размер = 1 ; значения от -128 до 127
    short  размер = 2 ; значения от -32768 до 32767
    ushort размер = 2 ; значения от 0 до 65535
    int    размер = 4 ; значения от -2147483648 до 2147483647
    uint   размер = 4 ; значения от 0 до 4294967295
    long   размер = 8 ; значения от –9223372036854775808 до 9223372036854775807
    ulong  размер = 8 ; значения от 0 до 18446744073709551615

    2. Числовые (дробные)
    float  размер = 4 
    double размер = 8 

    3. Cимвольные 
    char   размер = 2
    string 222

    4. Логический 
    bool   размер = 1 ; значения true или false
*/

// Бинарные операции 

/*
    + сложение 
    - вычитание 
    * умножение 
    / деление 
    & и
    | или 
    == равно 
    != не равно 
    > больше
    < меньше
    >= больше или равно
    <= меньше или равно
 */




// Консольный ввод-вывод

/*
 консольный ввод - Console.ReadLine();
 консольный вывод - Console.WriteLine();
 */

// Пример:
class Program
{
    static void Main()
    {
        Console.WriteLine("Напишите ваше имя");
        string name = Console.ReadLine();
        Console.WriteLine($"Здравствуйте, {name}");
    }
}




