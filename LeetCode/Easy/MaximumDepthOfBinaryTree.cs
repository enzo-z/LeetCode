using LeetCode.Entities;

namespace LeetCode.Easy
{
    /// <summary>
    /// <a href="https://leetcode.com/problems/maximum-depth-of-binary-tree/">Original problem</a>
    /// </summary>
    public class MaximumDepthOfBinaryTree
    {
        public static int MySolution(TreeNode? root)
        {
           if (root == null) return 0;
           var leftNode = root.left;
           var rightNode = root.right;
           return Math.Max((MySolution(leftNode)), (MySolution(rightNode)) + 1);
        }
    }
    /*
    class TreeNode
    {
        public int val;
        public TreeNode104? left;
        public TreeNode104? right;

        public TreeNode104(int val, TreeNode104? left, TreeNode104? right)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    
    }*/
}
