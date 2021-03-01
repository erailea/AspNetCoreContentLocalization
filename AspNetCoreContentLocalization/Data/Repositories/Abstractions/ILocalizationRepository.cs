


using System.Collections.Generic;
using AspNetCoreContentLocalization.Data.Entities;

namespace AspNetCoreContentLocalization.Data.Repositories.Abstractions
{
  public interface ILocalizationRepository
  {
    void Create(Localization localization);
    void Delete(IEnumerable<Localization> localizations);
  }
}