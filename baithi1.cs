using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Nhập mảng số nguyên từ người dùng
        Console.WriteLine("Nhập các số nguyên, cách nhau bởi dấu cách:");
        string input = Console.ReadLine();

        // Chuyển chuỗi nhập vào thành mảng số nguyên
        string[] inputArray = input.Split(' ');
        int[] numbers = Array.ConvertAll(inputArray, int.Parse);

        // Sử dụng Dictionary để đếm số lần xuất hiện của mỗi phần tử
        Dictionary<int, int> frequencyDict = new Dictionary<int, int>();

        foreach (int num in numbers)
        {
            if (frequencyDict.ContainsKey(num))
            {
                // Nếu phần tử đã tồn tại trong từ điển, tăng giá trị đếm lên
                frequencyDict[num]++;
            }
            else
            {
                // Nếu phần tử chưa tồn tại, thêm vào từ điển với giá trị đếm là 1
                frequencyDict[num] = 1;
            }
        }

        // In ra kết quả
        Console.WriteLine("Kết quả: ");
        foreach (var pair in frequencyDict)
        {
            Console.WriteLine($"Phần tử {pair.Key}: {pair.Value} lần");
        }
    }
}

