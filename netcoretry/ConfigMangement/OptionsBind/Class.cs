using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsBind
{
    public class Class
    {
        public string ClassName { get; set; }
        public List<Student> Students { get; set; }
    }

    public struct Student
    {
        public string No { get; set; }
        public string Name { get; set; }
    }
}
