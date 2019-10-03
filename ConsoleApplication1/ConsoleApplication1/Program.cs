using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[10];
            InputInt(Arr);
            Console.WriteLine(Count5(Arr));
            Console.ReadLine();

        }
        public static void InputInt(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write("A[{0}] = ", i);
                string str = Console.ReadLine();
                Arr[i] = int.Parse(str);
            }
        }

        public static bool IsContain5(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 5) return true;
            }
            return false;
        }

        public static bool IsContain5or6(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 5 || Arr[i] == 6) return true;
            }
            return false;
        }

        public static bool IsContain5And6(int[] Arr)
        {
            bool a = false, b = false;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 5) a = true;
                else if (Arr[i] == 6) b = true;
            }
            if (a == true && b == true) return true;
            else return false;
        }

        public static int Count5(int[] Arr)
        {
            int count = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 5) count++;
                //if (Arr[i] == Arr.Length - 1) return count;
            }
            return count;
        }

        public static int Count5or6(int[] Arr)
        {
            int count5or6 = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 5 || Arr[i] == 6) count5or6++;
            }
            return count5or6;
        }

        public static int SumArr(int[] Arr)
        {
            int Sum = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }
    }
}
