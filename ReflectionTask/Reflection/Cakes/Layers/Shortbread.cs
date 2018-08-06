namespace Reflection.Cakes.Layers
{
    public class Shortbread
    {
        public Shortbread(string meal, string sugar, string butter, int egg, string salt)
        {
            Meal = meal;
            Sugar = sugar;
            Butter = butter;
            Egg = egg;
            Salt = salt;
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

        public string Butter
        {
            get;
            set;
        }

        public int Egg
        {
            get;
            set;
        }

        public string Salt
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"Meal: {Meal}, sugar: {Sugar}, butter: {Butter}, egg: {Egg} pieces, salt: {Salt}.";
        }
    }
}
