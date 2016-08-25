using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello hello = new Hello();
            hello.hellotest();
        }

      
    }

    public class Hello
    {
        public void hellotest()
        {
            Console.WriteLine("helloworld!1");
            Console.WriteLine("helloworld!2");
        }

    }

}
