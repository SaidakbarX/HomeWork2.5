using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._5._4_task;

public class BookCollection
{
    private List<Book>_books;
    public BookCollection()
    {
        _books = new List<Book>();
    }
    public void AddBooks (Book book)
    {
        if (book is null)
        {
            _books.Add(book);
        }
    }
    public List<Book> GetBooksByAuthor(string author)
    {
        List<Book> result = new List<Book>();
        foreach (Book book in _books)
        {
            if(string.Compare(book.Author, author, true) == 0)
            {
                result.Add(book);
            }
        }
        return result;
    }
        


}
