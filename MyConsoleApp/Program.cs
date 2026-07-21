// See https://aka.ms/new-console-template for more information
using LCSolution_1;

var LC = new LCSolution();

int[] nums = {1 , -1 , 0};
int target = 0;

int op = LC.SubarraySum(nums,target);

Console.WriteLine($"Main ,{op}",op);