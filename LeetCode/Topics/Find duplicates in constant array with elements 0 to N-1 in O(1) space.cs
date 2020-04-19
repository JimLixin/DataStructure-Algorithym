using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.Topics
{
    /// <summary>
    /// https://www.geeksforgeeks.org/find-duplicates-constant-array-elements-0-n-1-o1-space/
    /// The idea is to consider array items as linked list nodes. 
    /// Any particular index is pointing to the value at that index.
    /// And you will see that there is loop as shown in the image below- In case of duplicate, 
    /// 
    /// two indexes will have same value and they will form a cycle just like in the image given below.
    /// So we can find the entry point of cycle in the linked list and that will be our duplicate element.
    ///     We maintain two pointers fast and slow
    ///     For each step fast will move to the index that is equal to arr[arr[fast]] (two jumps at a time) and slow will move to the index arr[slow](one step at a time)
    ///     When fast==slow that means now we are in a cycle.
    ///     Fast and slow will meet in a circle and the entry point of that circle will be the duplicate element.
    ///     Now we need to find entry point so we will start with fast= 0 and visit one step at a time for both fast and slow.
    ///     When fast==slow that will be entry point.
    ///     Return the entry point.
    /// </summary>
    class Find_duplicates_in_constant_array_with_elements_0_to_N_1_in_O_1__space
    {
    }
}
