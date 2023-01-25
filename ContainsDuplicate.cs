using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal static class ContainsDuplicate
    {
        public static bool ContainsDuplicateWithLoop(int[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                    if (count > 1)
                    {
                        return true;
                    }
                }

            }
            return false;

        }
        public static bool ContainsDuplicateWithHashSet(int[] nums)
        {
            var hashedNums = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashedNums.Contains(nums[i]))
                    return true;

                hashedNums.Add(nums[i]);

            }
            return false;

        }
        public static bool ContainsDuplicateWithHashSet2(int[] nums)
        {
            var hashedNums = new HashSet<int>();
            return new HashSet<int>(nums).Count < nums.Length;
        }
    }
    internal static class MissingNumbers
    {
        //Input: nums = [3,0,1]

        public static int MissingNumber(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[0] != 0)
                    return 0;

                if (i + 1 >= nums.Length)
                    return i + 1;

                if (nums[i + 1] - nums[i] != 1)
                    return i + 1;
            }
            return 0;
        }
        public static int MissingNumberContains(int[] nums)
        {

            for (int i = 0; i < nums.Length + 1; i++)
            {
                if (!nums.Contains(i))
                    return i;
            }
            return 0;
        }
        public static int MissingNumberXOR(int[] nums)
        {
            // xor the existing numbers
            var xorOfNums = nums.Aggregate((x, y) => x ^ y);
            // xor the numbers from 1 to N.
            var xorOfOneToN = Enumerable.Range(1, nums.Length).Aggregate((x, y) => x ^ y);
            // Xor the above two Xors to get the result.
            return xorOfNums ^ xorOfOneToN;
        }
        public static int MissingNumberSums(int[] nums)
        {
            int totalSum = (nums.Length * (nums.Length + 1)) / 2;
            int currentSum = 0;
            foreach (int n in nums)
            {
                currentSum += n;
            }
            return totalSum - currentSum;
        }
        public static int MissingNumberRemove(int[] nums)
        {
            var full = Enumerable.Range(0, nums.Count() + 1).ToList();

            for (var i = 0; i < nums.Count(); i++)
            {
                full.Remove(nums[i]);
            }
            //Remaining 
            return full.First();
        }
    }
    internal static class FindNumbers
    {
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            var numsList = nums.ToList<int>();
            for (var i = 1; i < nums.Length + 1; i++)
            {
                numsList.Add(i);
            }

            var hashed = new HashSet<int>(numsList);
            return hashed.Where(x => !nums.Contains(x)).Select(x => x).ToArray();
        }
        public static IList<int> FindDisappearedNumbersHashed(int[] nums)
        {
            var allNums = Enumerable.Range(1, nums.Length);
            var hashed = new HashSet<int>(allNums);
            return hashed.Where(x => !nums.Contains(x)).Select(x => x).ToArray();
        }
        public static IList<int> FindDisappearedNumbersEnumerable(int[] nums)
        {
            var allNums = Enumerable.Range(1, nums.Length);
            return allNums.Except(nums).ToList();
        }
    }
    internal static class SingleNumber
    {
        public static int SingleNumberLinq(int[] nums)
        {
            return nums.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key).FirstOrDefault();
        }
        public static int SingleNumberAggregate(int[] nums)
        {
            return nums.Aggregate((x, y) => x ^ y);
        }
        public static int SingleNumberXOR(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }
    }

    internal static class OneDArrayIntoTwoDArray
    {
        /*
        You are given a 0-indexed 1-dimensional (1D) integer array original, and two integers, m and n. 
        You are tasked with creating a 2-dimensional (2D) array with m rows and n columns using all the elements from original.
        The elements from indices 0 to n - 1 (inclusive) of original should form the first row of the constructed 2D array, 
        the elements from indices n to 2 * n - 1 (inclusive) should form the second row of the constructed 2D array, and so on.
        Return an m x n 2D array constructed according to the above procedure, or an empty 2D array if it is impossible.
         */
        public static int[][] Construct2DArray(int[] original, int m, int n)
        {
            if (m * n != original.Length )
                return new int[0][];
            
            int[][] _twoDarray = new int[m][];
            int index = 0;
            for (int row = 0; row < m; row++)
            {
                _twoDarray[row] = new int[n];
                for (int col = 0; col < n; col++)
                {

                    _twoDarray[row][col] = original[index];
                    index++;
                }
            }
            return _twoDarray;
        }

    }

    internal static class ReshapetheMatrix
    {
        public static int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            if (r * c != mat.Length * mat[0].Length)
                return mat;

            int[][] _twoDarray = new int[r][];
            int colIndex = 0;
            int rowIndex = 0;

                _twoDarray[rowIndex] = new int[c];
                for (int row = 0; row < mat.Length; row++)
                {
                    for (int col = 0; col < mat[row].Length; col++)
                    {
                        _twoDarray[rowIndex][colIndex] = mat[row][col];
                        
                        if (colIndex < c - 1)
                        {
                            colIndex++;
                        }
                        else
                        {
                            if (rowIndex < r - 1)
                            {
                                rowIndex++;
                                colIndex = 0;
                                _twoDarray[rowIndex] = new int[c];
                            }
                        }
                    }
                }
            
            return _twoDarray;
        }

        public static int[][] MatrixReshapeEnumerator(int[][] mat, int r, int c)
        {
            if (mat.Length * mat[0].Length != r * c)
                return mat;

            IEnumerator<int> matrixEnumerator = MatrixEnumerator(mat);

            int[][] result = new int[r][];
            for (int i = 0; i < r; i++)
            {
                result[i] = new int[c]; ;
                for (int j = 0; j < c; j++)
                    if (matrixEnumerator.MoveNext())
                        result[i][j] = matrixEnumerator.Current;
            }

            return result;
        }

        // Flatten matrix.
        private static IEnumerator<int> MatrixEnumerator(int[][] mat)
        {
            for (int i = 0; i < mat.Length; i++)
                for (int j = 0; j < mat[0].Length; j++)
                    yield return mat[i][j];
        }
    }

    internal static class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            int startIndex = 0;
            int endIndex = nums.Length - 1;

            while (startIndex <= endIndex)
            {
                //int mid = startIndex + (endIndex - startIndex) /2;
                int mid = (startIndex + endIndex) >> 1; //Floor Division Shift one bit to the right

                if (target == nums[mid])
                    return mid;

                if (target < nums[mid])
                    endIndex = mid - 1;
                else
                    startIndex = mid + 1;
            }
            return -1;
        }
    }

    internal static class SmallestLetterGreaterThanTarget
    {
        /*
         Given a characters array letters that is sorted in non-decreasing order and a character target,
        return the smallest character in the array that is larger than target.
        Note that the letters wrap around.
        For example, if target == 'z' and letters == ['a', 'b'], the answer is 'a'.

        Example 1:
        Input: letters = ["c","f","j"], target = "a"
        Output: "c"
        Example 2:

        Input: letters = ["c","f","j"], target = "c"
        Output: "f"
        Example 3:

        Input: letters = ["c","f","j"], target = "d"
        Output: "f"
         */
        public static char NextGreatestLetter(char[] letters, char target)
        {
            if (target >= letters[letters.Length - 1])
                return letters[0];

            if (letters.Distinct().Count() < 2)
                return letters[0];

            var hashed = new HashSet<char>(letters);

            //return (from l in hashed where l > target select l)
            //    .DefaultIfEmpty(letters[0]).FirstOrDefault();

            return (from l in letters where l > target select l)
                .DefaultIfEmpty(letters[0]).FirstOrDefault();
        }

        public static char NextGreatestLetterBS(char[] letters, char target)
        {
            if (target >= letters[letters.Length - 1])
                return letters[0];

            if (letters.Distinct().Count() < 2)
                return letters[0];

            int startChar = 0;
            int endChar = letters.Length - 1;
            while (startChar < endChar -1)
            {
                int midIndex = (startChar + endChar) >> 1;

                if (target < letters[midIndex])
                    endChar = midIndex;
                else
                    startChar = midIndex ;
            }

            if (target > letters[endChar])
                return letters[startChar];

             if (target >= letters[startChar])
                return letters[endChar];

            return letters[startChar];
        }

    }
    public static class PeakIndexInAMountainArray
    {
        /*
         An array arr a mountain if the following properties hold:

        arr.length >= 3
        There exists some i with 0 < i < arr.length - 1 such that:
        arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
        arr[i] > arr[i + 1] > ... > arr[arr.length - 1]
        Given a mountain array arr, 
        return the index i such that arr[0] < arr[1] < ... < arr[i - 1] < arr[i] > arr[i + 1] > ... > arr[arr.length - 1].

        You must solve it in O(log(arr.length)) time complexity.

        Example 1:
        Input: arr = [0,1,0]
        Output: 1

        Example 2:
        Input: arr = [0,2,1,0]
        Output: 1

        Example 3:
        Input: arr = [0,10,5,2]
        Output: 1
         */
        public static int PeakIndexInMountainArray(int[] arr)
        {
            if (arr.Length >= 3)
            {
                for (int i = 1; i <= arr.Length -1; i++)
                {
                    if (arr[i - 1] < arr[i] && arr[i] > arr[i + 1])
                    {
                        return i;
                    }
                }
            }
            return 0;
        }

        public static int PeakIndexInMountainArrayBS(int[] arr)
        {
            if (arr.Length >= 3)
            {
                int startIndex = 0;
                int endIndex = arr.Length;
                while(startIndex < endIndex -1)
                {
                    int mid = (startIndex + endIndex) >> 1;

                    if(arr[mid] < arr[startIndex])
                    {

                    }

                }
                //for (int i = 1; i <= arr.Length - 1; i++)
                //{
                //    if (arr[i - 1] < arr[i] && arr[i] > arr[i + 1])
                //    {
                //        return i;
                //    }
                //}
            }
            return 0;
        }
    }
}

