using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class CheckingAccount:IAccount
    {
        double m_balance;
        /// <summary>
        /// Количество снимаемых средств меньше, чем размер баланса счета.
        /// </summary>
        /// <param name="amount"></param>
        public void Withdraw(double amount)
        {
            if (m_balance >= amount)
            {
                m_balance -= amount;
            }
            else
            {
                throw new ArgumentException(amount, "Withdrawal exceeds balance!")
            }
        }
    }
}
