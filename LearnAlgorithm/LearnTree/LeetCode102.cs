using System.Collections.Generic;

namespace LearnAlgorithm.LearnTree
{
    internal class LeetCode102
    {
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public class Solution
        {
            public IList<IList<int>> LevelOrder(TreeNode root)
            {
                var queneRoot = new Queue<TreeNode>();
                queneRoot.Enqueue(root);
                var resultList = new List<IList<int>>();
                while (queneRoot.Count != 0)
                {
                    var size = queneRoot.Count;
                    var value = queneRoot.Dequeue();
                    var resultListEle = new List<int>(size);
                    resultListEle.Add(value.val);
                    for (int i = 0; i < size; i++)
                    {
                        if (value.left != null)
                        {
                            queneRoot.Enqueue(value.left);
                        }
                        if (value.right != null)
                        {
                            queneRoot.Enqueue(value.right);
                        }
                    }
                    resultList.Add(resultListEle);
                }

                return resultList;
            }
        }
    }
}
