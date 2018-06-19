using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Practise
{
    class Solution654
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return ConstructMaximumBinaryTreeHelper(nums, 0, nums.Length-1);
        }

        public TreeNode ConstructMaximumBinaryTreeHelper(int[] nums, int start, int end)
        {
            if (start > end)
                return null;
            int maxIndex = findMaximum(nums, start, end);
            TreeNode newNode = new TreeNode(nums[maxIndex]);
            newNode.left = ConstructMaximumBinaryTreeHelper(nums, start, maxIndex - 1);
            newNode.right = ConstructMaximumBinaryTreeHelper(nums, maxIndex + 1, end);
            return newNode;
        }

        private int findMaximum(int[] arr, int start, int end)
        {
            int max = Int32.MinValue;
            int maxIndex = -1;
            for (int i=start; i<=end; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}
