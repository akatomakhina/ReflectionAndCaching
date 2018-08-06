namespace Reflection.Cakes.Cream
{
    public class ChocolateCream
    {
        public ChocolateCream(string milk, string sugar, string cocoa, string meal, string butter)
        {
            Milk = milk;
            Sugar = sugar;
            Cocoa = cocoa;
            Meal = meal;
            Butter = butter;
        }

        public string Milk
        {
            get;
            set;
        }

        public string Sugar
        {
            get;
            set;
        }

        public string Cocoa
        {
            get;
            set;
        }

        public string Meal
        {
            get;
            set;
        }

        public string Butter
        {
            get;
            set;
        }        

        public override string ToString()
        {
            return $"Milk: {Milk}, sugar: {Sugar}, cocoa: {Cocoa}, meal: {Meal}, butter: {Butter}.";
        }
    }
}
