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

int m, n;
Console.WriteLine("Введите порядковый номер месяца: ");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());
string res;
if ((m < 1 || m > 12) || (n < 1 || n > 31))
{
    res = "Введено неверное значение.";
}
else
{
    res = ds.FindDateOfPreviousDay(m, n);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(res);

Console.ReadKey();