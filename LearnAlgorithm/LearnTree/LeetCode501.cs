using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithm.LearnTree
{
    internal class LeetCode501:TreeExample
    {
        public LeetCode501()
        {
            FindMode(new TreeNode());
        }
        List<int> list = new List<int>();
        public int[] FindMode(TreeNode root)
        {
            var resultList = new List<int>();
            //GetBSTNode(root);
            list = new List<int> { 1,2,2 };

            int max = 0;
            int begin = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] != list[i + 1])
                {
                    var count = i - begin + 1;
                    begin = i + 1;
                    if (count > max)
                    {
                        max = count;
                        resultList.Clear();
                    }
                    resultList.Add(list[i]);
                }
            }

            return resultList.ToArray();
        }
        private void GetBSTNode(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            GetBSTNode(node.left);
            list.Add(node.val);
            GetBSTNode(node.right);
        }
    }
}
