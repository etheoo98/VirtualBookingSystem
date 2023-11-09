namespace VirtualBookingSystem;

public class Ebook : Book
{
    public double FileSize { get; set; }
    public string DownloadUrl { get; set; }

    public Ebook(string title,string author,string isbn, double fileSize, string downloadUrl) : base(title, author, isbn)
    {
        FileSize = fileSize;
        DownloadUrl = downloadUrl;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Title:{Title}\nAuthor:{Author}\nISBN:{ISBN}\nFileSize:{FileSize}\nDownloadUrl:{DownloadUrl}");
    }
}