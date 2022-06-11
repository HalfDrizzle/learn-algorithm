using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithm.LearnTree
{
    internal class LeetCode617 : TreeExample
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if(root1 == null)
                return root2;
            if (root2 == null)
                return root1;

            root1.val += root2.val;
            if(root1.left != null)
            {
                MergeTrees(root1.left, root2.left);
            }
            if (root2.right != null)
            {
                MergeTrees(root1.right, root2.right);
            }

            return root1;
        }

        public TreeNode MergeTreesB(TreeNode root1, TreeNode root2)
        {
            if (root1 == null)
                return root2;
            if (root2 == null)
                return root1;

            root1.val += root2.val;
            if (root1.left != null)
            {
                MergeTrees(root1.left, root2.left);
            }
            if (root2.right != null)
            {
                MergeTrees(root1.right, root2.right);
            }

            return root1;
        }


    }
}
