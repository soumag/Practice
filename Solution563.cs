using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Practise
{
    class Solution563
    {
        public int FindTilt(TreeNode root)
        {
            int tiltSum = 0;
            FindSum(root, ref tiltSum);
            return tiltSum;
        }

        public int FindSum(TreeNode root, ref int tiltSum)
        {
            if (root == null)
                return 0;
            int leftSum = FindSum(root.left, ref tiltSum);
            int rightSum = FindSum(root.right, ref tiltSum);
            tiltSum += Math.Abs(leftSum - rightSum);
            return leftSum + rightSum + root.val;
        }
    }
}
