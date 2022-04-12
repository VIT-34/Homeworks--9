// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int m = Promt("Введите значение M => ");
int n = Promt("Введите значение N => ");
int result = 0;
for (int i = m; i <= n; i++)
{
    result +=i;
}
Console.Write($"Сумма чисел M и N равна: {result}");



