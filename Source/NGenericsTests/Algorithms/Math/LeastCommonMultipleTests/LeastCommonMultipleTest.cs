﻿/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using NUnit.Framework;
using NGenerics.Algorithms;

namespace NGenerics.Tests.Algorithms.Math.LeastCommonMultipleTests
{
    [TestFixture]
    public class LeastCommonMultipleTest
    {
        [Test]
        public void Lease_Common_Multiple_Between_Zero_And_Zero_Should_Be_Zero()
        {
            Assert.AreEqual(MathAlgorithms.LeastCommonMultiple(0, 0), 0);
        }

        [Test]
        public void Should_Return_Correct_Values_For_Non_Zero_Inputs()
        {
            Assert.AreEqual(MathAlgorithms.LeastCommonMultiple(34, 12), 204);
            Assert.AreEqual(MathAlgorithms.LeastCommonMultiple(45, 67), 3015);
            Assert.AreEqual(MathAlgorithms.LeastCommonMultiple(34, 4192), 71264);
            Assert.AreEqual(MathAlgorithms.LeastCommonMultiple(12, 65), 780);
            Assert.AreEqual(MathAlgorithms.LeastCommonMultiple(12, 64), 192);
        }
    }
}