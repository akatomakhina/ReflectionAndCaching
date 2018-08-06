using NUnit.Framework;
using Reflection;
using Reflection.Cakes.Cream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Reflection
{
    [TestFixture]
    public class ReflectionComparerTests
    {
        [Test]
        public void ReflectionWithComparer_NullExceptionFirstObject()
        {
            ChocolateCream choco = new ChocolateCream("100 milliliters", "250 grams", "3 tablespoons", "300 grams", "120 grams");
            var exception = Assert.Throws<ArgumentNullException>(
                () => ReflectionComparer.ReflectionWithComparer(null, choco));
        }

        [Test]
        public void ReflectionWithComparer_NullExceptionSecondObject()
        {

        }
    }
}
