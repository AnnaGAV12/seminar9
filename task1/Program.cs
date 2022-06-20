// Показать натуральные числа от N до 1, N задано
void PrintNumber(int n)
{
    Console.Write(n + " ");
    n--;
    if(n == 0) return;
    PrintNumber(n);
}
int N = 20;
PrintNumber(N);

// void Num(int n)
//{
//    if (n>0)
//    {
//     Console.WriteLine("{0}",n);
//     Num(n-1);
//    }
//}
//Console.WriteLine("Введите число ");
//int n=int.Parse(Console.ReadLine());
//Num(n);