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
                int ret = DateTimeProvider.Now.Year - bithday.Year;
                if (new DateTime(DateTimeProvider.Now.Year, bithday.Month, bithday.Day) > DateTimeProvider.Now)
                {
                    ret--;
                }
                return ret;
            }
            
        }

    }
}
