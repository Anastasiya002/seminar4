// Задача 24. Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А (4 -> (1+2+3+4) -> 10)
Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ","Ошибка ввода!");
int sumNumbers = GetSumNumbers(num);
Console.WriteLine($"{num} -> {sumNumbers}");
// Выводит в консоль сообщение message,
// преобразовывает введённую пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
// Принимает на вход число N и выдаёт произведение чисел от 1 до N 
int GetSumNumbers(int number)
{
    int sum = 1;
    if (number > 0)
    {
        for (int i = 1; i <= number; i++) sum = sum * i;
    }
    else if (number < 0)
    {
        for (int i = -1; i >= number; i--) sum = sum * i;
    }
    else 
        return 0;
    
    return sum;
}