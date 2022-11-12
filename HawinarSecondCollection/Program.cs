using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace HawinarSecondCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //ex1Begin22();
                //ex2Integer22();
                //ex3Boolean22();
                //ex4If22();
                //ex5Case1();
                //ex6For22();
                //ex7While22();
                //ex8Series22();
                //ex9Proc22();
                //ex10Proc47();
                //ex11Minmax22();
                //ex12Array22();
                //ex13Array47();
                //ex14Array72();
                //ex15Array97();
                //ex16Array122();
                //ex17Matrix22();
                //ex18Matrix47();
                //ex19Matrix72();
                //ex20Matrix97();
                //ex21String22();
                //ex22String47();
                //ex23File22();
                //ex24File47();
                //ex25File72();
                //ex26Text22();
                //ex27Text47();
                //ex28Param22();
                //ex29Param47();
                //ex30Recur22();
                //ex31Dynamic22();
                //ex32Integer7();
                //ex33If29();
                //ex34Minmax4();
                //ex35Case2();
                //ex36Series1();
                //ex37Boolean21();
                //ex38For1();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка");
            }
        }
        static void ex1Begin22()
        {
            Console.WriteLine("Задание 1:\nВведите значение A:");
            var A = Console.ReadLine();
            Console.WriteLine("Введите значение B:");
            var B = Console.ReadLine();
            var tmp = A;
            A = B;
            B = tmp;
            Console.WriteLine($"Значение A:{A}\nЗначение B:{B}");
        }
        static void ex2Integer22()
        {
            Console.WriteLine("Задание 2:\nВведите количество секунд прошедших с начала суток");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"Прошло {N % 3600} секунд с момента последнего часа");
        }
        static void ex3Boolean22()
        {
            Console.WriteLine("Задание 3:\nВведите трёхзначное число");
            bool isIncreasing = false;
            bool isDecreasing = false;
            string number = Console.ReadLine();
            for (int j = 0; j < number.Length - 1; j++)
            {
                if (int.Parse(number[j].ToString()) < int.Parse(number[j + 1].ToString()))
                    isIncreasing = true;
                else if (int.Parse(number[j].ToString()) > int.Parse(number[j + 1].ToString()))
                    isDecreasing = true;
                else
                {
                    isIncreasing = false;
                    isDecreasing = false;
                }
            }
            Console.WriteLine($"Число {number[0]}{number[1]}{number[2]}:\nВозрастающее:{isIncreasing}\nУбывающее:{isDecreasing}");
        }
        static void ex4If22()
        {

            Console.WriteLine("Задание 4:\nВведите координату x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y:");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
                Console.WriteLine("Точка в 1 четверти");
            else if (x < 0 && y > 0)
                Console.WriteLine("Точка во 2 четверти");
            else if (x < 0 && y < 0)
                Console.WriteLine("Точка в 3 четверти");
            else if (x > 0 && y < 0)
                Console.WriteLine("Точка в 4 четверти");
            else
                Console.WriteLine("Точка на оси x и/или y");
        }
        static void ex5Case1()
        {
            Console.WriteLine("Задание 5:\nВведите номер дня недели:");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Дня недели под этим номером нет");
                    break;
            }
        }
        static void ex6For22()
        {
            Console.WriteLine("Задание 6:\nВведите вещественное число x:");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число N (> 0):");
            int N = int.Parse(Console.ReadLine());
            double result = 0;
            double factorial = 1;
            for (int i = 1; i < N + 1; i++)
            {
                for (int j = 1; j < i + 1; j++)
                    factorial *= j;
                result += x + (Math.Pow(x, i) / factorial);
                factorial = 1;
            }
            Console.WriteLine(result + 1);
        }
        static void ex7While22()
        {
            bool simple = true;
            Console.WriteLine("Задание 7:\nВведите число:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n - 1; i++)
                if (n % i == 0)
                {
                    simple = false;
                    break;
                }
            Console.WriteLine($"Число {n} простое - {simple}");
        }
        static void ex8Series22()
        {
            Console.WriteLine("Задание 8:\nВведите кол-во вещественных чисел");
            int isDecreasing = 0;
            int N = int.Parse(Console.ReadLine());
            double[] numbers = new double[N];
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                Console.WriteLine($"Введите {i + 1}-е число");
                numbers[i] = double.Parse(Console.ReadLine());
            }
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                if (double.Parse(numbers[j].ToString()) > double.Parse(numbers[j + 1].ToString()))
                    isDecreasing = 0;
                else
                {
                    isDecreasing = j + 1;
                    break;
                }
            }
            Console.WriteLine($"\n{isDecreasing}\nЕсли число сверху = 0, то последовательность убывющая, иначе, номер числа, где нарушена закономерность");
        }
        static void ex9Proc22()
        {
            Console.WriteLine("Задание 9:\nВведите число A:");
            float A = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B:");
            float B = float.Parse(Console.ReadLine());
            Console.WriteLine("Выберите операнд: 1 — вычитание, 2 — умножение, 3 — деление, остальные значения — сложение.");
            int Op = int.Parse(Console.ReadLine());
            switch (Op)
            {
                case 1:
                    Console.WriteLine(Calc(A, B, Op));
                    break;
                case 2:
                    Console.WriteLine(Calc(A, B, Op));
                    break;
                case 3:
                    Console.WriteLine(Calc(A, B, Op));
                    break;
                default:
                    Console.WriteLine(Calc(A, B, Op));
                    break;
            }
            float Calc(float A, float B, int Op)
            {
                switch (Op)
                {
                    case 1:
                        return A - B;
                    case 2:
                        return A * B;
                    case 3:
                        return A / B;
                    default:
                        return A + B;
                }
            }
        }
        static void ex10Proc47()
        {
            Console.WriteLine("Задание 10:\n");
            Console.WriteLine("Введите a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b ( > 0 ):");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Frac1(a, b).Item1 + "/" + Frac1(a, b).Item2);
            static (int, int) Frac1(int a, int b)
            {
                int p, q;
                for (int i = a + b; i > 0; i--)
                {
                    if (a % i == 0 && b % i == 0)
                        a /= i; b /= i;
                }
                if (a / b < 0)
                {
                    a = -a;
                    b = Math.Abs(b);
                }
                p = a;
                q = b;
                return (p, q);
            }
        }
        static void ex11Minmax22()
        {
            Console.WriteLine("Задание 11:\n");
            Console.WriteLine("Введите N:");
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1}-й элемент");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            Console.WriteLine($"Два наименьших числа в массиве в порядке возрастания: {numbers[0]} и {numbers[1]}");
        }
        static void ex12Array22()
        {
            Console.WriteLine("Задание 12:\n");
            Console.WriteLine("Введите N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите K (1 < K):");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите L (L <= N):");
            int L = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1}-й элемент");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
                if (i < K - 1 || i > L - 1)
                    sum += numbers[i];
            Console.WriteLine($"Сумма: {sum}");
        }
        static void ex13Array47()
        {
            Console.WriteLine("Задание 13:\n");
            Console.WriteLine("Введите N:");
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            string uniqueNumbers = string.Empty;
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1}-й элемент");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < numbers.Length; j++)
                if (!uniqueNumbers.Contains(numbers[j].ToString() + ", "))
                {
                    uniqueNumbers += numbers[j].ToString() + ", ";
                    count++;
                }
            Console.WriteLine($"Уникальных значений: {count}");
        }
        static void ex14Array72()
        {
            Console.WriteLine("Задание 14:\nВведите число N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число K (1 <= K):");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число L (K < L <= N):");
            int L = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int tmp = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1}-й элемент:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            while (K < L)
            {
                tmp = numbers[K - 1];
                numbers[K - 1] = numbers[L - 1];
                numbers[L - 1] = tmp;
                K++;
                L--;
            }
            for (int j = 0; j < numbers.Length; j++)
                Console.WriteLine($"{j + 1}) {numbers[j]}");
        }
        static void ex15Array97()
        {
            Console.WriteLine("Задание 15:\n");
            const int N = 10;
            int[] numbers = new int[N] { 1, 2, 1, 3, 4, 5, 6, 4, 4, 4 }; //2,1,3,5,6,4
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int[] sorted = new int[N];

            for (int i = numbers.Length - 1; i > 0; i--)
                for (int j = 0; j < nums.Length; j++)
                    if (numbers[i] == nums[j])
                    {
                        sorted[i] = nums[j];
                        nums[j] = int.MaxValue;
                    }
            for (int k = 0; k < sorted.Length; k++)
                if (sorted[k] != 0)
                    Console.WriteLine(sorted[k]);
        }
        static void ex16Array122()
        {
            Console.WriteLine("Задание 16:\n");
            int K = 3;
            int[] series = { 111111, 2222222, 444444, 3333333, 5555555, 66666 };
            for (int i = 0; i < series.Length; i++)
                if (!(series.Length < K))
                    if (i != K - 1)
                        Console.WriteLine(series[i]);
                    else
                        Console.WriteLine(series[i]);
        }
        static void ex17Matrix22()
        {
            Console.WriteLine("Задание 17:\n");
            const int M = 5;
            const int N = 5;
            int[] sum = new int[M];
            int[,] matrix = new int[M, N] { { 1, 2, 3, 4, 5},
                                            { 5, 4, 3, 2, 1 },
                                            { 1, 2, 3, 4, 5 },
                                            { 1, 2, 3, 4, 5 },
                                            { 1, 2, 3, 4, 5 }, };
            for (int j = 1; j < N; j += 2)
                for (int i = 0; i < M; i++)
                    sum[j] += matrix[i, j];

            for (int k = 0; k < sum.Length; k++)
                Console.WriteLine(sum[k]);
        }
        static void ex18Matrix47()
        {
            Console.WriteLine("Задание 18:\n");
            const int M = 5;
            const int N = 5;
            int[,] matrix = new int[M, N] { { 1, 2, 3, 4, 5},
                                            { 5, 4, 3, 2, 1 }, //[1,0] [1,1] [1,2] [1,3] [1,4]
                                            { 1, 2, 3, 4, 5 },
                                            { 1, 2, 3, 4, 5 }, //[3,0] [3,1] [3,2] [3,3] [3,4]
                                            { 1, 2, 3, 4, 5 }, };
            int k1 = 2;
            int k2 = 4;
            int tmp = 0;
            for (int i = k1 - 1; i < k2;)
            {
                for (int j = k2 - 1; j < N;)
                {
                    for (int k = 0; k < M; k++)
                    {
                        tmp = matrix[i, k];
                        matrix[i, k] = matrix[j, k];
                        matrix[j, k] = tmp;
                    }
                    break;
                }
                break;
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(matrix[i, j] + ", ");
                Console.WriteLine();
            }
        }
        static void ex19Matrix72()
        {
            Console.WriteLine("Задание 19:\n");
            const int M = 5;
            const int N = 5;
            bool isPositive = true; //Число положительное?
            bool isAvailable = false; //Есть ли столбец, в котором были бы только положительные числа?
            int target = 0;
            int[,] matrix = new int[M, N] { { -3, 2, 3, 4, 5},
                                            { -5, 4, 3, 2, 1 },
                                            { -11, 2, 3, -4, 5 },
                                            { 32, -2, 3, 4, 5 },
                                            { 15, -2, 3, 4, 5 }, };

            int[,] matrixFinal = new int[M, N + 1]; //Создание нового двумерного массива с расчётом на новый столбец.

            //Проверка на наличие столбца, в котором были бы только положительные числа
            for (int j = 0; j < N; j++)
            {
                isPositive = true;
                for (int i = 0; i < M; i++)
                    if (matrix[i, j] < 0)
                    {
                        isPositive = false;
                        break;
                    }
                if (isPositive == true)
                {
                    isAvailable = true;
                    target = j;
                    break;
                }
            }
            //Заполнение происходит в 3 этапа:
            //1) Заполняются столбцы, которые были до первого "положительного" столбца из исходной матрицы
            //2) Заполняется столбец с единицами
            //3) Заполняются столбцы, которые были после первого "положительного" столбца из исходной матрицы

            if (isAvailable == true)
            {
                //Этап 1
                for (int j = 0; j < target; j++)
                    for (int k = 0; k < M; k++)
                        matrixFinal[k, j] = matrix[k, j];
                //Этап 2
                for (int j = target; j == target; j++)
                    for (int k = 0; k < M; k++)
                        matrixFinal[k, j] = 1;
                //Этап 3
                for (int j = target + 1; j < N + 1; j++)
                    for (int k = 0; k < M; k++)
                        matrixFinal[k, j] = matrix[k, j - 1];
                //Вывод
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N + 1; j++)
                        Console.Write(matrixFinal[i, j] + ", ");
                    Console.WriteLine();
                }

            }
            else
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                        Console.Write(matrix[i, j] + ", ");
                    Console.WriteLine();
                }
        }
        static void ex20Matrix97()
        {
            Console.WriteLine("Задание 20:\n");
            const int M = 5; //Порядок матрицы
            int tmp = 0;
            int[,] matrixA = new int[M, M]{ { 11, 12, 13, 14, 15},
                                            { 21, 22, 23, 24, 25 }, //[1,0] [1,1] [1,2] [1,3] [1,4]
                                            { 31, 32, 33, 34, 35 },
                                            { 41, 42, 43, 44, 45 }, //[3,0] [3,1] [3,2] [3,3] [3,4]
                                            { 51, 52, 53, 54, 55 }, };
            for (int i = 0; i < M; i++)
                for (int j = 0; j < M; j++)
                {
                    tmp = matrixA[i, j];
                    matrixA[i, j] = matrixA[M - j - 1, M - i - 1];
                    matrixA[M - j - 1, M - i - 1] = tmp;
                }
            for (int k = 0; k < M; k++)
            {
                for (int n = 0; n < M; n++)
                    Console.Write(matrixA[k, n] + ", ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void ex21String22()
        {
            Console.WriteLine("Задание 21:\n");
            string numbers = "1122313";
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
                sum += int.Parse(numbers[i].ToString());
            Console.WriteLine(sum);
        }
        static void ex22String47()
        {
            string text = "Ланнистеры всегда платят свои долги";
            Console.WriteLine("\nЗадание 22:\n" + text.Replace(" ", "."));
        }
        static void ex23File22()
        {
            Console.WriteLine("\nЗадание 23:\n");
            string path = Directory.GetCurrentDirectory() + "\\local\\File22\\File22toRead.txt";
            string text = string.Empty;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                    text = sr.ReadLine();
                fs.Close();
            }
            double[] mass = new double[text.Split(", ").Length];
            for (int i = 0; i < text.Split(", ").Length; i++)
                mass[i] = double.Parse(text.Split(", ")[i], CultureInfo.InvariantCulture);

            string result = string.Empty;
            int current = 0;
            int next = 1;
            int nextnext = 2;
            for (; current < mass.Length;)
            {
                for (; next < mass.Length;)
                {
                    for (; nextnext < mass.Length;)
                    {
                        if (mass[current] > mass[next] && mass[current] < mass[nextnext])
                            result += $"{next},";
                        else if (mass[current] > mass[next]) //Условие для того, чтобы зафиксировать минимальный экстремум.
                                                             //Число, которое меньше предыдушего и также меньше следующего и будет локальным минимальным экстремумом.
                            result += $"{current},";

                        current++;
                        next++;
                        nextnext++;
                    }
                    break;
                }
                break;
            }
            string[] array = new string[result.Split(",").Length];
            array = result.Split(",");
            Array.Reverse(array, 0, array.Length);
            result = String.Join(", ", array);
            result = result.Remove(0, 2);
            path = Directory.GetCurrentDirectory() + "\\local\\File22\\File22toWrite.txt";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                    sw.WriteLine(result);
            }
        }
        static void ex24File47()
        {
            Console.WriteLine("\nЗадание 24:\n");
            string path = Directory.GetCurrentDirectory() + "\\local\\File47\\First.txt";
            string firstText = string.Empty;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                    firstText = sr.ReadToEnd();
                fs.Close();
            }
            path = Directory.GetCurrentDirectory() + "\\local\\File47\\Second.txt";
            string secondText = string.Empty;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                    secondText = sr.ReadToEnd();
                fs.Close();
            }
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                    sw.WriteLine($"\n{firstText}");
                fs.Close();
            }
            path = Directory.GetCurrentDirectory() + "\\local\\File47\\First.txt";
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                    sw.WriteLine($"\n{secondText}");
                fs.Close();
            }
        }
        static void ex25File72()
        {
            Console.WriteLine("\nЗадание 25:\n");
            //Считываем даты с файла
            string path = Directory.GetCurrentDirectory() + "\\local\\File72\\File72.txt";
            string text = string.Empty;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                    text = sr.ReadToEnd();
                fs.Close();
            }
            text = text.Replace("\r\n", "/");
            string[] sortedText = text.Split("/");

            int minDay = int.MaxValue;
            int minMonth = int.MaxValue;
            int minYear = int.MaxValue;

            int isAvailable = 0;
            for (int i = 1; i < sortedText.Length; i += 3) //Месяцы
                if (sortedText[i] == "09" || sortedText[i] == "10" || sortedText[i] == "11")
                    isAvailable++;

            if (isAvailable == 0)
                Console.WriteLine();
            else
            {
                string[] massAutumn = new string[isAvailable * 3];
                int massAutumnChecker = 0;
                int sortedTextChecker = 1;
                for (; massAutumnChecker < massAutumn.Length; massAutumnChecker += 3)
                    for (; sortedTextChecker < sortedText.Length; sortedTextChecker += 3) //Месяцы
                        if (sortedText[sortedTextChecker] == "09" || sortedText[sortedTextChecker] == "10" || sortedText[sortedTextChecker] == "11")
                        {
                            massAutumn[massAutumnChecker] = sortedText[sortedTextChecker - 1];
                            massAutumn[massAutumnChecker + 1] = sortedText[sortedTextChecker];
                            massAutumn[massAutumnChecker + 2] = sortedText[sortedTextChecker + 1];
                            sortedTextChecker += 3;
                            break;
                        }
                //Получив все осенние даты, ищем из них самую раннюю
                //Сначала выбираем самый ранний год
                for (int i = 2; i < massAutumn.Length; i += 3)
                    if (int.Parse(massAutumn[i]) < minYear)
                        minYear = int.Parse(massAutumn[i]);
                //Ищем самый ранний месяц в году
                for (int j = 1; j < massAutumn.Length; j += 3)
                    if (int.Parse(massAutumn[j + 1]) == minYear)
                        if (int.Parse(massAutumn[j]) < minMonth)
                            minMonth = int.Parse(massAutumn[j]);

                for (int i = 0; i < massAutumn.Length; i += 3)
                    if (int.Parse(massAutumn[i + 2]) == minYear && int.Parse(massAutumn[i + 1]) == minMonth)
                        if (int.Parse(massAutumn[i]) < minDay)
                            minDay = int.Parse(massAutumn[i]);
                //Зная всю эту информацию, просто её выводим.
                for (int i = 0; i < massAutumn.Length; i += 3)
                    if (int.Parse(massAutumn[i]) == minDay && int.Parse(massAutumn[i + 1]) == minMonth && int.Parse(massAutumn[i + 2]) == minYear)
                        Console.WriteLine($"Самая поздняя дата осени: {massAutumn[i]}/{massAutumn[i + 1]}/{massAutumn[i + 2]}");
            }
        }
        static void ex26Text22()
        {
            Console.WriteLine("\nЗадание 26:\n");
            Console.WriteLine("Введите значение K (0 < K < 10)");
            int K = int.Parse(Console.ReadLine());

            string path = Directory.GetCurrentDirectory() + "\\local\\Text22\\Text22.txt";
            string[] text;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                text = File.ReadAllLines(path);
                fs.Close();
            }
            string[] sortedText = new string[text.Length - K];
            for (int i = 0; i < sortedText.Length; i++)
                sortedText[i] = text[i];
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    for (int i = 0; i < sortedText.Length; i++)
                        sw.WriteLine(sortedText[i]);
                }
                fs.Close();
            }
        }
        static void ex27Text47()
        {
            Console.WriteLine("\nЗадание 26:\n");
            string path = Directory.GetCurrentDirectory() + "\\local\\Text47\\Text47.txt";
            string[] text;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                text = File.ReadAllLines(path);
                fs.Close();
            }
            int intCount = 0;
            int intSum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i][0] == ' ') { }
                else
                {
                    intCount++;
                    intSum += int.Parse(text[i]);
                }
            }
            Console.WriteLine($"Количество целых чисел: {intCount}\nСумма целых чисел: {intSum}");
        }
        static void ex28Param22()
        {
            Console.WriteLine("Задание 28:\n");
            Console.WriteLine("Введите номер столбца k:");
            int K = int.Parse(Console.ReadLine());
            const int M = 5;
            const int N = 5;
            double SumCol(int K)
            {
                double sum = 0;
                double[,] matrix = new double[M, N] { { 1.1, 1.2, 1.3, 1.4, 1.5},
                                                  { 2.1, 2.2, 2.3, 2.4, 2.5 }, //[1,0] [1,1] [1,2] [1,3] [1,4]
                                                  { 3.1, 3.2, 3.3, 3.4, 3.5 },
                                                  { 4.1, 4.2, 4.3, 4.4, 4.5 }, //[3,0] [3,1] [3,2] [3,3] [3,4]
                                                  { 5.1, 5.2, 5.3, 5.4, 5.5 }, };
                for (int j = K; j == K; j++)
                    for (int i = 0; i < M; i++)
                        sum += matrix[i, j];
                return sum;
            }
            Console.WriteLine($"Сумма: {SumCol(K)}");
        }
        static void ex29Param47()
        {
            Console.WriteLine("Задание 29:\nВведите число в 16-ричной системе счисления:");
            string hexNumber = Console.ReadLine();
            int HexToDec(string S) => int.Parse(S, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(HexToDec(hexNumber));
        }
        static void ex30Recur22()
        {
            Console.WriteLine("Задание 30:\n");
            string[] pool;
            string[] expressions = { "18","M(8,10,9)", "4","m(1,5,3,5,-1,0)", "M(8,10,9)", "m(1,5,3,5,-1,0)", "m(1,5,3,5,-1,0)" };
            
            int M(string[] pool)
            {
                int Max = int.MinValue;
                for(int i = 0; i < pool.Length; i++)
                    if (int.Parse(pool[i].ToString()) > Max)
                        Max = int.Parse(pool[i]);
                return Max;
            }
            int m(string[] pool)
            {
                int Min = int.MaxValue;
                for (int i = 0; i < pool.Length; i++)
                    if (int.Parse(pool[i].ToString()) < Min)
                        Min = int.Parse(pool[i]);
                return Min;
            }
            for(int i = 0; i < expressions.Length; i++)
            {
                for(int j = 0; j < expressions[i].Length; j++)
                {
                    pool = expressions[i].Replace("(", "").Replace(")", "").Replace("M", "").Replace("m", "").Split(",");
                    if (expressions[i][j] == 'M')
                    {
                        Console.WriteLine(M(pool));
                        break;
                    }
                    else if (expressions[i][j] == 'm')
                    {
                        Console.WriteLine(m(pool));
                        break;
                    }
                    else if(int.Parse(expressions[i][j].ToString()) > 0  && int.Parse(expressions[i][j].ToString()) < 10)
                    {
                        Console.WriteLine(pool[0]);
                        break;
                    }
                }             
            }
        }
        static void ex31Dynamic22()
        {
            Console.WriteLine("Задание 31:\nВведите число K ( K > 0):");
            int N = int.Parse(Console.ReadLine());
            var numbers1 = new List<int> { 0, 1, 2, 3, 4, 5 };
            var numbers2 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7};
            Queue<int> queue1 = new Queue<int>(numbers1);
            Queue<int> queue2 = new Queue<int>(numbers2);
            if(N > queue1.Count)
                N = queue1.Count;
            for(int i = 0; i < N; i++)
            {
                int tmp = queue1.Dequeue();
                queue2.Enqueue(tmp);
            }
            foreach (int i in queue1)
                Console.Write($"{i}, ");
            Console.WriteLine();
            foreach (int i in queue2)
                Console.Write($"{i}, ");
        }
        static void ex32Integer7()
        {
            string number = "42";
            Console.WriteLine($"\nЗадание 32:\nСумма: {int.Parse(number[0].ToString()) + int.Parse(number[1].ToString())}" +
                $"\nПроизведение {int.Parse(number[0].ToString()) * int.Parse(number[1].ToString())}");
        }
        
        static void ex33If29()
        {
            int[] numbers = new int[] { -20, -5, 0, 17, 30, 5, -1, -2};
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] < 0)
                    Console.Write($"Четное отрицательное число, ");
                else if (numbers[i] % 2 != 0 && numbers[i] < 0)
                    Console.Write($"Нечетное отрицательное число, ");
                else if (numbers[i] == 0)
                    Console.Write($"Нулевое число, ");
                else if (numbers[i] % 2 != 0 && numbers[i] > 0)
                    Console.Write($"Нечетное положительное число, ");
                else if (numbers[i] % 2 == 0 && numbers[i] > 0)
                    Console.Write($"Четное положительное число, ");
            }
        }    
        static void ex34Minmax4()
        {
            int[] numbers = { 1, 5, 4, 6, 23, 6, 3, 6, 1, 65, 3, 6, 5, -4, 4 };
            int min = numbers.Min();
            int max = numbers.Max();
            Console.WriteLine($"\nЗадание 34:\nМинимальное значение = {min}\nМаксимальное значение = {max}");
        }
        static void ex35Case2()
        {
            Console.WriteLine("\nЗадание 35:\nВведите число [1-7]:");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1: 
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Ошибка");              
                    break;
            }
        }
        static void ex36Series1()
        {
            decimal[] numbers = { 1.1M, 3.22M, 3.14M, 2.17M, 645.4M, 36.6M, 69.96M, 432.5M, 34.2M, 65.4M };
            decimal sum = numbers.Sum();
            Console.WriteLine($"\nЗадание 36:\nСумма: {sum}");
        }
        static void ex37Boolean21()
        {
            Console.WriteLine("\nЗадание 37:\nЦифры следующих чисел будут проверены на возрастающую последовательность:\n");
            string[] numbers = { "123", "324", "345", "109" };
            for (int i = 0; i < numbers.Length; i++)
                Console.Write($"{numbers[i]}, ");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
                    Console.Write($"{int.Parse(numbers[i][0].ToString()) < int.Parse(numbers[i][1].ToString()) && int.Parse(numbers[i][1].ToString()) < int.Parse(numbers[i][2].ToString())}, ");
        }
        static void ex38For1()
        {
            Console.WriteLine("\nЗадание 38:\nВведите число K:");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число N ( N > 0)");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
                Console.WriteLine(K);
        }

    }
    
}