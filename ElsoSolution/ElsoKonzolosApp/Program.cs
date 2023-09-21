namespace ElsoKonzolosApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            var p  = new Program();
            //p.Novel();
            //var p2 = new Program();
            //p2.Novel();

            //Program.StatikusNovel();
            //Program.StatikusNovel();

            int n = 5;
            p.NovelEsKiir(ref n);
            Console.WriteLine("N értéke a Main-ben: "+n);

            double? d = 5.5;
            d = null;
            if (d.HasValue) Console.WriteLine("d="+d);

            p.Ertek = 55;
        }

        private int _belsoErtek = 0;
        public int Ertek
        {
            get
            {
                return _belsoErtek;
            }
            set
            {
                if (_belsoErtek != value)
                {
                    Console.WriteLine("Változott az Érték!");
                    _belsoErtek = value;
                }
            }
        }

        public int Ertek2 { get; set; } // Property tömören

        public const int InvalidTemperature = -1000;

        private int NovelEsKiir(ref int szam)
        {
            szam++;
            Console.WriteLine("Szam értéke bent: "+szam);
            return szam;
        }

        private static int statikusszamlala = 0;
        private int szamlalo = 0;

        public static void StatikusNovel()
        {
            statikusszamlala++;
        }

        public void Novel()
        {
            szamlalo++;
        }

    }
}
