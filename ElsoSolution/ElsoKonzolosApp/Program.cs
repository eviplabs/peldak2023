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

        }

        private static IEmberPrinter CreatePrinter(bool isDesign)   // Factory method
        {
            return isDesign ? new DesignPrinter() : new SimplePrinter();
        }
    }
}
