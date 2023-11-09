namespace VirtualBookingSystem;

internal static class Program
{
    public static void Main()
    {
        Ebook bok = new Ebook("Boken", "Alexander", "0140280197", 2.6, "https://bok.com");
        bok.PrintInfo();
    }
}