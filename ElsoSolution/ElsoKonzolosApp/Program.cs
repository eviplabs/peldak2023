using System.Text;

namespace ElsoKonzolosApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ember ember = new Ember("Gipsz Jakab", 1980);

            IEmberPrinter ep = CreatePrinter(true);
            ep.Print(ember);

            string x = "hello";
            x = "hello2";
            x = "hello" + "2" + ember.Nev + " ( " + ember.SzuletesiEv + " )";

            StringBuilder sb = new StringBuilder();
            sb.Append("hello");
            sb.Append("2");
            sb.Append(ember.Nev);
            sb.Append(" ( ");
            sb.Append(ember.SzuletesiEv);
            sb.Append(" )");
            x = sb.ToString();

            x = $"hello2 {ember.Nev} ( {ember.SzuletesiEv} )";

            string szamStringkent = "12fff3";
            // Ha lehet, hogy nem szám, akkor nem így csináljuk!!!
            //try
            //{
            //    int szam2 = int.Parse(szamStringkent);
            //    Console.WriteLine(szam2);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Ez nem szám!!!! :(");
            //}

            if (int.TryParse(szamStringkent, out int szam))
            {
                Console.WriteLine("Szám:"+szam);
            }
            else
            {
                Console.WriteLine("Ez nem szám!!! :(");
            }
        }

        private static IEmberPrinter CreatePrinter(bool isDesign)   // Factory method
        {
            return isDesign ? new DesignPrinter() : new SimplePrinter();
        }
    }
}
