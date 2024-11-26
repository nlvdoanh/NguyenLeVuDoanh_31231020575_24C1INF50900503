using System;
using System.Text;

namespace Bai_tap_Data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bai_01();
            //Bai_02();
            Bai_03();
            Console.ReadKey();
        }
        public static void Bai_01()
        {
            Console.Write("Nhập nhiệt độ Celsius: ");
            int celsius = int.Parse(Console.ReadLine());

            int kelvin = celsius + 273;
            Console.WriteLine("Nhiệt độ Kelvin là: " + kelvin);

            int fahrenheit = celsius * 18 / 10 + 32;
            Console.WriteLine("Nhiệt độ Fahrenheit là: " + fahrenheit);
        }
        public static void Bai_02()
        {
            Console.Write("Nhập bán kính hình cầu: ");
            double r = double.Parse(Console.ReadLine());
            double S = 4 * Math.Pow(r, 2) * Math.PI;
            Console.WriteLine("Diện tích hình cầu là: " + S);
            double V = 4 / 3 * Math.Pow(r, 3) * Math.PI;
            Console.WriteLine("Thể tích hình cầu là: " + V);
        }
        public static void Bai_03()
        {
            Console.Write("Nhập số a: ");
            int a = int.Parse(Console.ReadLine());
          
            Console.Write("Nhập số b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("a + b = " + (a + b));
            //Console.WriteLine($"a + b = {a + b} ");
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
            Console.WriteLine("Số dư của phép chia a / b = " + (a % b));
        }
    }
}

