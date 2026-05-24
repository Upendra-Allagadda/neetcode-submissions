
public class Solution {
    Dictionary<char, char> d = new();
    
    public Solution(){
        d.Add('(', ')');
        d.Add('{', '}');
        d.Add('[', ']');
    }

    public bool IsValid(string str) {
        Stack<char> s = new();
        foreach(char c in str){
            if(c == ')' || c== ']' || c=='}'){
                if(s.Count == 0) return false;
             if(d[s.Peek()] == c) s.Pop();
             else return false;  
            }
            if(c=='(' || c=='[' || c=='{') s.Push(c);
        }

       return s.Count == 0;

    }
}
