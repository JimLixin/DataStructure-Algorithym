using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.Topics
{
    class Swapping_two_integer_variables_without_an_intermediary_variable
    {
        public void swap(int A, int B)
        {
            A = A ^ B; // A is now XOR of A and B
            B = A ^ B; // B is now the original A
            A = A ^ B; // A is now the original B
        }
    }
}
