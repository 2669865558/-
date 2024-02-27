using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            double height;
            int age;
            Console.WriteLine(" 请输入你的身高 （单位 ： 米）");
            height = Double.Parse(Console.ReadLine());

            Console.WriteLine("请输入你的年龄：");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("你的身高是 {0}米，年龄是 {1}岁.",height,age);
            Console.Read();
        }
    }
}
