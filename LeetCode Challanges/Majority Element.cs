public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> numsHistory = new Dictionary<int, int>();
        int result = nums[0];
        for (int i = 0; i < nums.Length; i++) {
            if (numsHistory.ContainsKey(nums[i])) {
                numsHistory[nums[i]]++;
            }else {
                numsHistory.Add(nums[i], 1);
            }
        }
        foreach(int key in numsHistory.Keys){
            if (numsHistory[result] < numsHistory[key])
                result = key;
        }
        return result;
    }
}