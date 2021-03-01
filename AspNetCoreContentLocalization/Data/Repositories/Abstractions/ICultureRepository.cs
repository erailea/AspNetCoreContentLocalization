


using System.Collections.Generic;
using AspNetCoreContentLocalization.Data.Entities;

namespace AspNetCoreContentLocalization.Data.Repositories.Abstractions
{
  public interface ICultureRepository
  {
    IEnumerable<Culture> GetAll();
  }
}