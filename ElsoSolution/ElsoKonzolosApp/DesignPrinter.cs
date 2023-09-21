namespace ElsoKonzolosApp
{
    internal class DesignPrinter : IEmberPrinter
    {
        public void Print(Ember ember)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"- Név: {ember.Nev}");   // string interpolation
            Console.WriteLine($"- Születési év: {ember.SzuletesiEv}");
            Console.WriteLine("----------------------------------------------");
        }
    }
}
