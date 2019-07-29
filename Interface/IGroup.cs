using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IGroup
    {
        List<IStudent> Students { get; set; }
        int CountStudent { get; }
        void AddStudent(IStudent Student);
    }
}
