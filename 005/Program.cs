// //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Clear();
// int num = GetNumberFromUser("Введите целое число A: ","Ошибка ввода!");
// int sumNumbers = GetSumNumbers(num);
// Console.WriteLine($"{num} -> {sumNumbers}");
// // Выводит в консоль сообщение message,
// // преобразовывает введённую пользователем строку в число типа int.
// // В случае ошибки выводит в консоль сообщение errorMessage
// int GetNumberFromUser(string message, string errorMessage)
// {
//     while(true)
//     {
//         Console.Write(message);
//         bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
//         if(isCorrect)
//             return userNumber;
//         Console.WriteLine(errorMessage);
//     }
// }
// // Принимает на вход число N и выдаёт произведение чисел от 1 до N 
// int GetSumNumbers(int number);
// {
//     int sum = 1;
//     if (number > 0)
//     {
//         for (int i = 1; i <= number; i++) sum = sum * i;
//     }
//     else if (number < 0)
//     {
//         for (int i = -1; i >= number; i--) sum = sum * i;
//     }
//     else 
//         return 0;
    
//     return sum;
// }

Console.Write("num: ");
int num = int.Parse(Console.ReadLine());
Console.Write("N: ");
int N = int.Parse(Console.ReadLine());

int result = num;
for (int i = num; i <= N; i++)
{
    result *= num;
}
Console.WriteLine($"{num} ^ {N} = {result}");