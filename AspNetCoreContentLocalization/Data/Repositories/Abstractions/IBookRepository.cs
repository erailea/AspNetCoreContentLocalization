


using AspNetCoreContentLocalization.Data.Entities;

namespace AspNetCoreContentLocalization.Data.Repositories.Abstractions
{
  public interface IBookRepository
  {
    Book GetById(int id);
    void Create(Book book);
    void Update(Book book);
  }
}