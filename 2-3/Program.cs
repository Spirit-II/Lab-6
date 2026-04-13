using Lab_6_5_2;
internal class Program
{
    static void Main()
    {
        try
        {
            // Ввод координат для первой точки
            Console.WriteLine("Введите координаты для первой точки (x y):");
            string[] input1 = Console.ReadLine().Split();
            if (input1.Length != 2 || !double.TryParse(input1[0], out double x1) || !double.TryParse(input1[1], out double y1))
            {
                throw new ArgumentException("Некорректный ввод для первой точки. Ожидалось два числа через пробел.");
            }
            Point p1 = new Point(x1, y1);

            // Ввод координат для второй точки
            Console.WriteLine("Введите координаты для второй точки (x y):");
            string[] input2 = Console.ReadLine().Split();
            if (input2.Length != 2 || !double.TryParse(input2[0], out double x2) || !double.TryParse(input2[1], out double y2))
            {
                throw new ArgumentException("Некорректный ввод для второй точки. Ожидалось два числа через пробел.");
            }
            Point p2 = new Point(x2, y2);

            Console.WriteLine("Point p1: " + p1);
            Console.WriteLine("Point p2: " + p2);

            // Тестирование метода DistanceTo
            double distance = p1.DistanceTo(p2);
            Console.WriteLine($"Расстояние между p1 и p2: {distance}");

            // Тестирование унарных операций
            p1++;
            Console.WriteLine("After p1++: " + p1);

            p2--;
            Console.WriteLine("After p2--: " + p2);

            // Тестирование операций приведения типа
            int intX = (int)p2;
            Console.WriteLine($"Целая часть X p2: {intX}");

            double y = p1;
            Console.WriteLine($"Значение Y p1: {y}");

            // Тестирование бинарных операций
            double dist = p1 + p2;
            Console.WriteLine($"Расстояние между p1 и p2 с помощью +: {dist}");

            Point p3 = p1 + 5;
            Console.WriteLine("After p1 + 5: " + p3);

            Point p4 = 10 + p2;
            Console.WriteLine("After 10 + p2: " + p4);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
