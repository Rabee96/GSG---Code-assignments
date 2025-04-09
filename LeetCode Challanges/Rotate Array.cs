public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        if (n <= 1) return;

        k = k % n;

        int[] replica = new int[n];
        nums.CopyTo(replica, 0);

        for (int i = 0; i < n; i++) {
            nums[(i + k) % n] = replica[i];
        }
    }
}
