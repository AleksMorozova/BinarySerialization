using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerialization
{
    [Serializable]
    public class Job
    {
        public string name;
        public int code;

        public string Name { get { return name; } set { name = value; } }
        public int Code { get { return code; } set { code = value; } }


        public Job(string name, int code)
        {
            Name = name;
            Code = code;
        }

    }
}
