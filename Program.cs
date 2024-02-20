// // Задача 1: Задайте значения M и N. Напишите
// // программу, которая выведет все натуральные числа
// // в промежутке от M до N. Использовать рекурсию, не
// // использовать циклы.
// // M = 1; N = 5 -> "1, 2, 3, 4, 5"
// // // M = 4; N = 8 -> "4, 5, 6, 7, 8
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
void ShowNumbers(int m, int n)
{
    if (m == n)
    {
        Console.Write(m);
        return;
    }
    
    Console.Write(m + " ");
    ShowNumbers(m + 1, n);
}
ShowNumbers(m, n);

// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9

Console.Write("Введите число m:" );
int m = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите число n:" );
int n = Convert.ToInt32 (Console.ReadLine()); 

AkkermanFunction (m , n);
// вызов функции
void  AkkermanFunction (int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}
// функция Аккермана
int Akkerman (int m, int n)
{
    if  (m == 0)
    {
        return  n + 1;
    }
    else  if(n == 0  &&  m > 0 )
    {
        return Akkerman(m - 1,1); 
    }
    else
    {
        return(Akkerman(m - 1, Akkerman(m , n - 1 )));
    }
}

// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

 void printBack(int[] array, int i = 0)
{
    if(i != array.Length) 
    {
        printBack(array, i + 1);
        Console.Write($"{array[i]} ");
    }
}
        
{
    var array = new int[]{1, 2, 5, 0, 10, 34};
    printBack(array);            
}

