class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
    twoSum(nums, target) {
        let seen = new Map();

        for(let i = 0; i < nums.length; i++)
        {
            let curr = nums[i];
            let desired = target - curr;

            if(seen.has(desired)) {return [seen.get(desired), i];}

            seen.set(curr, i);
        }

        return [0,0];
    }
}
