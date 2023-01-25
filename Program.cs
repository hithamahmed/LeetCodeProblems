
namespace LeetCode.Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int[] nums = { 1, 2, 3, 4, 1, 6, 3, 2 };

            //Console.WriteLine(ContainsDuplicate.ContainsDuplicateWithLoop(nums));

            //nums =  new int[] { 0,1,3};

            //Console.WriteLine(MissingNumbers.MissingNumber(nums));
            //Console.WriteLine(MissingNumbers.MissingNumberXOR(nums));
            //Console.WriteLine(MissingNumbers.MissingNumberSums(nums));
            //Console.WriteLine(MissingNumbers.MissingNumberContains(nums));

            //nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };            
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //Console.WriteLine(string.Join(", ", FindNumbers.FindDisappearedNumbers(nums)));
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedTicks);

            //watch = System.Diagnostics.Stopwatch.StartNew();
            //Console.WriteLine(string.Join(", ", FindNumbers.FindDisappearedNumbersHashed(nums)));
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedTicks);

            //watch = System.Diagnostics.Stopwatch.StartNew();
            //Console.WriteLine(string.Join(", ", FindNumbers.FindDisappearedNumbersEnumerable(nums)));
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedTicks);

            //nums = new int[] { 2,2,1 };
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //Console.WriteLine(string.Join(", ", SingleNumber.SingleNumberLinq(nums)));
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedTicks);

            //watch = System.Diagnostics.Stopwatch.StartNew();
            //Console.WriteLine(string.Join(", ", SingleNumber.SingleNumberAggregate(nums)));
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedTicks);

            //watch = System.Diagnostics.Stopwatch.StartNew();
            //Console.WriteLine(string.Join(", ", SingleNumber.SingleNumberXOR(nums)));
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedTicks);

            //nums = new int[] {1,2,3,4 };
            //int row = 1;
            //int col = 4;
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //Console.WriteLine(string.Join(", ", OneDArrayIntoTwoDArray.Construct2DArray(nums,row,col).Aggregate((x, y) => x )));
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedTicks);


            //int[][] matrix = new int[][] { new[] { 1, 2 }, new[] { 3,4 } };

            //int row = 1;
            //int col = 4;
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //Console.WriteLine(string.Join(", ", ReshapetheMatrix.MatrixReshape(matrix, row, col).Aggregate((x, y) => x)));
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedTicks);

            //nums = new int[] { -1, 0, 3, 5, 9, 12 };
            //int target = 9;
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //Console.WriteLine(string.Join(", ", BinarySearch.Search(nums, target)));
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedTicks);

            //char[] letters= new char[] {'c','f','j' };
            //char target = 'z';
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //Console.WriteLine(string.Join(", ", SmallestLetterGreaterThanTarget.NextGreatestLetterBS(letters, target)));
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedTicks);

            nums = new int[] { 0,10,5,2};
            watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(string.Join(", ", PeakIndexInAMountainArray.PeakIndexInMountainArray(nums)));
            watch.Stop();
            Console.WriteLine(watch.ElapsedTicks);
        }
    }
}