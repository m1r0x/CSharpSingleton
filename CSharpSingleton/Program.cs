using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSingleton
{
    public class Singleton
{
    private static Singleton instance;

    public int MyVal;

    //private constructor

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
    public class SingletonEager
    {
        private static readonly SingletonEager instance = new SingletonEager();

        public int MyValEager;

        private SingletonEager()
        {
        }

        public static SingletonEager Instance
        {
            get
            {
                return instance;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SingletonEager.Instance.MyValEager = 321;
            Console.WriteLine(SingletonEager.Instance.MyValEager);
            Console.ReadKey();
            Singleton.Instance.MyVal = 123;
            Console.WriteLine(Singleton.Instance.MyVal);
            Console.ReadKey();

        }
    }
}
