


using System.Collections.Generic;

namespace AspNetCoreContentLocalization.Data.Entities
{
    public class LocalizationSet : BaseEntities
    {
        public virtual ICollection<Localization> Localizations { get; set; }

    }
}