using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
public class VisaElectron : DebitCard, IExpirable
{
    public DateTime ExpiryDate { get; private set; }

        //Picks a random Prefix 
        private string RandomPrefix()
        {
            string[] prefixes = { "4026", "417500", "4508", "4844", "4913", "4917" };
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

        public VisaElectron(string cardholderName) : base(cardholderName)
        {
            CardNumber = RandomPrefix() + RandomNumberString(12);
            ExpiryDate = DateTime.Now.AddYears(5);
         }

    public override string ToString()
    {
        return $"Visa Electron: {CardholderName}, Kortnummer: {CardNumber}, Kontonummer: {AccountNumber}, Udløbsdato: {ExpiryDate.ToShortDateString()}";
    }
}
}
