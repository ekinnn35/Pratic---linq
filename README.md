# LINQ Pratik - Rastgele Sayılar Üzerinde Sorgular

Bu proje, **C# ve LINQ** kullanarak **rastgele oluşturulan 10 sayıdan oluşan bir liste** üzerinde çeşitli sorgular çalıştırmaktadır.

## 🚀 Proje İçeriği
Bu projede aşağıdaki LINQ işlemleri uygulanmıştır:

1. **Çift olan sayıları bulma**
2. **Tek olan sayıları bulma**
3. **Negatif sayıları listeleme**
4. **Pozitif sayıları listeleme**
5. **15'ten büyük ve 22'den küçük sayıları bulma**
6. **Listedeki her bir sayının karesini hesaplama**

## 🛠 Kullanılan Teknolojiler
- **C# (.NET Core / .NET 6+)**
- **LINQ (Language Integrated Query)**
- **Visual Studio**

## 📜 Kod Örneği
```csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Random random = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            numbers.Add(random.Next(-50, 50)); // -50 ile 50 arasında rastgele sayılar
        }

        Console.WriteLine("Orijinal Liste: " + string.Join(", ", numbers));
        Console.WriteLine("Çift Sayılar: " + string.Join(", ", numbers.Where(x => x % 2 == 0)));
        Console.WriteLine("Tek Sayılar: " + string.Join(", ", numbers.Where(x => x % 2 != 0)));
        Console.WriteLine("Negatif Sayılar: " + string.Join(", ", numbers.Where(x => x < 0)));
        Console.WriteLine("Pozitif Sayılar: " + string.Join(", ", numbers.Where(x => x > 0)));
        Console.WriteLine("15'ten Büyük ve 22'den Küçük Sayılar: " + string.Join(", ", numbers.Where(x => x > 15 && x < 22)));
        Console.WriteLine("Her Sayının Karesi: " + string.Join(", ", numbers.Select(x => x * x)));
    }
}
```

## 🔧 Kurulum ve Çalıştırma
1. **Proje klasörüne gidin**
2. **Visual Studio'yu açın ve bu dosyayı .NET Console App olarak çalıştırın**
3. **F5 tuşuna basarak veya `dotnet run` komutunu kullanarak projeyi çalıştırın**

## 📌 Çıktı Örneği
```
Orijinal Liste: -10, 7, 23, -45, 18, 21, -8, 15, 22, 30
Çift Sayılar: -10, 18, -8, 22, 30
Tek Sayılar: 7, 23, -45, 21, 15
Negatif Sayılar: -10, -45, -8
Pozitif Sayılar: 7, 23, 18, 21, 15, 22, 30
15'ten Büyük ve 22'den Küçük Sayılar: 18, 21
Her Sayının Karesi: 100, 49, 529, 2025, 324, 441, 64, 225, 484, 900
```


