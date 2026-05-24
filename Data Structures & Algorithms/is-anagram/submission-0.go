func isAnagram(s string, t string) bool {
    if len(s) != len(t) {
        return false
    }

    mp := make(map[byte]int)

    for i := 0 ; i < len(s); i++ {
        if _, ok := mp[s[i]]; ok{
            mp[s[i]]++
        } else {
            mp[s[i]] = 1
        }
        
    }

    for j := 0; j< len(t); j++ {
        if _, ok := mp[t[j]]; ok {
            mp[t[j]]--
        } else {
            return false
        }
    }

    for key, _ := range mp {
        if mp[key] < 0 {
            return false
        }
    }

    return true
}
