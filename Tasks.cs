using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice5
{
    internal class Tasks
    {
        public class Employee
        {
            public string _name { get;private set; }
            public double _salary { get;private set; }

            public Employee(string name,double salary) { 
                _name = name;
                _salary = salary;
            }

            public static Employee operator ++(Employee person)
            {
                person._salary += 100;
                return person;
            }

            public static Employee operator --(Employee person)
            {
                person._salary -= 50;
                return person;
            }


            public static bool operator ==(Employee person1, Employee person2)
            {
                if (ReferenceEquals(person1, null))
                    return ReferenceEquals(person2, null);

                return person1._name == person2._name && person1._salary == person2._salary;
            }

            public static bool operator !=(Employee person1, Employee person2)
            {
                return !(person1._name == person2._name && person1._salary == person2._salary);
            }

            public static bool operator < (Employee person1, Employee person2)
            {
                if(person1._salary < person2._salary)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator >(Employee person1, Employee person2)
            {
                if (person1._salary > person2._salary)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }      
    }
}

