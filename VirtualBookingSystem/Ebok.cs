namespace VirtualBookingSystem
{
    public class Ebok:Bok
    {
        double FileSize { get; set };
        string DownloadUrl { get; set };

        public Ebok(string title,string author,string isbn, double fileSize, string downloadUrl) : base(title, author, isbn)
        {
            FileSize = fileSize;
            DownloadUrl = downloadUrl;
        }

        public virtual override void printInfo()
        {
            Console.WriteLine($"Title:{Title}\nAuthor:{Author}\nISBN{ISBN}\nFileSize:{FileSize}\nDownloadUrl:{DownloadUrl}");
        }
    }
}