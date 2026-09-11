public class Solution {
    public bool IsValid(string s) {
        Stack<char> openings = new Stack<char>();
        foreach(char c in s)
        {
            if(c.Equals('(') || c.Equals('[') || c.Equals('{'))
                openings.Push(c);
            else
            {
                if(openings.Count > 0)
                {
                var current = openings.Pop();
                switch(c)
                {
                    case ')':
                     if(!current.Equals('('))
                        return false; 
                        break;
                    case ']': 
                     if(!current.Equals('['))
                        return false;
                        break;
                    case '}': 
                     if(!current.Equals('{'))
                        return false;
                        break;
                    default: return false;
                }
                }
                else
                    return false;
            }
        }
        if(openings.Count > 0)
            return false;
        return true;
    }
}
