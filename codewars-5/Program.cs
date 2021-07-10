using System;

namespace codewars_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double time = 6.7;
            Console.WriteLine(time);

            int w = Litres(time);
            Console.WriteLine(w);
        }
        public static int Litres(double time)
        {
            //The fun begins here.
            int liters = 0;
            if (time >= 0)
            {
                liters = (int)(time * 0.5);
            }
            return liters;
        }
    }
}
