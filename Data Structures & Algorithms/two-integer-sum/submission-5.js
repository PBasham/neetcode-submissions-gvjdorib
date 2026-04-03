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
            let current = nums[i];
            let lookingFor = target - current;
            
            if(seen.has(lookingFor)) {return [seen.get(lookingFor), i];}

            if(!seen.has(current)) {seen.set(current, i);}
        }
        return [0,0];
    }
}
