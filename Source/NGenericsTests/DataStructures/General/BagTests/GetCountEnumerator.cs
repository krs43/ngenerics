/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using System;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.BagTests
{
    [TestFixture]
    public class GetCountEnumerator : BagTest
    {

        [Test]
        public void Simple()
        {
            var bag = GetTestBag();

            var enumerator = bag.GetCountEnumerator();

            var counter = 0;

            while (enumerator.MoveNext())
            {
                if (Int32.Parse(enumerator.Current.Key) < 5)
                {
                    Assert.AreEqual(enumerator.Current.Value, 3);
                }
                else if (Int32.Parse(enumerator.Current.Key) < 10)
                {
                    Assert.AreEqual(enumerator.Current.Value, 2);
                }
                else if (Int32.Parse(enumerator.Current.Key) < 20)
                {
                    Assert.AreEqual(enumerator.Current.Value, 1);
                }

                counter++;
            }

            Assert.AreEqual(counter, 20);
        }

    }
}