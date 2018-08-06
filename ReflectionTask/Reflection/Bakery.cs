using Reflection.Cakes;
using System.Collections.Generic;

namespace Reflection
{
    public class Bakery
    {
        public List<CakeWithCherry> CakeWithCherries
        {
            get;
            set;
        }

        public Bakery(List<CakeWithCherry> cakeWithCherryList)
        {
            CakeWithCherries = cakeWithCherryList;
        }

        public void Add(CakeWithCherry cakeWithCherry)
        {
            CakeWithCherries.Add(cakeWithCherry);
        }

        public void Remove(CakeWithCherry cakeWithCherry)
        {
            CakeWithCherries.Remove(cakeWithCherry);
        }
    }
}
