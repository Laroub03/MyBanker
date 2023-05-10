using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Mastercard : PaymentCard, IExpirable
        {
        public DateTime ExpiryDate { get; private set; }

        private string RandomPrefix()
        {
            string[] prefixes = { "51", "52", "53", "54", "55" };
            Random random = new Random();
            return prefixes[random.Next(prefixes.Length)];
        }

        private string RandomNumberString(int length)
        {
            Random random = new Random();
            string result = "";

            for (int i = 0; i < length; i++)
            {
                result += random.Next(0, 10).ToString();
            }

            return result;
        }

        public Mastercard(string cardholderName) : base(cardholderName)
        {
            Random random = new Random();
            CardNumber = RandomPrefix() + RandomNumberString(12);
            ExpiryDate = DateTime.Now.AddYears(5);
        }

        public override string ToString()
        {
            return $"Mastercard: {CardholderName}, Kortnummer: {CardNumber}, Kontonummer: {AccountNumber}, Udløbsdato: {ExpiryDate.ToShortDateString()}";
        }
    }
}
