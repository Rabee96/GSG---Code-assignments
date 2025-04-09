public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numsHistory = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if (numsHistory.ContainsKey(diff)) {
                return new int[] { numsHistory[diff], i };
            }
            if (!numsHistory.ContainsKey(nums[i])) {
                numsHistory.Add(nums[i], i);
            }
        }

        return new int[0];
    }
}
