


using System.Collections.Generic;
using AspNetCoreContentLocalization.Data.Entities;
using AspNetCoreContentLocalization.Data.Repositories.Abstractions;

namespace AspNetCoreContentLocalization.Data.Repositories.Defaults
{
  public class LocalizationRepository : ILocalizationRepository
  {
    private Storage storage;

    public LocalizationRepository(Storage storage)
    {
      this.storage = storage;
    }

    public void Create(Localization localization)
    {
      this.storage.Localizations.Add(localization);
    }

    public void Delete(IEnumerable<Localization> localizations)
    {
      this.storage.Localizations.RemoveRange(localizations);
    }
  }
}