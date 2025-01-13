using ConsoleApp15;

class Program
{
    static void Main(string[] args)
    {
        // Öğrenci nesneleri oluşturuluyor
        Person ogrenci1 = new Person("Ali", "Yılmaz", new DateTime(2005, 5, 15));
        Person ogrenci2 = new Person("Ayşe", "Kara", new DateTime(2006, 8, 22));

        // Öğretmen nesneleri oluşturuluyor
        Person ogretmen1 = new Person("Mehmet", "Demir", new DateTime(1980, 3, 12));
        Person ogretmen2 = new Person("Zeynep", "Aydın", new DateTime(1985, 11, 5));

        // Öğrenci ve öğretmen bilgileri yazdırılıyor
        Console.WriteLine("Öğrenciler:");
        ogrenci1.BilgileriYazdir();
        ogrenci2.BilgileriYazdir();

        Console.WriteLine("\nÖğretmenler:");
        ogretmen1.BilgileriYazdir();
        ogretmen2.BilgileriYazdir();
    }
}