using Reflection.Cakes.Cream;
using Reflection.Cakes.Layers;

namespace Reflection.Cakes
{
    public class CakeWithCherry
    {
        public CakeWithCherry(SourcreamCream sourcreamCream, Shortbread shortbread, string cherry)
        {
            SourcreamCream = sourcreamCream;
            Shortbread = shortbread;
            Cherry = cherry;
        }

        public SourcreamCream SourcreamCream
        {
            get;
            set;
        }

        public Shortbread Shortbread
        {
            get;
            set;
        }

        public string Cherry
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"Sour cream: {SourcreamCream}, shortbread: {Shortbread}, cherry: {Cherry}.";
        }
    }
}
