/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using NGenerics.DataStructures.General;

namespace NGenerics.Tests.DataStructures.General.MaxHeapTests
{
 
    public class MaxHeapTest
    {

        internal static Heap<int> GetTestHeap()
        {
            var heap = new Heap<int>(HeapType.Maximum) { 5, 4, 99, 12, 5 };

            return heap;
        }

    }


}
