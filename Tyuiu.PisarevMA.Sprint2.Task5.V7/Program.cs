using Tyuiu.PisarevMA.Sprint2.Task5.V7.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 2 | Выполнил: Писарев М. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор switch                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Писарев Максим Алексеевич | АСОиУб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
Console.WriteLine("* требуемое значение и возвращает результат.                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите количество прошедших месяцев: ");
int n = Convert.ToInt32(Console.ReadLine());
int year = 1990;
string res = ds.FindMonthName(year, n);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Ваш месяц: " + res);

Console.ReadKey();