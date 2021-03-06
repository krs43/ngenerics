/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using NGenerics.Tests.Util;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Trees.BinaryTreeTests
{
    [TestFixture]
    public class Serialization : BinaryTreeTest
    {

        [Test]
        public void Simple()
        {
            var binaryTree = GetTestTree();
            var newTree = SerializeUtil.BinarySerializeDeserialize(binaryTree);

            Assert.AreNotSame(binaryTree, newTree);
            Assert.AreEqual(binaryTree.Count, newTree.Count);

            var treeEnumerator = binaryTree.GetEnumerator();
            var newTreeEnumerator = newTree.GetEnumerator();

            while (treeEnumerator.MoveNext())
            {
                Assert.IsTrue(newTreeEnumerator.MoveNext());
                Assert.AreEqual(treeEnumerator.Current, newTreeEnumerator.Current);
                Assert.AreEqual(treeEnumerator.Current, newTreeEnumerator.Current);

                Assert.IsTrue(newTree.Contains(treeEnumerator.Current));
            }

            Assert.IsFalse(newTreeEnumerator.MoveNext());
        }

    }
}