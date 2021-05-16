using System;

namespace Smarandi_OOP_l2
{
    class Program
    {
        static void Main(string[] args)
        {
            MendeleevClapeyronUsing myclass = new MendeleevClapeyronUsing(1, 2);
            myclass.SubstanceAmount = 123;
            myclass.Mass = 123;
            Console.WriteLine(myclass.CalculatePressure(0, 213));
            Console.WriteLine(myclass.TemperatureCelsius);
            Console.WriteLine(myclass.TemperatureKelvin);

        }
    }
}
