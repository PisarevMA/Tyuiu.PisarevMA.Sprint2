using Tyuiu.PisarevMA.Sprint2.Task6.V8.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 2 | Выполнил: Писарев М. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Получение результата из switch                                    *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Писарев Максим Алексеевич | АСОиУб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите порядковый номер месяца (1-12):");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите день месяца (1-31):");
int day = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

var result = ds.FindDateOfPreviousDay(month, day);
Console.WriteLine(result);

Console.ReadKey();