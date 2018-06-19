using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Practise
{
    class Solution226
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;
            InvertTree(root.left);
            InvertTree(root.right);
            return root;            
        }
    }
}
