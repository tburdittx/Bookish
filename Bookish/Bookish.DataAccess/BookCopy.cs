namespace Bookish.DataAccess
{
    public class BookCopy
    {
        public int BookCopyId { get; set; }
        public string CustomerId { get; set; }
        public string BookId { get; set; }
        public string ReturnDate { get; set; }
    }
}
