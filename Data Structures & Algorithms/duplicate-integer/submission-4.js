class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        let seen = [];

        for(let num of nums)
        {
            if(seen.includes(num)) {return true;}
            seen.push(num);
        }
        return false;
    }
}
