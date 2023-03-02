using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_18._02
{
    internal class Class1
    {
        enum Status
        {
            Зарезервировано, Свободные, Заняты, Выписываются
        }
        class Person
        {
            public Status status;
            public string name;


        }
    }
}
