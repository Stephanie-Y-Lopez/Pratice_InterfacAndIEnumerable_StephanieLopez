using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_InterfacAndIEnumerable_StephanieLopez
{
    internal class SchoolClass : IEnumerable
    {
        //Field
        private string Name_ { get; }
        private List<Student> ClassRoster { get; }

        public SchoolClass(string Name)
        {
            Name_ = Name;
            ClassRoster = new List<Student>();
            PopulateRoster();
        }

        private void PopulateRoster()
        {
            //Generated A list of random names (Thank you Mr.Cram for the idea to use ChatGPT!)
            string[] studentNames = { "Alice", "Bob", "Charlie", "David", "Emma", "Frank", "Grace", "Henry", "Ivy", "Jack", "Katie", "Leo", "Mia", "Nathan", "Olivia", "Peter", "Quinn", "Rachel", "Sam", "Tina" };

            foreach (var name in studentNames)
            {
                ClassRoster.Add(new Student(name));
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new SchoolClassIterator(ClassRoster);
        }

        private class SchoolClassIterator : IEnumerator
        {
            private int currentIndex = -1;
            private List<Student> students;

            public SchoolClassIterator(List<Student> students)
            {
                this.students = students;
            }

            public bool MoveNext()
            {
                currentIndex++;
                return (currentIndex < students.Count);
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            public object Current => students[currentIndex];
        }
    }
}
