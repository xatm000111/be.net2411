using System;

class Program
{
    static void Main()
    {
        // Nhập mảng số nguyên
        Console.WriteLine("Nhập số lượng phần tử của mảng:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phần tử [{i}]: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        // Sắp xếp mảng bằng thuật toán sắp xếp nổi bọt
        BubbleSort(array);

        Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Nhập số cần tìm kiếm
        Console.WriteLine("Nhập số cần tìm kiếm trong mảng:");
        int target = int.Parse(Console.ReadLine());

        // Tìm kiếm nhị phân
        int position = BinarySearch(array, target);

        if (position != -1)
        {
            Console.WriteLine($"Số {target} được tìm thấy tại vị trí {position} (chỉ số bắt đầu từ 0).");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy số {target} trong mảng.");
        }
    }

    // Hàm sắp xếp nổi bọt
    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Đổi chỗ hai phần tử
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    // Hàm tìm kiếm nhị phân
    static int BinarySearch(int[] array, int target)
    {
        int left = 0, right = array.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Kiểm tra nếu phần tử giữa là số cần tìm
            if (array[mid] == target)
                return mid;

            // Nếu target lớn hơn, bỏ qua nửa bên trái
            if (array[mid] < target)
                left = mid + 1;
            else
                // Nếu target nhỏ hơn, bỏ qua nửa bên phải
                right = mid - 1;
        }

        // Trả về -1 nếu không tìm thấy
        return -1;
    }
}

