using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIEnumerablePractice
{
    internal class SchoolClass : System.Collections.IEnumerable
    {
        string _className;
        List<Student> _roster;

        public SchoolClass()
        {
            _roster = new List<Student>();

            _roster.Add(new Student("Ethan"));
            _roster.Add(new Student("Lily"));
            _roster.Add(new Student("Samuel"));
            _roster.Add(new Student("Mia"));
            _roster.Add(new Student("Benjamin"));
            _roster.Add(new Student("Harper"));
            _roster.Add(new Student("Jackson"));
            _roster.Add(new Student("Amelia"));
            _roster.Add(new Student("Caleb"));
            _roster.Add(new Student("Sophia"));
            _roster.Add(new Student("Gabriel"));
            _roster.Add(new Student("Ava"));
            _roster.Add(new Student("Oliver"));
            _roster.Add(new Student("Isabella"));
            _roster.Add(new Student("Lucas"));
            _roster.Add(new Student("Emily"));
            _roster.Add(new Student("Elijah"));
            _roster.Add(new Student("Charlotte"));
            _roster.Add(new Student("Noah"));
            _roster.Add(new Student("Grace"));
        }

        public IEnumerator GetEnumerator()
        {
            return new SchoolClassEnumerator(_roster);
        }

        private class SchoolClassEnumerator : IEnumerator
        {
            //Fields we need
            // The list we are working with
            List<Student> _roster;
            //The current index (-1)
            int index = -1;

            //constructor only needs current list
            public SchoolClassEnumerator(List<Student> roster)
            {
                _roster = roster;
            }

            //property returns current index
            public object Current => _roster[index];

            public bool MoveNext()
            {
                //we increment the index
                index++;
                //then check to see if its past the last item in the list

                if (index >= _roster.Count)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            //reset to inedx -1
            public void Reset()
            {
                index = -1;
            }
        }
    }
}
