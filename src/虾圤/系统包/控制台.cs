using System;

namespace 虾圤.系统包
{
    public class 控制台
    {
        public static void 打印()
        {
            Console.WriteLine();
        }

        public static void 打印(string value)
        {
            Console.WriteLine(value);
        }

        public static void 打印(string format, object arg0)
        {
            Console.WriteLine(format, arg0);
        }

        public static void 打印(bool value)
        {
            Console.WriteLine(value);
        }

        public static void 打印(int value)
        {
            Console.WriteLine(value);
        }

        public static void 打印(char[] buffer)
        {
            Console.WriteLine(buffer);
        }

        public static void 打印(char[] buffer, int index, int count)
        {
            Console.WriteLine(buffer, index, count);
        }
    }
}