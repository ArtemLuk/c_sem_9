// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных 
//числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Enter number M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(Akk(M,N));

int Akk(int m, int n){
    if (n == 0)                 return (m+1);
    if ((n != 0) && (m == 0))   return Akk(m-1, 1);
    else Akk((m-1), Akk(m, n - 1));
return Akk(m,n);
}


    
 