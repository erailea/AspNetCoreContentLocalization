


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreContentLocalization.Data.Entities
{
    public class Book : BaseEntities
    {
        public int NameId { get; set; }
        public int DescriptionId { get; set; }
        public int AuthorId { get; set; }
        public int Year { get; set; }

        public virtual LocalizationSet Name { get; set; }
        public virtual LocalizationSet Description { get; set; }
        public virtual LocalizationSet Author { get; set; }
    }
    public class Library : BaseEntities
    {
        public int NameId { get; set; }

        public virtual LocalizationSet Name { get; set; }
    }


    public abstract class BaseEntities
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}