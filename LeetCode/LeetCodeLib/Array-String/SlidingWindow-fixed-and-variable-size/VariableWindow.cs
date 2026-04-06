public class VariableWindow
{
    // LC 3: Longest Substring Without Repeating Characters
    public int LengthOfLongestSubstring(string s)
    {
        var seen = new Dictionary<char, int>(); // char → last seen index
        int maxLen = 0;
        int left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];

            // If duplicate found AND it's inside our current window
            if (seen.ContainsKey(c) && seen[c] >= left)
                left = seen[c] + 1;  // Shrink: jump left past the duplicate

            seen[c] = right;         // Update last seen position
            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }
}