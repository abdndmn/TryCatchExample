try
{
    Console.WriteLine("Lutfen bir sayı giriniz:");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Girdiğiniz sayının karesi: {i * i}");
}
catch(Exception ex)
{
    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
}
