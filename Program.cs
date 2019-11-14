using System;
using System.Collections.Generic;

namespace Algorithm_11._12._19
{
    class Program
    {
        // 1. Two Sum ✓?
        // Given an array of integers, return indices of the two numbers such that they add up to a specific target. You may assume that each input would have exactly one solution, and you may not use the same element twice.
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] indices;
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if(j != i)
                    {
                        if(nums[i] + nums[j] == target) 
                        {
                            return indices = new int[] {i, j};
                        }
                    }
                }
            }
            return null;
        }

        // public static int[] TwoSum(int[] nums, int target)
        // {
        //     var dc = new Dictionary<int, int>();
        //     for(int i = 0; i < nums.Length; i++)
        //     {
        //         if(dc.ContainsKey(nums[i]))
        //         {
        //             return new int[] {i, dc[nums[i]]};
        //         }
        //         dc[target - nums[i]] = i;
        //     }
        //     return null;
        // }


        // 2. Remove Element ✓
        // Given an array nums and a value val, remove all instances of  that value in-place and return the new length. Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory. The Order of elements can be changed. It doesn't matter what you leave beyond the new length.
        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            for(int j = 0; j < nums.Length; j++)
            {
                if(nums[j] !=  val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;
        }


        // 3. Merge Sorted Array ?
        // Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
        // Note: The number of elements initialized in nums1 and nums2 are m and n respecitively.
        // Note: You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2.
        public static int[] MergeSortedArray(int[] nums1, int m, int[] nums2, int n)
        {
            int i = 0;
            int j = 0;
            int a = 0;
            while(j < n)
            {
                if(nums2[j] < nums1[i] || a >= m)
                {
                    for(int k = m + j - 1; k >= i; k--)
                    {
                        nums1[k + 1] = nums1[k];
                    }
                    nums1[i] = nums2[j];
                    i++;
                    j++;
                }
                else if(nums2[j] >= nums1[i])
                {
                    i++;
                    a++;
                }
            }
            return nums1;
        }


        // 4. Length of Last Word ✓
        // Given a string s c onsists of upper/lower-case alphabets and empty space characters ' ', return the length of the last word in the string. If the last word does not exist, return 0.
        // Note: A word is defined as a character sequence consists of non-space characters only.
        public static int LengthOfLastWord(string s)
        {
            var lastWord = s.Split(' ');
            return lastWord[lastWord.Length - 1].Length;
        }

        public static int LengthOfLastWord2(string s)
        {
            int idx = s.Length - 1;
            while(idx >= 0 && s[idx] == ' ')
            {
                idx--;
            }

            int count = 0;
            while(idx >= 0 && s[idx] != ' ')
            {
                count++;
                idx--;
            }
            return count;
        }

        // 5. Valid Palindrome ✓
        // Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
        // Note: for the purpose of this proble, we define empty string as a valid palindrome.
        public static bool ValidPalindrome(string s)
        {
            int i = 0;
            int j = s.Length-1;
            while(i < j)
            {
                if(!Char.IsLetterOrDigit(s[i]))
                {
                    i++;
                }
                else if(!Char.IsLetterOrDigit(s[j]))
                {
                    j--;
                }
                else if(Char.ToLower(s[i]) != Char.ToLower(s[j]))
                {
                    return false;
                }
                else
                {
                    i++;
                    j--;
                }
            }
            return true;
        }


        // 6. Character Validation ?
        // Given a string containing just the characters '(',')','{','}','[' and ']', determine if the input string is valid.
        // An input string is valid if:
            // 1. Open brackets must be closed by the same type of brackets.
            // 2. Open brackets must be closed in the correct order.
            // 3. Note that an empty string is also considered valid.
        public static bool IsValid(string s)
        {
            Dictionary<char, char> dc = new Dictionary<char, char>();
            dc.Add(')','(');
            dc.Add(']','[');
            dc.Add('}','{');
            
            int i = 0;
            Stack<char> stack = new Stack<char>();
            while(i < s.Length)
            {
                if(dc.ContainsKey(s[i]))
                {
                    if(stack.Count == 0) return false;
                    if(dc[s[i]] != stack.Pop())
                        return false;
                }
                else
                {
                    stack.Push(s[i]);
                }
                i++;
            }
            if(stack.Count == 0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            // // Remove Element
            // // Given nums = [3,2,2,3], val = 3
            // // Your function should return length = 2, with the first two elements of nums being 2.
            // // It doesn't matter what you leave beyond the returned length.
            // int[] nums = new int[] {3,2,2,3,3,4,5,6,7};
            // int val = 3;
            // Console.WriteLine(RemoveElement(nums, val));

            // // Two Sum
            // // Given nums = [2,7,11,15], target = 9
            // // Because nums[0] + nums[1] = 2 + 7 = 9
            // // Return [0,1]
            // int[] nums = new int[] {2,7,11,15};
            // int target = 9;
            // var twosum = TwoSum(nums, target);
            // foreach(var i in twosum)
            // {
            //     Console.WriteLine(i);
            // }

            // // Merge Sorted Array
            // // nums1 = [1,2,3,0,0,0], m = 3
            // // nums2 = [2,5,6], n = 3
            // // Output: [1,2,2,3,5,6]
            // int[] nums1 = new int[] {1,2,3,0,0,0};
            // int m = 3;
            // int[] nums2 = new int[] {2,5,6};
            // int n = 3;
            // var mergeSortedArray = MergeSortedArray(nums1, m, nums2, n);
            // foreach(var i in mergeSortedArray)
            // {
            //     Console.WriteLine(i);
            // }

            // // Length of Last Word
            // // Input: "Hello World"
            // // Output: 5
            // Console.WriteLine(LengthOfLastWord("Hello World"));
            // Console.WriteLine(LengthOfLastWord2("Hello Worldddd"));

            // // Valid Palindrome
            // // Input: "A man, a plan, a canal: Panama" - Output: true
            // // Input: "race a car" - Output: false
            // string s = "A man, a plan, a canal: Panama";
            // string t = "race a car";
            // Console.WriteLine(ValidPalindrome(s));
            // Console.WriteLine(ValidPalindrome(t));

            // // Character Validation
            // string test1 = "()[]{}";
            // string test2 = "([)]";
            // Console.WriteLine(IsValid(test1));
            // Console.WriteLine(IsValid(test2));
        }
    }
}
