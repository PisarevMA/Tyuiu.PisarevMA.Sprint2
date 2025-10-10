using Tyuiu.PisarevMA.Sprint2.Task1.V2.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 2 | Выполнил: Писарев М. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Писарев Максим Алексеевич | АСОиУб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений и логических операций, а также *");
Console.WriteLine("* арифметических выражений,которая вернет логическую                      *");
Console.WriteLine("* последовательность(массив)                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int a = 135;
int b = 156;
int c = 154;
int d = 174;
bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);
Console.WriteLine("d = " + d);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}


Console.ReadKey();
