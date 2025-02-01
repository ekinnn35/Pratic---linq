using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Rastgele 10 sayıdan oluşan bir liste oluştur
        Random random = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            numbers.Add(random.Next(-50, 50)); // -50 ile 50 arasında rastgele sayılar
        }

        // Orijinal listeyi ekrana yazdır
        Console.WriteLine("Orijinal Liste:");
        Console.WriteLine(string.Join(", ", numbers));

        // Çift sayılar
        var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
        Console.WriteLine("\nÇift Sayılar:");
        Console.WriteLine(string.Join(", ", evenNumbers));

        // Tek sayılar
        var oddNumbers = numbers.Where(x => x % 2 != 0).ToList();
        Console.WriteLine("\nTek Sayılar:");
        Console.WriteLine(string.Join(", ", oddNumbers));

        // Negatif sayılar
        var negativeNumbers = numbers.Where(x => x < 0).ToList();
        Console.WriteLine("\nNegatif Sayılar:");
        Console.WriteLine(string.Join(", ", negativeNumbers));

        // Pozitif sayılar
        var positiveNumbers = numbers.Where(x => x > 0).ToList();
        Console.WriteLine("\nPozitif Sayılar:");
        Console.WriteLine(string.Join(", ", positiveNumbers));

        // 15'ten büyük ve 22'den küçük sayılar
        var rangeNumbers = numbers.Where(x => x > 15 && x < 22).ToList();
        Console.WriteLine("\n15'ten Büyük ve 22'den Küçük Sayılar:");
        Console.WriteLine(string.Join(", ", rangeNumbers));

        // Listedeki her bir sayının karesi
        var squaredNumbers = numbers.Select(x => x * x).ToList();
        Console.WriteLine("\nHer Sayının Karesi:");
        Console.WriteLine(string.Join(", ", squaredNumbers));
    }
}
