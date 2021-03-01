


using Microsoft.AspNetCore.Mvc.Filters;

namespace AspNetCoreContentLocalization
{
  public abstract class ModelStateTempDataTransferAttribute : ActionFilterAttribute
  {
    protected static readonly string Key = typeof(ModelStateTempDataTransferAttribute).FullName;
  }
}