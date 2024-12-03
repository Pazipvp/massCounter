using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            object[] m = new object[] { 1, 3, new int[] { 1, 32, 3 } };

           Console.WriteLine(SuperPuperDeepCounter(m));


           Console.ReadKey();
        }

        private static int SuperPuperDeepCounter(object obj)
        {
            int count = 0;

            if (obj.GetType().IsArray)
            {                
                foreach (object item in (Array)obj)               
                   count+= SuperPuperDeepCounter(item);               
            }
            else
                count++;


            return count;
        }
    }
}
