


namespace AspNetCoreContentLocalization.Data.Entities
{
    public class Localization
    {
        public int LocalizationSetId { get; set; }
        public int CultureId { get; set; }
        public string Value { get; set; }

        public virtual LocalizationSet LocalizationSet { get; set; }
        public virtual Culture Culture { get; set; }
    }
}