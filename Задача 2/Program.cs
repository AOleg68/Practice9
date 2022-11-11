// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//  в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputM(string M)
{
    Console.Write(M);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int InputN(string N)
{
    Console.Write(N);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void Sum(int M, int N)
{
    int sum = 0;
    if (M <= N)
    {
        while (M <= N)
        {
            sum = sum + M;
            M++;
        }
        Console.Write(sum);
    }
    else 
    {
        Console.WriteLine ("Операция невозможна");
    }    
}



int M = InputM("Введите M: ");
int N = InputN("Введите N: ");
Sum(M, N);


