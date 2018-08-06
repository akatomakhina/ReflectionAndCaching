namespace Reflection.Cakes.Layers
{
    public class Biscuit
    {
        public Biscuit(string meal, string sugar, string egg, string bakingPowder)
        {
            Meal = meal;
            Sugar = sugar;
            Egg = egg;
            BakingPowder = bakingPowder;
        }

        public string Meal
        {
            get;
            set;
        }

        public string Sugar
        {
            get;
            set;
        }
        
        public string Egg
        {
            get;
            set;
        }

        public string BakingPowder
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"Meal: {Meal}, sugar: {Sugar}, egg: {Egg}, baking powder: {BakingPowder}.";
        }
    }
}
