// Доп. задание №1:

// Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада. 
// На вход будет подаваться число (сумма вклада). При значении меньше 100, будет начислено 5 %, 
// если значение находится в диапазоне от ста до двухсот — 7 %, если больше — 10 %. Отработав, 
// программа должна вывести общую сумму с начисленными процентами. 

Console.WriteLine("Введите сумму вклада");
//int contr = Convert.ToInt32(Console.ReadLine());
if (!double.TryParse(Console.ReadLine(), out double contr))
{
  Console.WriteLine("Введено не число");
  return;
}
double perc = 0;
    if (contr < 100 && contr > 0)
    {
      Console.WriteLine("Процентаная ставка 5%");
      perc = contr / 100 * 5;
    }
        else if (contr >= 100 && contr <= 200)
        {
        Console.WriteLine("Процентаная ставка 7%");
        perc = contr / 100 * 7;
        }
            else if (contr > 200)
            {
            Console.WriteLine("Процентаная ставка 10%");
            perc = contr / 100 * 10;
            }
    else
    {
    Console.WriteLine("Введено неверное число");
    return;
    }
//Console.Write(Math.Round(summ, 2));
Console.Write($"Сумма с процентами равна: {(contr + perc):f2}");