using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person : IPerson
    {
        public string Name {  get; set; }
        public int Age { get; set; }

        public int GetAge()
        {
            return Age;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetAge(int Age)
        {
            this.Age = Age;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }
    }
}
