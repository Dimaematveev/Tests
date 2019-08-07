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

        public Ages(DateTime bithday)
        {
            this.bithday = bithday;
        }

        public int age {
            get
            {
                var DT = new DateTimeProvider();
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
