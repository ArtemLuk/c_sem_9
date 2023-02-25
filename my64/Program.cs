// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string PrintNumbers(int m, int n){
    if (m == n)
    {
       // Console.WriteLine(m);
        return m.ToString();
    }
    string s = PrintNumbers(m+1,n) + " " + m.ToString();
    //Console.WriteLine(s);
    return s;
}

Console.Clear();
Console.WriteLine("Enter number N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(PrintNumbers(1,N));
