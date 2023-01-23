using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrVar = new int[] { 5, 3, 12, 42, -23 };
            var strVar = "ABCD";
            Console.WriteLine(LocalFunction(arrVar, strVar));



            int a = 0;
            bool b = false;
            string c = "priv";
            long d = 121241241312;
            double e = 1.2;
            byte f = 254;
            sbyte g = -101;
            char i = 'a';
            uint j = 10u;

            Console.WriteLine($"int {a} bool {b} string {c} long {d} double {e} byte {f} sbyte {g} uint {j} char {i} ");

            //явн
            byte number = 128;
            Console.WriteLine("byte" + " to int" + (int)number);
            Console.WriteLine("byte" + " to long" + (long)number);
            Console.WriteLine("byte" + " to double" + (double)number);
            Console.WriteLine("byte" + " to float" + (float)number);

            //неявн
            int num = 223;
            double dnum = num;
            float fnum = num;
            Console.WriteLine($" {dnum} {num} {fnum}");


            //упаковка
            int aaa = 1;
            object bbb = aaa;

            //распаковка
            int ccc = (int)bbb;


            var numm = 754;
            var name = "Sasha";
            var night = true;

            if (night) Console.WriteLine(name + " go to sleep!");


            //nullable



            //var an = 123;
            //an = 12.23;

            //строки

            string str1 = "Hi";
            string str2 = "Hello";
            string str3 = "Hi";
            Console.WriteLine(str1 == str2);
            Console.WriteLine(str1 == str3);

            string str4 = "Hello world";
            string str5 = "Im Sasha";
            string str6 = "C#";

            Console.WriteLine(str4 += str5); //сцеп

            string[] words = str4.Split();
            Console.WriteLine(words[0]); //разделение на слова

            str4 = str4.Insert(11, str6); //вставка
            Console.WriteLine(str4);


            str4 = str4.Remove(0, 2); //удаление
            Console.WriteLine(str4);

            string first = null;
            string second = "";

            if (String.IsNullOrEmpty(first)) Console.WriteLine("null");

            else Console.WriteLine("empty");

            if (String.IsNullOrEmpty(second)) Console.WriteLine("null");

            else Console.WriteLine("empty");



            var sb = new System.Text.StringBuilder();

            for (int ti = 0; ti < 10; ti++) sb.Append(ti);

            Console.WriteLine(sb.ToString()); // 0123456789

            sb[7] = sb[1];

            Console.WriteLine(sb.ToString()); // 0123456189


            int[,] array1 = { { 1, 0, 1 }, { 0, 1, 0 }, { 1, 0, 1 } };
            for (int iii = 0; iii < 3; iii++)
            {
                for (int jjj = 0; jjj < 3; jjj++)
                {
                    Console.Write($"{array1[iii, jjj]}\t");
                }
                Console.Write("\n");
            }

            string[] array = { "apple", "banana", "cherry" };
            for (int ii = 0; ii < array.Length; ii++)
            {
                Console.WriteLine(array[ii]);
            }
            Console.WriteLine();

            Console.WriteLine("Dlina" + array.Length);

            Console.WriteLine("позицию: ");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("напиши слово: ");
            string newValue = Console.ReadLine();
            array[position] = newValue;

            for (int ii = 0; ii < array.Length; ii++)
            {
                Console.Write(array[ii] + " \n");


                var array3 = new[] { 1, 2, 3, 4, 5 };
                var str10 = new[] { "lol", "priv" };
            }


            (int, string, char, string, ulong) tpl = (19, "Sasha", 'a', "Priv", 546);
            Console.WriteLine("возраст:   " + tpl.Item1);
            Console.WriteLine("имя:       " + tpl.Item2);
            Console.WriteLine("пол:       " + tpl.Item3);
            Console.WriteLine("фамилия:   " + tpl.Item4);
            Console.WriteLine("число:     " + tpl.Item5);

            Console.Write(tpl.Item1 + " " + tpl.Item3 + " " + tpl.Item4);
            //распаковка
            (var rr, var qq) = (" 123 ", 456);
            Console.WriteLine($"{rr}{qq}");


            static (int, int, int, char) LocalFunction(int[] arrVar, string strVar)
            {
                int maxArrayElement = arrVar.Max();
                int minArrayElement = arrVar.Min();
                int arrayElementsSum = arrVar.Sum();
                char firstStringChar = strVar[0];
                return (maxArrayElement, minArrayElement, arrayElementsSum, firstStringChar);
            }
        }
    }
}