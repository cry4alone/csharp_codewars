using System;
using System.Diagnostics.SymbolStore;

namespace CodewarsTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Codewars Tasks ===");

            // Call the Greet method
            Console.WriteLine("Greet Method:");
            Console.WriteLine(CodewarsTasks.Greet("Alice", "alice")); 
            Console.WriteLine(CodewarsTasks.Greet("Bob", "alice"));   

            // Call the DigitalRoot method
            Console.WriteLine("\nDigitalRoot Method:");
            Console.WriteLine(CodewarsTasks.DigitalRoot(987));        
            Console.WriteLine(CodewarsTasks.DigitalRoot(12345));      

            // Call the FinalGrade method
            Console.WriteLine("\nFinalGrade Method:");
            Console.WriteLine(CodewarsTasks.FinalGrade(95, 11));      
            Console.WriteLine(CodewarsTasks.FinalGrade(80, 5));       
            Console.WriteLine(CodewarsTasks.FinalGrade(60, 2));       
            Console.WriteLine(CodewarsTasks.FinalGrade(40, 0));       

            // Call the Include method
            Console.WriteLine("\nInclude Method:");
            Console.WriteLine(CodewarsTasks.Include(new int[] { 1, 2, 3 }, 2)); 
            Console.WriteLine(CodewarsTasks.Include(new int[] { 1, 2, 3 }, 5)); 

            // Call the RowSumOddNumbers method
            Console.WriteLine("\nRowSumOddNumbers Method:");
            Console.WriteLine(CodewarsTasks.RowSumOddNumbers(1));     
            Console.WriteLine(CodewarsTasks.RowSumOddNumbers(2));     
            Console.WriteLine(CodewarsTasks.RowSumOddNumbers(3));

            Console.WriteLine("\nMyLanguages Method:");
            var resMyLang = CodewarsTasks.MyLanguages(new Dictionary<string, int>
            {
                { "Java", 55 },
                { "Python", 80 },
                { "C#", 75 },
                { "JavaScript", 60 },
                { "Ruby", 45 }
            });
            foreach(var lang in resMyLang)
            {
                Console.WriteLine(lang);
            }

            Console.WriteLine("\nSymmetricPoint Method:");
            int[] p = { 1, 2 };
            int[] q = { 3, 4 };
            int[] symmetricPoint = CodewarsTasks.SymmetricPoint(p, q);
            Console.WriteLine($"{symmetricPoint[0]}, {symmetricPoint[1]}");
            Console.WriteLine("=== End of Tasks ===");
        }
    }
}