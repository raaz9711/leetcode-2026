namespace LeetCodeLib.Array_String;

public class TwoPointer
{
      // LC 167: Two Sum II - Input Array is Sorted
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            int sum = numbers[left] + numbers[right];

            if (sum == target)
                return new int[] { left + 1, right + 1 }; // 1-indexed
            else if (sum < target)
                left++;   // Need bigger sum → move left pointer right
            else
                right--;  // Need smaller sum → move right pointer left
        }

        return new int[] { -1, -1 }; // No pair found
    }
}

