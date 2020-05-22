using System;

namespace TabuadaTeste
{
    
    class Program
    {
        

        static void Main(string[] args)
        {
            int result = 0;
            int num = 1;
            int multi = 1;
         
            while(num < 9)
            {
                num += 1;

                while( multi <= 10)
                {
                   
                    result = num * multi;
                   
                    Console.WriteLine(num + "x" + multi + "=" + result);
                   
                    multi += 1;
                }

                multi = 1; 
            }
            Console.ReadLine();

        }
    }
}
