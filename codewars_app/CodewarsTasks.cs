using System;

namespace CodewarsTasks
{
    /// <summary>
    /// The <c>CodewarsTasks</c> class contains methods for solving various tasks.
    /// </summary>
    public class CodewarsTasks
    {
        /// <summary>
        /// The <c>Greet</c> method greets a user based on their name.
        /// If the name matches the owner's name, it returns "Hello boss"; otherwise, "Hello guest".
        /// </summary>
        /// <param name="name">The user's name.</param>
        /// <param name="owner">The owner's name.</param>
        /// <returns>A greeting string: "Hello boss" or "Hello guest".</returns>
        public static string Greet(string name, string owner)
        {
            int result = string.Compare(name, owner);
            if (result != 0)
            {
                return "Hello guest";
            }
            return "Hello boss";
        }

        /// <summary>
        /// The <c>DigitalRoot</c> method calculates the digital root of a number.
        /// The digital root is the recursive sum of all digits until a single-digit number is obtained.
        /// </summary>
        /// <param name="n">A long integer input.</param>
        /// <returns>The digital root of the input number.</returns>
        public static int DigitalRoot(long n)
        {
            char[] charArr = n.ToString().ToCharArray();

            if (charArr.Length == 1) return (int)n;

            long sum = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                sum += charArr[i] - '0';
            }

            return DigitalRoot(sum);
        }

        /// <summary>
        /// The <c>FinalGrade</c> method calculates a student's final grade based on exam score and project count.
        /// </summary>
        /// <param name="exam">The exam score (integer).</param>
        /// <param name="projects">The number of completed projects (integer).</param>
        /// <returns>The final grade as an integer (100, 90, 75, or 0).</returns>
        public static int FinalGrade(int exam, int projects)
        {
            if (exam > 90 | projects > 10)
            {
                return 100;
            }
            else if (exam > 75 & projects > 4)
            {
                return 90;
            }
            else if (exam > 50 & projects > 1)
            {
                return 75;
            }
            return 0;
        }

        /// <summary>
        /// The <c>Include</c> method checks if an item exists in an array.
        /// </summary>
        /// <param name="arr">An array of integers to search within.</param>
        /// <param name="item">The item to search for.</param>
        /// <returns>True if the item is found in the array; otherwise, false.</returns>
        public static bool Include(int[] arr, int item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item) return true;
            }
            return false;
        }

        /// <summary>
        /// The <c>RowSumOddNumbers</c> method calculates the sum of odd numbers in a row of a triangle.
        /// </summary>
        /// <param name="n">The row number (long integer).</param>
        /// <returns>The sum of odd numbers in the nth row.</returns>
        public static long RowSumOddNumbers(long n)
        {
            return n * n * n;
        }

        /// <summary>
        /// The <c>MyLanguages</c> method filters and sorts programming languages based on their scores.
        /// It returns a collection of languages with scores greater than or equal to 60, sorted in descending order of scores.
        /// </summary>
        /// <param name="results">A dictionary where keys are language names and values are scores.</param>
        /// <returns>An enumerable collection of language names that meet the criteria.</returns>
        public static IEnumerable<string> MyLanguages(Dictionary<string, int> results)
        {
            var sortedDict = results
                .Where(lang => lang.Value >= 60)
                .OrderByDescending(lang => lang.Value)
                .Select(lang => lang.Key);

            return sortedDict;
        }

        /// <summary>
        /// The <c>SymmetricPoint</c> method calculates the symmetric point of a given point <paramref name="p"/> relative to another point <paramref name="q"/>.
        /// The symmetric point is calculated using the formula: 
        /// x' = 2 * q[0] - p[0], y' = 2 * q[1] - p[1].
        /// </summary>
        /// <param name="p">An array representing the coordinates of the original point [x, y].</param>
        /// <param name="q">An array representing the coordinates of the reference point [x, y].</param>
        /// <returns>An array representing the coordinates of the symmetric point [x', y'].</returns>
        public static int[] SymmetricPoint(int[] p, int[] q)
        {
            int x = q[0] * 2 - p[0];
            int y = q[1] * 2 - p[1];
            return new int[] { x, y };
        }


    }
}