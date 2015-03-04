using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 用反射_Attribute控制属性的值
{
    public class Person
    {
        [Check(CheckEmpty = true)]
        public int Id { get; set; }
        [Check( CheckEmpty=true,CheckLengthArea = true, MaxLength = 10, MinLength = 3)]
        public string Name { get; set; }
        [Check(CheckEmpty = true, CheckNumberArea = true, MaxNumber = 200, MinNumber = 1)]
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
