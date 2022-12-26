System.Console.WriteLine("Введите координату Х точки А: ");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки А: ");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату Z точки А: ");
double z1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату Х точки B: ");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки B: ");
double y2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату Z точки B: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2));
System.Console.WriteLine($"Расстояние между точками А и В составляет: " + Math.Round(distance, 2));
