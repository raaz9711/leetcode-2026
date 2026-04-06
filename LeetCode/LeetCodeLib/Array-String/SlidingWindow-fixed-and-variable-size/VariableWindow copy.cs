namespace LeetCode_Window;
public class VariableWindowCopy
{
    public (int,string) LengthOfLongestSubstring(string s)
    {
        int maxLength = 0;int prev = 0;string longest = "";
        int left = 0;
        // char -> last seen index
        Dictionary<char,int> seen = new Dictionary<char, int>();
        int right = 0;
        for( right = 0; right < s.Length; right++)
        {
            char c = s[right];
            // If duplicate is found AND it's inside our current window 
            if(seen.ContainsKey(c) && seen[c] >= left)
            {
                left = seen[c] + 1; // Shrink: jump left past the duplicate
            }
                seen[c] = right; // update the seen position
                prev = maxLength;    
                maxLength = Math.Max(maxLength,right-left+1);
                if(maxLength > prev)
                {
                    longest = s.Substring(left,right-left+1);
                    Console.WriteLine($"New Max Length {maxLength} found at index {right} with char '{c}'");
                Console.WriteLine($"Window is now '{s.Substring(left,right-left+1)}'");
                }
        }

        Console.WriteLine(s);
        foreach(var i in seen)
        {
            Console.WriteLine($"{i.Key} -> {i.Value}");
        }
        return (maxLength,longest);
    }
}