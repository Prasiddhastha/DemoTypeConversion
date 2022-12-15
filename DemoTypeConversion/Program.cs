using System;
namespace DemoTypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Implicit type
                byte b = 1;
                int i = b;
                Console.WriteLine(i);
                //Explicit type
                int j = 1000;
                byte c = (byte)j;
                Console.WriteLine(c);
                //Non Compatible type
                var name = "1234";
                int p = Convert.ToInt32(name);//using convert class
                byte k = Convert.ToByte(name);//exception: system overload

                Console.WriteLine(p);
                Console.WriteLine(k);//not printed
            }
            catch (Exception z)
            {
                Console.WriteLine(z.Message);
                
            }
            
        }
    }
}
