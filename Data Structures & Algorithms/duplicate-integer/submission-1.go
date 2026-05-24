func hasDuplicate(nums []int) bool {
    mp := make(map[int]struct{})
    for _, val := range nums {
        if _, exists := mp[val]; exists {
            return true
        } else {
            mp[val] = struct{}{}
        }
    }
    return false
}
