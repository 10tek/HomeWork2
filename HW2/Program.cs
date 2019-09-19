using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
            /*Random random = new Random();
            Console.WriteLine($"{random.Next(0, 100)} {random.Next(0, 100)} {random.Next(0, 100)}");*/

            //Вывести на экран числа 5, 10 и 21 одно под другим.
            //Console.WriteLine("5\n10\n21");

            //Дано расстояние в сантиметрах. Найти число полных метров в нем.
            /*int centimeters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В {centimeters}см полных метров: {centimeters / 100}");*/

            //С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
            /*int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{days} дней, это {days / 7} полных недель.");*/

            //Дано двузначное число.Найти:
            //число десятков в нем;
            //число единиц в нем;
            //сумму его цифр;
            //произведение его цифр
            /*int number = Convert.ToInt32(Console.ReadLine());
            int dozens = number / 10;
            int units = number % 10;
            int sum = dozens + units;
            int product = dozens * units;
            Console.WriteLine($"Число десяток: {dozens};\nЧисло единиц: {units};\nСумма цифр: {sum};\nПроизведение цифр: {product};");*/

            //Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
            /*bool isA = true;
            bool isB = false;
            bool isC = false;
            Console.WriteLine($"А или В: {isA || isB}");
            Console.WriteLine($"А и В: {isA && isB}");
            Console.WriteLine($"B или C: {isB || isC}");*/

            //Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
            /*double radius = Convert.ToDouble(Console.ReadLine());
            double squareSide = Convert.ToDouble(Console.ReadLine());
            if(Math.PI*Math.Pow(radius, 2) > Math.Pow(squareSide, 2))
            {
            Console.WriteLine("У круга больше");
            }
            else
            {
            Console.WriteLine("У square больше");
            }*/

            //Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?
            /*double volumeFirst = Convert.ToDouble(Console.ReadLine());
            double massFirst = Convert.ToDouble(Console.ReadLine());
            double volumeSecond = Convert.ToDouble(Console.ReadLine());
            double massSecond = Convert.ToDouble(Console.ReadLine());
            if (massFirst / volumeFirst > massSecond / volumeSecond)
            {
            Console.WriteLine("У первого больше");
            }
            else
            {
            Console.WriteLine("У второго больше");
            }*/

            //Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?
            /*double rFirst = Convert.ToDouble(Console.ReadLine());
            double uFirst = Convert.ToDouble(Console.ReadLine());
            double rSecond = Convert.ToDouble(Console.ReadLine());
            double uSecond = Convert.ToDouble(Console.ReadLine());

            if (uFirst / rFirst < uSecond / rSecond)
            {
            Console.WriteLine("У первого less");
            }
            else
            {
            Console.WriteLine("У второго less");
            }*/

            //все целые числа от 20 до 35;
            /*for(int i = 20; i < 35; i++)
            {
            Console.WriteLine(i);
            }*/

            //квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
            /*int numberB = Convert.ToInt32(Console.ReadLine());
            for(int i = 10; i < numberB; i++)
            {
            Console.Write($"{Math.Pow(i, 2)} ");
            }*/

            //третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
            /*int numberA = Convert.ToInt32(Console.ReadLine());
            while(numberA < 50)
            {
            Console.WriteLine($"{Math.Pow(numberA, 3)} ");
            numberA++;
            }*/

            //все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).
            /*int numberA = Convert.ToInt32(Console.ReadLine());
            int numberB = Convert.ToInt32(Console.ReadLine());
            while (numberA < numberB)
            {
                Console.WriteLine($"{numberA} ");
                numberA++;
            }*/

            Console.ReadKey();
        }
        
    }
}
