using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page58_상속
{
    //public class Pudle
    //{
    //    public string name;
    //    public void jitda()
    //    {
    //        Console.WriteLine(name + "가 짖다.");
    //    }
    //}
    //public class jindo
    //{
    //    public string name;
    //    public void jitda()
    //    {
    //        Console.WriteLine(name + "가 짖다.");
    //    }
    //}

    //class DogManger
    //{
    //    static void Main(string[] args)
    //    {
    //        Pudle p = new Pudle();
    //        p.name = "푸들이";
    //        p.jitda();

    //        jindo j = new jindo();
    //        j.name = "진도이";
    //        j.jitda();
    //    }
    //}


    public class Dog
    {
        public string name { get; set; }
        public void jitda()
        {
            Console.WriteLine(name + "가 짖다.");
        }
    }

    public class Pudle : Dog
    {
        public void work()
        {
            Console.WriteLine(name + "가 일한다.");
        }
    }
    public class jindo : Dog
    {
        public void run()
        {
            Console.WriteLine(name + "가 달린다.");
        }
    }

    class DogManger
    {
        static void Main(string[] args)
        {
            Pudle p = new Pudle();
            p.name = "푸들이";
            p.jitda();
            p.work();

            jindo j = new jindo();
            j.name = "진도이";
            j.jitda();
            j.run();
        }
    }
}
