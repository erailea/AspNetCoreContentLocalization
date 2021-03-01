using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AspNetCoreContentLocalization.ViewModels.Shared;

namespace AspNetCoreContentLocalization.ViewModels.Librarys
{
    public class AddOrEdit : ViewModelBase
    {
        public int? Id { get; set; }

        [Localizable]
        [Display(Name = "Name")]
        [Required]
        [StringLength(64)]
        public string Name { get; set; }
        public IEnumerable<Localization> NameLocalizations { get; set; }

    }
}
