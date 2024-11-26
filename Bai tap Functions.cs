using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Bai_tap_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bai_01();
            //Bai_02();
            //Bai_03();
            Bai_04();
            Console.ReadKey();
        }
        public static void Bai_01()
        {
            Console.Write("Nhập vào số thứ 1: ");
            int st1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ 2: ");
            int st2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ 3: ");
            int st3 = int.Parse(Console.ReadLine());

            int max = st1;
            if (st2 > max)
            {
                if (st3 > max)
                {
                    Console.WriteLine($"Số lớn nhất là {st3}");
                }
                else
                    Console.WriteLine($"Số lớn nhất là {st2}");
            }
            else
                Console.WriteLine($"Số lớn nhất là {st1}");
            Console.ReadKey();
        }
        public static void Bai_02()
        {
            Console.Write("Nhập vào một số: ");
            int a = int.Parse(Console.ReadLine());
            int b = a;
            int giaithua = 1;
            while (a > 0)
            {
                giaithua *= a;
                a--;
            }
            Console.WriteLine($"Giai thừa của {b} = {giaithua}");
        }
        public static void Bai_03()
        {
            Console.Write("Nhập vào một số: ");
            int a = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= a; i++)
                if (a % i == 0) count++;
            {
                if (count > 2)
                {
                    Console.WriteLine("Đây không phải là số nguyên tố");
                }
                else
                    Console.WriteLine("Đây là số nguyên tố");
            }
        }
        public static void Bai_04()
        {
            Console.Write("Nhập 1 số: ");
            int n = int.Parse(Console.ReadLine());
            int S = 0;
            for (int i = 1; i < n; i++) 
            if (n % i == 0) S = S + i;
            Console.WriteLine($"Tổng các ước của {n} = {S}");
            if (S == n) Console.WriteLine($"{n} là số hoàn hảo.");
            else Console.WriteLine($"{n} không là số hoàn hảo.");
        }
    }
}
