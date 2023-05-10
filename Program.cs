using MyBanker;

class Program
{
    static void Main(string[] args)
    {
        Haevekort haevekort = new Haevekort("Peter Quill");
        Console.WriteLine(haevekort.ToString());

        Maestro maestro = new Maestro("Peter Parker");
        Console.WriteLine(maestro.ToString());

        VisaElectron visaElectron = new VisaElectron("Bruce Banner");
        Console.WriteLine(visaElectron.ToString());

        VisaDankort visaDankort = new VisaDankort("Bruce Wayne");
        Console.WriteLine(visaDankort.ToString());

        Mastercard mastercard = new Mastercard("Tony Stark");
        Console.WriteLine(mastercard.ToString());
    }
}
