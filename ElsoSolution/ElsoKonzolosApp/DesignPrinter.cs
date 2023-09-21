namespace ElsoKonzolosApp
{
    internal class DesignPrinter : EmberPrinterBase
    {
        public override void Print(Ember ember)
        {
            Console.WriteLine("----------------------------------------------");
            base.Print(ember);
            Console.WriteLine("----------------------------------------------");
        }
    }
}
