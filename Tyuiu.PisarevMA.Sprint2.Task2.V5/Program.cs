using Tyuiu.PisarevMA.Sprint2.Task2.V5.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 2 | Выполнил: Писарев М. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнил: Писарев Максим Алексеевич | АСОиУб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в                     *");
Console.WriteLine("* заштрихованной области                                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите x=");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y=");
int y = Convert.ToInt32(Console.ReadLine());
bool res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

if (res)
{
    Console.WriteLine("Точка в фигуре");
}
else
{
    Console.WriteLine("Точка не в фигуре");
}

Console.ReadKey();