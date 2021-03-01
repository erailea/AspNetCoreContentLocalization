


using System.Collections.Generic;
using System.Linq;
using AspNetCoreContentLocalization.Data.Entities;
using AspNetCoreContentLocalization.Data.Repositories.Abstractions;

namespace AspNetCoreContentLocalization.Data.Repositories.Defaults
{
  public class CultureRepository : ICultureRepository
  {
    private Storage storage;

    public CultureRepository(Storage storage)
    {
      this.storage = storage;
    }

    public IEnumerable<Culture> GetAll()
    {
      return this.storage.Cultures.OrderBy(c => c.Name).ToList();
    }
  }
}