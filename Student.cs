using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIEnumerablePractice
{
    internal class Student
    {
        string _firstName;

        public Student(string firstName)
        {
            _firstName = firstName;
        }

        public override string ToString()
        {
            return $"Student Name: {_firstName}";
        }
    }
}
