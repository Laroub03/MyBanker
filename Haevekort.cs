using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Haevekort : DebitCard
    {
        // Generate a random number string of a given length
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


        public Haevekort(string cardholderName) : base(cardholderName)
        {
            CardNumber = "2400" + RandomNumberString(12);
        }

        public override string ToString()
        {
            return $"Hævekort: {CardholderName}, Kortnummer: {CardNumber}, Kontonummer: {AccountNumber}";
        }
    }
}
