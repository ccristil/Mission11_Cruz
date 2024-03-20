namespace Mission11_Cruz.Models;

public interface IBookRepository
{
    IQueryable<Book> Books { get; }
}