using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace 用反射_Attribute控制属性的值
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Name = "haha", Email = "sss@qq.com", Phone = "15000000000" };
            string errMsg = GetErrorMsg.Check<Person>(p);
            Console.WriteLine(errMsg);
            Console.ReadKey();

        }
    }

}
