using ComplexNumbers;

namespace program
{
    class Program
    {
        static List<ComplexNumber> numbers = new List<ComplexNumber>();

        static void Main(string[] args)
        {
            bool working = true;
            while (working)
            {
                Console.WriteLine("1. создать комплексное число 2. показать все числа 3. сложить 4. умножить 5. выход");
                var input = Console.ReadLine()!;
                switch (input)
                {
                    case "1":
                        Console.WriteLine();
                        Create();
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine();
                        ShowAll();
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine();
                        Add();
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine();
                        Multi();
                        Console.WriteLine();
                        break;
                    case "5":
                        working = false;
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
        }

        public static void Create()
        {
            try
            {
                Console.Write("Введите x: ");
                var x = double.Parse(Console.ReadLine()!);
                Console.Write("Введите y: ");
                var y = double.Parse(Console.ReadLine()!);
                var number = new ComplexNumber(x, y);
                numbers.Add(number);
            }
            catch
            {
                Console.WriteLine("Ошибка ввода!");
                return;
            }
        }

        public static void ShowAll()
        {
            var index = 1;
            foreach(var number in numbers)
            {
                Console.WriteLine(index.ToString() + ". " + number.View());
                index++;
            }
        }

        public static void Add()
        {
            try
            {
                Console.Write("Введите индекс первого числа: ");
                var index1 = int.Parse(Console.ReadLine()!);
                Console.Write("Введите индекс второго числа: ");
                var index2 = int.Parse(Console.ReadLine()!);
                Console.WriteLine(ComplexNumber.ComplexNumbersAddition(numbers[index1-1], numbers[index2-1]));
            }
            catch
            {
                Console.WriteLine("Ошибка!");
                return;
            }
            
        }

        public static void Multi()
        {
            try
            {
                Console.Write("Введите индекс первого числа: ");
                var index1 = int.Parse(Console.ReadLine()!);
                Console.Write("Введите индекс второго числа: ");
                var index2 = int.Parse(Console.ReadLine()!);
                Console.WriteLine(ComplexNumber.ComplexNumbersMultiply(numbers[index1 - 1], numbers[index2 - 1]));
            }
            catch
            {
                Console.WriteLine("Ошибка!");
                return;
            }
        }
    }
}