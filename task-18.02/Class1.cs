using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_18._02
{
    public enum Status
        {
            Зарезервировано, Свободно, Заняты, Выписываются
        }
        public class Person
        {
            public Status status;
            public string name;
            public int room;
        public int number;
        public static int id = -1;
        public Person(Status s, string n, int r)
        {
            status = s;
            name = n;
            room = r;
            number = ++id;
        }
        }
    
}
