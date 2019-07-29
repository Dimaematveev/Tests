using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Student : IStudent
    {
        public IPerson Person { get; set; }
        public double avgBall { get; set; }

        public void addBall(double avgBall)
        {
            this.avgBall = avgBall;
        }
    }
}
