// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int Sum(int a, int b){
    int S=0;
    if (a>b) {
        return S;
    }
    else
    S=a+Sum(a+1,b);
return S;
}

Console.Clear();
Console.WriteLine("Enter number M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(Sum(M,N));