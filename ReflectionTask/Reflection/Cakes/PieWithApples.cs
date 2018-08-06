using Reflection.Cakes.Layers;

namespace Reflection.Cakes
{
    public class PieWithApples
    {
        public PieWithApples(Biscuit biscuit, string apples)
        {
            Biscuit = biscuit;
            Apples = apples;
        }

        public Biscuit Biscuit
        {
            get;
            set;
        }

        public string Apples
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"Biscuit: {Biscuit}, apples: {Apples}.";
        }
    }
}
