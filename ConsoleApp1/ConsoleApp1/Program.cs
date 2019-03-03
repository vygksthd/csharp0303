using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Emp
{
    public string Name { get; set; }
    //internal Emp()
    //{
    //    Name = "홍길동";
    //}
    internal Emp(string Name = "홍길동")
    {
        this.Name = Name;
    }
}
class EmpTest
{
    static void Main()
    {
        Emp e = new Emp();
        Console.WriteLine(e.Name);
    }
}
