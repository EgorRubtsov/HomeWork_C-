int day = new Random(). Next (1, 7);
if (day >= 1 && day <= 5)
{
    System.Console.WriteLine($"Сегодня " + (day) + " день недели, рабочий день(:");
}
else
{
    System.Console.WriteLine($"Сегодня " + (day) + " день недели, выходной, отдыхаем!");
}
