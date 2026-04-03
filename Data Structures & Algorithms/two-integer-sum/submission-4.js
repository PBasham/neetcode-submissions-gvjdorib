class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
    twoSum(nums, target) {

        let seen = [];

        for(let i = 0; i < nums.length; i++)
        {
            let current = nums[i];
            let lookingFor = target - current;
            if(seen.includes(lookingFor)) {return [seen.indexOf(lookingFor),i];}
            
            if(!seen.includes(current)) {seen.push(current);}
        }
        return [0,0];
    }
}
