using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Group : IGroup
    {
        public List<IStudent> Students { get; set; } = new List<IStudent>();
        public int CountStudent { get => Students.Count; }

        public void AddStudent(IStudent Student)
        {
            Students.Add(Student);
        }
    }
}
