using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class VisaDankort : PaymentCard, IExpirable
    {
        public DateTime ExpiryDate { get; private set; }

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

        public VisaDankort(string cardholderName) : base(cardholderName)
        {
            CardNumber = "4" + RandomNumberString(12);
            ExpiryDate = DateTime.Now.AddYears(5);
        }

        public override string ToString()
        {
            return $"Visa/Dankort: {CardholderName}, Kortnummer: {CardNumber}, Kontonummer: {AccountNumber}, Udløbsdato: {ExpiryDate.ToShortDateString()}";
        }
    }
}
