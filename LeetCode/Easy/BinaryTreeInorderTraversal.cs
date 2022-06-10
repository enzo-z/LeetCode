using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /// <summary>
    /// Original problem <a href="https://leetcode.com/problems/binary-tree-inorder-traversal/">here</a>.
    /// </summary>

    internal class BinaryTreeInorderTraversal
    {
        public Stack<TreeNode> myStack = new();

        public IList<int> InorderTraversal(TreeNode root)
        {
            List <int> result = new();

            TraverseTree(root);

            while(myStack.Count > 0)
            {
                var node = myStack.Pop();
                result.Add(node.val);
                TraverseTree(node.right);
            }

            return result;
            
        }

        public void TraverseTree(TreeNode node)
        {
            while(node is not null)
            {
                myStack.Push(node);
                node = node.left;
            }
        }
    }

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val=0, TreeNode left=null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
