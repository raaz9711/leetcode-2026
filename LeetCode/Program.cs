// See https://aka.ms/new-console-template for more information
using LeetCodeLib.Array_String;

var sol = new TwoPointer();
int[] result = sol.TwoSum(new int[] { 1, 3, 4, 5, 7, 8, 11 }, 9);
Console.WriteLine($"[{result[0]}, {result[1]}]"); // [1, 6] → values 1 and 8
