using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppEF_Core.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public int Physics { get; set; }
        public int Maths { get; set; }
        public int English { get; set; }
        public int Chemistry { get; set; }

    }

}
