


using System.Linq;
using AspNetCoreContentLocalization.Data.Entities;
using AspNetCoreContentLocalization.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreContentLocalization.Data.Repositories.Defaults
{
  public class LocalizationSetRepository : ILocalizationSetRepository
  {
    private Storage storage;

    public LocalizationSetRepository(Storage storage)
    {
      this.storage = storage;
    }

    public LocalizationSet GetById(int id)
    {
      return this.storage.LocalizationSets
        .Include(ls => ls.Localizations)
        .FirstOrDefault(ls => ls.Id == id);
    }

    public void Create(LocalizationSet localizationSet)
    {
      this.storage.LocalizationSets.Add(localizationSet);
    }
  }
}