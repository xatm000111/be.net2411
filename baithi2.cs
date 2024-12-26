using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Nhập mảng số nguyên từ người dùng
        Console.WriteLine("Nhập các phần tử của mảng (cách nhau bởi dấu cách):");
        string input = Console.ReadLine();
        int[] arr = Array.ConvertAll(input.Split(' '), int.Parse);

        // Nhập giá trị k
        Console.Write("Nhập giá trị k: ");
        int k = int.Parse(Console.ReadLine());

        // Tìm và in ra các cặp có tổng bằng k
        FindPairsWithSum(arr, k);
    }

    static void FindPairsWithSum(int[] arr, int k)
    {
        HashSet<int> seen = new HashSet<int>();
        HashSet<string> printedPairs = new HashSet<string>();

        Console.WriteLine("Các cặp có tổng bằng " + k + ":");
        foreach (int num in arr)
        {
            int complement = k - num;
            if (seen.Contains(complement))
            {
                string pair = complement < num ? $"{complement} {num}" : $"{num} {complement}";
                if (!printedPairs.Contains(pair))
                {
                    Console.WriteLine($"{complement}, {num}");
                    printedPairs.Add(pair);
                }
            }
            seen.Add(num);
        }
    }
}
