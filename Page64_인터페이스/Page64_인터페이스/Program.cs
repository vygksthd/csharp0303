using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page64_인터페이스
{
    interface Dog
    {
        string name { get; set; }
        void jitda();
    }
    class Pudle : Dog
    {
        public string name { get; set; }
        public void work()
        {
            Console.WriteLine(name  + " 일한다.");
        }
        public void jitda()
        {
            Console.WriteLine(name + " 짖다~~~~~");
        }
    }
    class Jindo : Dog
    {
        public string name { get; set; }
        public void run()
        {
            Console.WriteLine(name + " 달린다.");
        }
        public void jitda()
        {
            Console.WriteLine(name + " 짖다~~~~~");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog p = new Pudle();
            p.name = "푸들이";
            p.jitda();
            ((Pudle)p).work();

            Dog j = new Jindo();
            j.name = "푸들이";
            j.jitda();
            ((Jindo)j).run();
        }
    }
}
