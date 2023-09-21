namespace ElsoKonzolosApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ember ember = new Ember("Gipsz Jakab", 1980);

            IEmberPrinter ep = CreatePrinter(true);
            ep.Print(ember);
        }

        private static IEmberPrinter CreatePrinter(bool isDesign)   // Factory method
        {
            return isDesign ? new DesignPrinter() : new SimplePrinter();
        }
    }
}
