using System;

namespace ConsoleApp1._3
{
    public delegate void M1();
    public delegate void M2();

    class Random
    {
        public Random(int seed)
        {
            Seed = seed;
        }

        public Random()
        {
        }

        public int Length { get; internal set; }
        public int Seed { get; }
            void NoBoundsRandoms(int seed)
            {
                Console.WriteLine(
                    "\nRandom object, seed = {0}, no bounds:", seed);
                Random randObj = new Random(seed);

                for (int j = 0; j < 6; j++)
                    Console.Write("{0,11} ", randObj.Next());
                Console.WriteLine();
            }

        private object Next()
        {
            throw new NotImplementedException();
        }
    }
    
    public delegate void first();

    class Program
    {
        static void M1()
        {
            Action line = () => Console.WriteLine();
        }

        static void M2()
        {
            Action line = () => Console.WriteLine();
            Random rand = new Random();
            int rndSum = 0;
            for (int i = 0; i < rand.Length; i++)
                rndSum += rand[];
            Console.WriteLine(" сумма: {0} ", rndSum);
            Console.WriteLine(" среднее арефмитическое: {0} ", rndSum / rand.Length);
        }

        static first[] delegates = new first[]
        {
         new first( Program.M1),
         new first( Program.M2)
        };
     

        static void Main(string[] args)
        {
            first delMain = null;
            first del = new first(M1);
            first del1 = new first(M2);
            delMain = del + del1;
            delMain();

            Console.ReadKey();
        }
    }
}
