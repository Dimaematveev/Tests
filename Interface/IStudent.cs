using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IStudent
    {
        IPerson Person { get; set; }
        double avgBall { get; set; }
        void AddBall(double avgBall);
    }
}
