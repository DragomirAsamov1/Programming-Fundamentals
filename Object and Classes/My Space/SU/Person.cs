using System;
using System.Collections.Generic;
using System.Text;

namespace SU
{
    class Person
    {
        private string name;

        public Person(){}
        ~Person() { }

        public override bool Equals(object obj)
        {
            if (!(obj is Person))
            { 
                return false;
            }

            Person p = (Person)obj;
            return (this.name.Equals(p.Name) && this.Priority == p.Priority);
        }
        public string Name
        {
            get 
            {
                return name; 
            }
            set 
            {
                name = value;
                if (value.Length>20)
                {
                    this.name = value.Substring(0, 20);
                }
            }
        }

        public double Priority
        {
            get;
            set;
        }
    }

}
