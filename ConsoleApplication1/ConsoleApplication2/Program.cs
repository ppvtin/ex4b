using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Drawing
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("mời nhập mảng");
            int n = int.Parse(Console.ReadLine());
            string[,] Arr = new string[n, n];
            DrawVertical(Arr, n);
            DrawSquare(Arr, n);
            DrawSquareCenterEmpty(Arr, n);
            DrawU(Arr, n);
            DrawV(n);
            DrawTriangle(n);
            DrawTriangle2(n);
            DrawW(n);
            Console.ReadLine();
        }

        public static void DrawVertical(string[,] Array, int n)
        {
            Console.WriteLine("Draw Vertical: ");
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine("i");
                    }
                }
            }
        }

        public static void DrawSquare(string[,] Array, int n)
        {
            Console.WriteLine("Draw Square: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("o ");
                }
                Console.WriteLine();
            }
        }

        public static void DrawSquareCenterEmpty(string[,] Array, int n)
        {
            Console.WriteLine("vẽ hình vuông rỗng");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1)
                    {
                        Console.Write("c ");
                    }
                    else if (j == 0 || j == n - 1)
                        Console.Write("c ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        public static void DrawU(string[,] Array, int n)
        {
            Console.WriteLine("vẽ hình Chữ U");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == n - 1)
                    {
                        Console.Write("u ");
                    }
                    else if (j == 0 || j == n - 1)
                        Console.Write("u ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        public static void DrawV(int n)
        {
            int father = n - 2;
            Console.WriteLine("Vẽ hình chữ V: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) Console.Write("v");
                    else Console.Write(" ");
                }
                for (int k = 0; k <= father; k++)
                {
                    if (k == father) Console.Write("v");
                    else Console.Write(" ");
                }
                father--;
                Console.WriteLine();

            }
        }

        public static void DrawTriangle(int n)
        {
            Console.WriteLine("Vẽ Tam Giác Ngược");
            int q = 0;
            int father = n - 2;
            while (q < 2 * n - 1)
            {
                Console.Write("v");
                q++;
            }
            Console.WriteLine();
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) Console.Write("v");
                    else Console.Write(" ");
                }
                for (int k = 1; k <= father; k++)
                {
                    if (k == father) Console.Write("v");
                    else Console.Write(" ");
                }
                father--;
                Console.WriteLine();
            }
        }
        public static void DrawTriangle2(int n)
        {
            Console.WriteLine("Vẽ Tam Giác Thẳng đứng");
            int t = n - 1;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j <= n * 2 - 1; j++)
                {
                    if (i + j == n - 1)
                    {
                        Console.Write("A");
                    }
                    else if (i + j == t) Console.Write("A");
                    else Console.Write(" ");
                }
                t += 2;
                Console.WriteLine();
            }
            for (int w = 0; w < 2 * n - 1; w++) Console.Write("A");
            Console.WriteLine();
        }

        public static void DrawW(int n)
        {
            int t = 1, t2 = 2 * n - 3, z = 1, x = 0;
            int father = n - 2;
            Console.WriteLine("Vẽ hình chữ W: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) Console.Write("v");
                    else Console.Write(" ");
                }
                for (int k = 0; k <= father; k++)
                {
                    if (k == father) Console.Write("v");
                    else Console.Write(" ");
                }
                father--;
                for (int a = 0; a < n; a++)
                {
                    if (i == z && a == x)
                    {
                        for (int c = 1; c <= t; c++) Console.Write(" ");
                        Console.Write("v");
                    }
                }
                for (int b = 0; b < n; b++)
                {
                    if (i + b == n - 2 && (i != n))
                    {
                        for (int c = 1; c <= t2; c++) Console.Write(" ");
                        Console.Write("v");
                    }
                }
                if (i > 0) { t = t + 2; z++; x++; }
                t2 -= 2;
                Console.WriteLine();
            }

        }
            public static void DrawX(int n)
        {
            int a = 0, b = 0, c = 2 * n ;
            Console.WriteLine("Vẽ Chữ X" );
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < 2 * n + 1; j++)
                {
                    if (i == a && j == b)
                    {
                        Console.Write("*");
                    }
                    else if (i + j == c)
                    {
                        if (i ==n/2 && j==n/2) break;
                        Console.Write("*");
                    }
                    else Console.Write(" ");
                }
                c -= 1;
                a++; b += 2;
                Console.WriteLine();
            }
        }
    }
}

