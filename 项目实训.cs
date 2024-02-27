using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            //const double PI = 3.1415926;
            const double PI = Math.PI;
            Console.WriteLine("请输入圆的半径: ");
            int r = int.Parse(Console.ReadLine());
            double s = PI * r * r;
            double zhouchang = 2 * PI * r;
            Console.WriteLine("圆的半径等于 = {0},面积 = {1},周长={2}",r,s,zhouchang);
            Console.WriteLine("面积 = {0},周长={1}",s.ToString("0.00"), zhouchang);
        }
    }
}