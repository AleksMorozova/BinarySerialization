using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerialization
{
    [Serializable]
    class Person
    {//   [NonSerialized]
        public string name;
        public int age;
        public Job job;

        public string Name { get { return name; } set { name = value;}}
        public int Age { get { return age; } set { age = value; } }
        public Job Job { get { return job; } set { job = value; } }

        public Person(string name, int age, Job job)
        {
            Name = name;
            Age = age;
            Job = job;
        }
    }
}
