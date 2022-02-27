using System;

namespace SingletonPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
            Singleton fromStudent = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Student");

            Console.ReadKey();
        }
    }
}
