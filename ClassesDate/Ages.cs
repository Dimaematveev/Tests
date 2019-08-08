using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDate
{
    public class Ages
    {
        DateTime bithday;
        DateTimeProvider DT;
        public Ages(DateTime bithday)
        {
            this.bithday = bithday;
            SetDT();
        }
        public void SetDT()
        {
            DT = new DateTimeProvider();
        }

        public int age {
            get
            {
                int ret = DT.Now.Year - bithday.Year;
                if (new DateTime(DT.Now.Year, bithday.Month, bithday.Day) > DT.Now)
                {
                    ret--;
                }
                return ret;
            }
            
        }

    }
}
