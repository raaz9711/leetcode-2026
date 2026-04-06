namespace LeetCodeLib.Array_String;
public class ListNode
{
    public int Val;
    public ListNode? Next;
    public ListNode(int val) { Val = val; }
}

public class LinkedListCycle
{
    // LC 142: Linked List Cycle II — returns the node where cycle begins
    public ListNode DetectCycle(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        // Phase 1: detect if a cycle exists
        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;       // moves 1 step
            fast = fast.Next.Next;  // moves 2 steps

            if (slow == fast) // They met — cycle confirmed
            {
                // Phase 2: find cycle entry point
                // Reset slow to head; keep fast at meeting point
                slow = head;
                while (slow != fast)
                {
                    slow = slow.Next;
                    fast = fast.Next; // both move 1 step now
                }
                return slow; // Cycle entry node
            }
        }

        return null; // No cycle
    }
}
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

        return [-1, -1]; // No pair found
    }

    public int RemoveDuplicates(int[] arr)
    {
        if(arr.Length == 0)
            return 0;


        int slow = 0; // Write head - points to last confirmed unique element
        
        for(int fast = 1; fast < arr.Length; fast++)
        {
             if(arr[slow] != arr[fast]) // New Unique value found 
            {
                slow++;                // Advance write head
                arr[slow] = arr[fast]; // Write Unique value
            }
            PrintArr(arr);
            // If equal, fast keeps moving - slow stays put
        }
        //return unique portion length
        return slow + 1;
        
    }

     // LC 15: 3Sum — finds all unique triplets that sum to zero
    public IList<IList<int>> ThreeSumSolution(int[] nums)
    {
        var result = new List<IList<int>>();
        Array.Sort(nums); // Must sort first!

        for (int i = 0; i < nums.Length - 2; i++)
        {
            // Skip duplicates for the outer element
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    // Skip duplicates for left and right
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;

                    left++;
                    right--;
                }
                else if (sum < 0)
                    left++;
                else
                    right--;
            }
        }

        return result;
    }

    private void PrintArr(int[] arr)
    {
        Console.WriteLine(String.Join(',',arr));
    }
}

