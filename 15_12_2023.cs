using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Task 1
        int[][] matrix = new int[3][];
        matrix[0] = new int[] { 1, 2, 3 };
        matrix[1] = new int[] { 4, 5, 6 };
        matrix[2] = new int[] { 7, 8, 9 };

        FillRandom(matrix);
        PrintMatrix(matrix);

        ShiftRowsUp(matrix, 1);
        PrintMatrix(matrix);

        ShiftRowsDown(matrix, 1);
        PrintMatrix(matrix);

        int[] newRow = { 10, 11, 12 };
        AddRow(ref matrix, newRow);
        PrintMatrix(matrix);

        RemoveRow(ref matrix, 1);
        PrintMatrix(matrix);

        // Task 3
        int max, min;
        FindMaxMin(matrix, out max, out min);
        Console.WriteLine($"Maximum value: {max}, Minimum value: {min}");

        // Task 4
        int[,,] threeDimensionalArray = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
        CalculateSumOfSubarrays(threeDimensionalArray);

        string inputString = "I don’t know whether to delete this or rewrite it";
        char targetChar = 'e';

        // Task 1
        ProcessString(ref inputString, targetChar);
        Console.WriteLine(inputString);

        // Task 2
        char[] charsToRemove = { 't', 'h' };
        RemoveCharsFromText(ref inputString, charsToRemove);
        Console.WriteLine(inputString);

        // Task 3
        DisplayLetterStatistics(inputString);

        // Task 4 Це завдання я зрозумів не докінця тому зробив якось ось так
        Console.WriteLine("Enter your C# code (include keywords like 'int', 'if', 'for', etc.):");
        string cSharpCode = Console.ReadLine();
        FindAndDisplayKeywords(cSharpCode);
    }

    static void FillRandom(int[][] matrix)
    {
        Random random = new Random();
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = new int[matrix.Length];
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = random.Next(1, 100);
            }
        }
    }

    static void PrintMatrix(int[][] matrix)
    {
        foreach (var row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
        Console.WriteLine();
    }

    static void ShiftRowsUp(int[][] matrix, int shiftCount)
    {
        for (int k = 0; k < shiftCount; k++)
        {
            int[] temp = matrix[0];
            for (int i = 0; i < matrix.Length - 1; i++)
            {
                matrix[i] = matrix[i + 1];
            }
            matrix[matrix.Length - 1] = temp;
        }
    }

    static void ShiftRowsDown(int[][] matrix, int shiftCount)
    {
        for (int k = 0; k < shiftCount; k++)
        {
            int[] temp = matrix[matrix.Length - 1];
            for (int i = matrix.Length - 1; i > 0; i--)
            {
                matrix[i] = matrix[i - 1];
            }
            matrix[0] = temp;
        }
    }

    static void AddRow(ref int[][] matrix, int[] newRow)
    {
        Array.Resize(ref matrix, matrix.Length + 1);
        matrix[matrix.Length - 1] = newRow;
    }

    static void RemoveRow(ref int[][] matrix, int index)
    {
        matrix = matrix.Where((row, i) => i != index).ToArray();
    }

    static void FindMaxMin(int[][] matrix, out int max, out int min)
    {
        max = matrix.SelectMany(row => row).Max();
        min = matrix.SelectMany(row => row).Min();
    }

    static void CalculateSumOfSubarrays(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    sum += array[i, j, k];
                }
            }
            Console.WriteLine($"Sum of elements in subarray {i + 1}: {sum}");
        }
    }

    static void ProcessString(ref string input, char targetChar)
    {
        int lastIndexOfChar = input.LastIndexOf(targetChar);
        if (lastIndexOfChar != -1)
        {
            input = input.Substring(0, lastIndexOfChar + 1).ToUpper();
        }
    }

    static void RemoveCharsFromText(ref string input, params char[] charsToRemove)
    {
        foreach (char charToRemove in charsToRemove)
        {
            input = input.Replace(charToRemove.ToString(), string.Empty);
        }
    }

    static void DisplayLetterStatistics(string text)
    {
        var letterStatistics = text
            .Where(char.IsLetter)
            .GroupBy(char.ToUpper)
            .OrderBy(group => group.Key);

        foreach (var group in letterStatistics)
        {
            Console.WriteLine($"{group.Key} [{group.Count()}] {new string('*', group.Count())}");
        }
    }

    static void FindAndDisplayKeywords(string cSharpCode)
    {
        string[] keywords = { "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null", "object", "operator", "out", "override", "params", "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "void", "volatile", "while" };

        var keywordCounts = cSharpCode.Split(new[] { ' ', '\n', '\r', '\t', '{', '}', '(', ')', ';', '\'', '\"' }, StringSplitOptions.RemoveEmptyEntries)
            .
      
      
      
      Where(word => keywords.Contains(word))
            .GroupBy(word => word)
            .Select(group => new { Keyword = group.Key, Count = group.Count() })
            .OrderByDescending(x => x.Count);

        Console.WriteLine("Keyword counts:");
        foreach (var keywordCount in keywordCounts)
        {
            Console.WriteLine($"{keywordCount.Keyword}: {keywordCount.Count}");
        }
    }
}
