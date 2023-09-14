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
            Console.WriteLine("N értéke a Main-ben: "+n.ToString());

            double? d = 5.5;
            d = null;
            if (d.HasValue) Console.WriteLine("d="+d.ToString());

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
        //public int GetErtek()
        //{
        //    return _belsoErtek;
        //}

        //public void SetErtek(int ujErtek)
        //{
        //      _belsoErtek = ujErtek;
        //}

        public const int InvalidTemperature = -1000;

        private int NovelEsKiir(ref int szam)
        {
            szam++;
            Console.WriteLine("Szam értéke bent: "+szam.ToString());
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
