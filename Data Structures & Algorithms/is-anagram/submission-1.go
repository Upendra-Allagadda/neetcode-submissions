func isAnagram(s string, t string) bool {
    if len(s) != len(t) {
        return false
    }

    mp := make(map[byte]int)

    for i := 0 ; i < len(s); i++ {
        mp[s[i]]++
        mp[t[i]]--
    }

    for _, val := range mp {
        if val != 0 {
            return false
        }
    }

    return true
}
