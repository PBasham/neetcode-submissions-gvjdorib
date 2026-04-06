/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root == null) {return null;}
        
        return RecurseDown(root);
        
    }

    public TreeNode RecurseDown(TreeNode root) {
        
        var _temp = root.left;
        root.left = root.right;
        root.right = _temp;

        if(root.left != null) {RecurseDown(root.left);}
        if(root.right != null) {RecurseDown(root.right);}

        return root;
    }
}
