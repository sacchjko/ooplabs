using System;

namespace lab2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Razmer:");
        int size = int.Parse(Console.ReadLine());

        IntVector array = new IntVector(size);
        array.Zapol();
        Console.WriteLine("\n Massiv");
        array.ShowIntArray();

        Console.WriteLine("\n uvelichenie na scalar, vvedite scalara");
        int scalar = int.Parse(Console.ReadLine());
        Console.WriteLine("\n Poluchennii massiv:");
        array.SumScalar(ref scalar);

        Console.WriteLine("\n Obrashenie po index");
        Console.WriteLine(array[-1]);
        Console.WriteLine(array[0]);
        Console.WriteLine(array[1]);
        Console.WriteLine(array[7]);

        Console.WriteLine("Infa");
        IntVector.Information();

        Console.WriteLine("\nАнонимный тип:");
        var anon = new { SIZE = 5 };
        Console.WriteLine("Свойства anon:      " + anon.SIZE);
        Console.WriteLine("Вывод anon:         " + anon);
        //pereopredelenie

        IntVector m1 = new IntVector(5);
        IntVector m2 = new IntVector(5);
        IntVector m3 = new IntVector(4);
        m1.Zapol();
        m2.Zapol();
        m3.Zapol();
        Console.WriteLine("m1"); m1.ShowIntArray();
        Console.WriteLine("m2"); m2.ShowIntArray();
        Console.WriteLine("m3"); m3.ShowIntArray();

        Console.WriteLine("Хэш-код m1 - " + m1.GetHashCode());    //1
        Console.WriteLine("Хэш-код m3 - " + m3.GetHashCode());    //2
    }

    class IntVector
    {
        static readonly string IntVectorInfo;
        private const int max_size = 50;
        private int[] IntArray;
        private int size;

        public string Info  //get
        {
            get { return IntVectorInfo; }
        }
        public int Size  //get set
        {
            get { return size; }
            set
            {
                if (size > max_size)
                    Console.WriteLine("slishkom bolshoi");
                else size = value;
            }
        }
        //konstruktori
        static IntVector()  //stat
        {
            IntVectorInfo = "massiv celih znachenii";
        }

        public IntVector(int size = 0) //s param po uml
        {
            this.size = size;
            IntArray = new int[size];
        }

        private IntVector()  //bez param
        {
            IntArray = new int[] {};
        }

        public void SumScalar(ref int scalar)
        {
            foreach (int item in IntArray)
            {
                int itemm = item + scalar;
                Console.Write("{0} ", itemm);
            }
            Console.WriteLine();
        }
        public static void Information()                //static vivod infi
        {
            Console.WriteLine(IntVectorInfo);
        }


        public void Zapol()                             //zapolnenie mass
        {
            Random rand = new Random();
            for (int i = 0; i < IntArray.Length; i++)
            {
                IntArray[i] = rand.Next(1, 99);
            }
        }

        public void ShowIntArray()                      //vivod massiva
        {
            foreach (int item in IntArray)
                Console.Write("{0} ", item);

            Console.WriteLine();
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < IntArray.Length)      //obrashenie k elementu po index
                {
                    return $"Index [{index}]: elementa {IntArray[index]}.";
                }
                else
                {
                    return $"Index [{index}] nelzya";
                }
            }
        }

        public override int GetHashCode()
        {
            int unitCode;
            if (size == 5)
                unitCode = 1;
            else unitCode = 2;
            return unitCode;
        }

    }
}