using Common;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grower = new PersonGrower();
            grower.N = 5;
            var ager = new PersonAger();
            var p = new Program();
            p.PrintAndModify(grower);
        }

        public void PrintAndModify(IPersonModifier modifier)
        {
            var p = Person.GetMe();
            for(int i=0; i<10; i++)
            {
                modifier.Modify(p);
                Console.WriteLine(p.GetDescription());
            }
        }
    }
}