using System;

namespace Smarandi_OOP_l2
{
    abstract public class MCE
    {
        public double p;
        abstract public double CalculatePressure(double V, double T);
    }

    interface MyInterface
    {
        public double CalcualtePressure(double V, double T);
    }

    public enum MyEnum
    {
        l = 1,
        k = 2
    }

    public class MendeleevClapeyronEquation : MCE
    {
        double p;
        double V;
        protected double m;
        protected double M;
        double R = 8.31446261815324;
        protected double T;

        override public double CalculatePressure(double V, double T)
        {
            this.V = V;
            this.T = T;
            #region body 
            try
            {
                if (this.M == 0 || this.V == 0) throw new DivideByZeroException();
                if (this.M < 0 || this.V < 0 || this.m < 0 || this.T < 0) throw new Exception("unrealistic values");
                this.p = ((this.m / this.M) * R * T) / V;
                return this.p;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка: нереалистичные значения");
            }
            return 0;
            #endregion

        }
    }

    public class MendeleevClapeyronUsing : MendeleevClapeyronEquation
    {


        public MendeleevClapeyronUsing(double x, double y)
        {

        }
        public double Mass
        {
            get { return this.m; }
            set { this.m = value; }
        }

        public double SubstanceAmount
        {
            get { return this.M; }
            set { this.M = value; }
        }

        public double TemperatureKelvin
        {
            get { return this.T; }
            set { this.T = value; }
        }
        public double TemperatureCelsius
        {
            get { return this.T - 273; }
        }

    }
}