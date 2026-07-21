namespace LCSolution_1;
public class LCSolution {
    public int SubarraySum(int[] nums, int k) {
        int count = 0;
        int sum = 0;
        int l = 0 ;
//1 -1 0
        for(int r = 0; r < nums.Length; r++)
        {
            sum += nums[r];
            Console.WriteLine($"Addition : {sum}",sum);
            while(sum <= k && l < r)
            {
                if(sum == k)
                {
                    count++;
                }
                sum -= nums[l++];
              Console.WriteLine($"Subtraction : {sum}",sum);
            }
        }

        return count;
    }
}