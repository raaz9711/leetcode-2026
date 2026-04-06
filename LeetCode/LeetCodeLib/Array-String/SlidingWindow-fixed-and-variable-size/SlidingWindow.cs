namespace LeetCode_Window;
public class FixedWindow
{
    // LC 643: Maximum Average Subarray I
    public double FindMaxAverage(int[] nums, int k)
    {
        // Build the first window
        int windowSum = 0;
        for (int i = 0; i < k; i++)
            windowSum += nums[i];

        int maxSum = windowSum;

        // Slide: add right element, drop left element
        for (int right = k; right < nums.Length; right++)
        {
            windowSum += nums[right];          // Expand right
            windowSum -= nums[right - k];      // Shrink left
            maxSum = Math.Max(maxSum, windowSum);
        }

        return (double)maxSum / k;
    }
}

// // Usage
// var sol = new FixedWindow();
// Console.WriteLine(sol.FindMaxAverage(new int[] { 2, 1, 5, 1, 3, 2 }, 3)); // 3.0 → (5+1+3)/3