using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_InterfacAndIEnumerable_StephanieLopez
{
    internal class Student
    {
        //Field
        public string FirstName_ { get; }

        //Constructor
        public Student(string FirstName)
        {
            FirstName_ = FirstName;
        }

        //To override
        public override string ToString()
        {
            return $"Student Name: {FirstName_}";
        }
    }
}
