using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Linear l1 = new Linear(5, 6, x);
            Sqr sq1 = new Sqr(5, 6, 7, x);
            l1.Func();
            sq1.Func();
            Function[] array = { l1, sq1 };
            ArrayFunct<Function> arrfunc = new ArrayFunct<Function>(array);
            arrfunc[1].Func();

        }
    }
    abstract class Function
    {
        public int X { get; set; }

        public virtual void Func() { }
    }

    class Linear : Function
    {
        public int A { get; set; }
        public int B { get; set; }
        public override void Func()
        {
            Console.WriteLine(A * X + B);
        }
        public Linear(int a, int b, int x)
        {
            A = a;
            B = b;
            X = x;
        }
    }
    class Sqr : Function
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public override void Func()
        {
            Console.WriteLine(A * X * X + B * X + C);
        }
        public Sqr(int a, int b, int c, int x)
        {
            A = a;
            B = b;
            C = c;
            X = x;
        }
    }

    class ArrayFunct<T>
    {
        public T[] Array { get; set; }
        public ArrayFunct(T[] arr)
        {
            Array = arr;
        }
        public T this[int index]
        {
            get => Array[index];
            set => Array[index] = value;
        }
        public override string ToString()
        {
            return $"{Array[0]} {Array[1]}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}