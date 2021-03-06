/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using NGenerics.DataStructures.Mathematical;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Mathematical.VectorNTests
{
    [TestFixture]
    public class Magnitude
    {

        [Test]
        public void Simple()
        {
            var vector = new VectorN(3);
            vector.SetValues(4, 3, 12);
            Assert.AreEqual(13, vector.Magnitude());

            Assert.AreEqual(4, vector[0]);
            Assert.AreEqual(3, vector[1]);
            Assert.AreEqual(12, vector[2]);
        }

    }
}