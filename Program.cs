// Task11: Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Random rnd = new Random();
int number = rnd.Next(10, 100);
Console.WriteLine(number);

int second = number % 10;
int first = number / 10;

if (first > second) Console.WriteLine("Первая цифра " + first + " больше второй " + second);
else Console.WriteLine("Вторая цифра " + second + " больше первой " + first);

