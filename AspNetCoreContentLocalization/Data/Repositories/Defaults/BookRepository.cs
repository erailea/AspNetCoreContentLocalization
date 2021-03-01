


using System.Linq;
using AspNetCoreContentLocalization.Data.Entities;
using AspNetCoreContentLocalization.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreContentLocalization.Data.Repositories.Defaults
{
  public class BookRepository : IBookRepository
  {
    private Storage storage;

    public BookRepository(Storage storage)
    {
      this.storage = storage;
    }

    public Book GetById(int id)
    {
      return this.storage.Books
        .Include(b => b.Name).ThenInclude(ls => ls.Localizations)
        .Include(b => b.Description).ThenInclude(ls => ls.Localizations)
        .Include(b => b.Author).ThenInclude(ls => ls.Localizations)
        .FirstOrDefault(b => b.Id == id);
    }

    public void Create(Book book)
    {
      this.storage.Books.Add(book);
    }

    public void Update(Book book)
    {
    }
    }
    public class LibraryRepository : ILibraryRepository
    {
        private Storage storage;

        public LibraryRepository(Storage storage)
        {
            this.storage = storage;
        }

        public Library GetById(int id)
        {
            return this.storage.Librarys
              .Include(b => b.Name).ThenInclude(ls => ls.Localizations)
              .FirstOrDefault(b => b.Id == id);
        }

        public void Create(Library book)
        {
            this.storage.Librarys.Add(book);
        }

        public void Update(Library book)
        {
        }
    }
}