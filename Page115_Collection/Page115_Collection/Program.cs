using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Page115_Collection
{
    class Program
    {
        static void Main()
        {
            ArrayList onj = new ArrayList();
            //List<string> onj = new List<string>();
            onj.Add("Onj");
            onj.Add("OracleJava");
            onj.Add("Community");

            Console.WriteLine("onj List");
            Console.WriteLine("     Count:     {0}", onj.Count);
            Console.WriteLine("     Capacity:  {0}", onj.Capacity);
            Console.Write(" onj  Values:");
            PrintValues(onj);
            ArrayList onj2 = (ArrayList)onj.Clone();
            Console.Write(" onj2 Values:");
            PrintValues(onj2);
        }
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
            {
                Console.Write("    {0}", obj);
                Console.WriteLine();
            }
        }
    }
}
