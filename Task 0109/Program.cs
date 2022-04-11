// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N.

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int m = Promt("Введите значение M => ");
int n = Promt("Введите значение N => ");

for (int i = m; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(" {0} ", i);
    }
}
return 0;


