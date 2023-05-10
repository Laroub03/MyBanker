using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class DebitCard : PaymentCard
    {
        public DebitCard(string cardholderName) : base(cardholderName)
        {
        }
    }
}
