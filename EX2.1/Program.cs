// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число A: "); //подсказка
int NumberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: "); //подсказка
int NumberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число C: "); //подсказка
int NumberC = Convert.ToInt32(Console.ReadLine());

int NumberMax = 0;

if (NumberA > NumberMax) NumberMax = NumberA;
if (NumberB > NumberMax) NumberMax = NumberB;
if (NumberC > NumberMax) NumberMax = NumberC;

Console.WriteLine("Максимальное " + NumberMax);
