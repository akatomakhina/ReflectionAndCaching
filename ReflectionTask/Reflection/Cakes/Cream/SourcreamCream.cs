using System;

namespace Reflection.Cakes.Cream
{
    public class SourcreamCream : IComparable
    {
        public SourcreamCream(string sourcCream, string sugar)
        {
            SourCream = sourcCream;
            Sugar = sugar;
        }

        public string SourCream
        {
            get;
            set;
        }

        public string Sugar
        {
            get;
            set;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            SourcreamCream otherSourcreamCream = obj as SourcreamCream;
            if (otherSourcreamCream != null)
            {
                this.SourCream.CompareTo(otherSourcreamCream.SourCream);
                this.Sugar.CompareTo(otherSourcreamCream.Sugar);
                return 0;
            }            
            else
                throw new ArgumentException("Object is not a ChocolateCream");
        }

        public override string ToString()
        {
            return $"Sour cream: {SourCream}, sugar: {Sugar}.";
        }
    }
}
