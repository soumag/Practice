using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Practise
{
    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
    class Solution617
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
                return CopyTree(t2);
            if (t2 == null)
                return CopyTree(t1);
            TreeNode newNode = new TreeNode(t1.val + t2.val);
            newNode.left = MergeTrees(t1.left, t2.left);
            newNode.right = MergeTrees(t1.right, t2.right);
            return newNode;
        }

        public TreeNode CopyTree(TreeNode t)
        {
            if (t == null)
                return null;
            TreeNode newNode = new TreeNode(t.val);
            newNode.left = CopyTree(t.left);
            newNode.right = CopyTree(t.right);
            return newNode;
        }
    }
}
