class Program
{
    static void Main(string[] args)
    {
        ShowMenu();
    }

    static void ShowMenu()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Виберіть опцію:");
        Console.WriteLine("1. Перевірка точки в півплощині");
        Console.WriteLine("2. Перевірка точки в півпросторі");
        Console.WriteLine("3. Вихід");

        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 1:
                    CheckPointInHalfPlane();
                    break;
                case 2:
                    CheckPointInHalfSpace();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Неправильний ввід. Спробуйте ще раз.");
        }

        ShowMenu();
    }

    static void CheckPointInHalfPlane()
    {
        Console.WriteLine("Введіть коефіцієнти півплощини (a1, a2, b):");
        Console.WriteLine("Введіть a1");
        double a1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть a2");
        double a2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть b");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть координати точки (x1, x2):");
        Console.WriteLine("Введіть x1");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть x2");
        double x2 = Convert.ToDouble(Console.ReadLine());

        HalfPlane halfPlane = new HalfPlane(a1, a2, b);
        bool result = halfPlane.IsPointInHalfPlane(x1, x2);

        Console.WriteLine($"Точка ({x1}, {x2}) {(result ? "належить" : "не належить")} півплощині.");
    }

    static void CheckPointInHalfSpace()
    {
        Console.WriteLine("Введіть коефіцієнти півпростору (a1, a2, a3, b):");
        Console.WriteLine("Введіть a1");
        double a1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть a2");
        double a2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть a3");
        double a3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть b");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть координати точки (x1, x2, x3):");
        Console.WriteLine("Введіть x1");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть x2");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть x3");
        double x3 = Convert.ToDouble(Console.ReadLine());

        HalfSpace halfSpace = new HalfSpace(a1, a2, a3, b);
        bool result = halfSpace.IsPointInHalfSpace(x1, x2, x3);

        Console.WriteLine($"Точка ({x1}, {x2}, {x3}) {(result ? "належить" : "не належить")} півпростору.");
    }
}