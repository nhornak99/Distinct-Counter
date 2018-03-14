using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    public class DuplicateRemover
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null)
            {
                return 0;
            }
            int duplicates = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    duplicates++;
                }
            }
            return nums.Length - duplicates;
        }

        // Using LINQ
        public int RemoveDuplicatesLinq(int[] nums)
        {
            return nums != null ? nums.Distinct().Count() : 0;
        }
    }
}
