Console.WriteLine("Lütfen bir sayı giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());

// Sayının 10'dan büyük, küçük veya eşit olduğu durumu kontrol eden kontrol yapısı

if (sayi > 10)
{
    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
}
else if (sayi < 10)
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
}
else
{
    Console.WriteLine("Girilen sayı 10'a eşittir.");
}

// Girilen sayının çift veya tek olduğunu kontrol eden kontrol yapısı

if(sayi % 2 == 0)
{
    Console.WriteLine("Girilen sayı çifttir.");
}
else
{
    Console.WriteLine("Girilen sayı tektir.");
}
