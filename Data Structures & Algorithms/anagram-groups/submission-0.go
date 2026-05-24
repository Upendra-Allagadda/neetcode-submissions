func groupAnagrams(strs []string) [][]string {
    if len(strs) == 1 {
        return [][]string{strs}
    }

    strArray := [][]string {}
    track := make([]bool, len(strs))
    for i := 0; i<len(strs); i++ {
        if track[i] {
            continue
        }
        temp := []string {}
        temp = append(temp, strs[i])
        for j := i+1; j<len(strs); j++ {
            
            if hasSameLetters(strs[i], strs[j]) {
                track[j] = true
                temp = append(temp, strs[j])
            }
        }
        strArray = append(strArray, temp)
    }
    return strArray
}

func hasSameLetters(first string, second string) bool{
    if len(first) != len(second) {
        return false
    }

    mp := [26]int {}

    for i := 0; i < len(first); i++{
        mp[first[i]-'a']++
        mp[second[i]-'a']--
    }

    for _, val := range mp {
        if val != 0{
            return false
        }
    }
    return true
}
