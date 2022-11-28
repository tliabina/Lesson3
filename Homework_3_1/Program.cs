// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет 12821 -> да 23432 -> да

Console.WriteLine("Введите число ");
//int num = Convert.ToInt32(Console.ReadLine());
string input = Console.ReadLine() ?? string.Empty;

bool result = true;

for (int i = 0; i < input.Length; i++)
{
    int j = input.Length - 1 - i;

    if (input[i] != input[j])
    {
        result = false;
        break;
    }
}

Console.WriteLine(result);
