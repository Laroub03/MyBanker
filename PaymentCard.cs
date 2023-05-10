using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{   // Interface to handle expiry dates
    public interface IExpirable
    {
        DateTime ExpiryDate { get; }
    }

    // Abstract class representing a payment card
    public abstract class PaymentCard
    {
        public string CardholderName { get; set; }
        public string CardNumber { get; protected set; }
        public string AccountNumber { get; protected set; }

        private string RandomNumberString(int length)
        {
            Random random = new Random();
            var builder = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                builder.Append(random.Next(0, 10).ToString());
            }

            return builder.ToString();
        }

        public PaymentCard(string cardholderName)
        {
            CardholderName = cardholderName;
            AccountNumber = GenerateAccountNumber();
        }

        // Generate a random account number with 14 digits
        protected string GenerateAccountNumber()
        {
            Random random = new Random();
            return "3520" + RandomNumberString(12);
        }
    }
}
