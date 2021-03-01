


using AspNetCoreContentLocalization.Data.Entities;

namespace AspNetCoreContentLocalization.Data.Repositories.Abstractions
{
  public interface ILocalizationSetRepository
  {
    LocalizationSet GetById(int id);
    void Create(LocalizationSet localizationSet);
  }
}