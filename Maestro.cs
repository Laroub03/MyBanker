using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Maestro : DebitCard, IExpirable
    {
        public DateTime ExpiryDate { get; private set; }

        private string RandomPrefix()
        {
            string[] prefixes = { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };
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

        public Maestro(string cardholderName) : base(cardholderName)
        {;
            CardNumber = RandomPrefix() + RandomNumberString(12);
            ExpiryDate = DateTime.Now.AddYears(5).AddMonths(8);
        }

        public override string ToString()
        {
            return $"Maestro: {CardholderName}, Kortnummer: {CardNumber}, Kontonummer: {AccountNumber}, Udløbsdato: {ExpiryDate.ToShortDateString()}";
        }
    }
}
