using System;
using System.Globalization;
using System.Linq;
using AspNetCoreContentLocalization.Data;
using AspNetCoreContentLocalization.Data.Repositories.Abstractions;
using AspNetCoreContentLocalization.ViewModels.Librarys;
using AspNetCoreContentLocalization.ViewModels.Shared;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreContentLocalization.Controllers
{
    public class LibrarysController : LocalizableController
    {
        private Storage storage;
        private ILibraryRepository libraryRepository;
        private ILocalizedLibraryRepository localizedLibraryRepository;

        public LibrarysController(Storage storage, ILibraryRepository libraryRepository, ILocalizedLibraryRepository localizedLibraryRepository)
        {
            this.storage = storage;
            this.libraryRepository = libraryRepository;
            this.localizedLibraryRepository = localizedLibraryRepository;
        }

        public IActionResult Index()
        {
            return this.View(
              localizedLibraryRepository.GetAll(CultureInfo.CurrentUICulture.TwoLetterISOLanguageName)
                .Select(b => new Library() { Id = b.Id, Name = b.Name })
            );
        }

        [HttpGet]
        [ImportModelStateFromTempData]
        public IActionResult AddOrEdit(int? id)
        {
            AddOrEdit addOrEdit = new AddOrEdit();

            if (id == null)
            {
                addOrEdit.NameLocalizations = this.CreateEmptyLocalizations();
            }

            else
            {
                Data.Entities.Library library = this.libraryRepository.GetById((int)id);

                addOrEdit.NameLocalizations = this.CreateLocalizationsFor(library.Name);
            }

            return this.View(addOrEdit);
        }

        [HttpPost]
        [ExportModelStateToTempData]
        public IActionResult AddOrEdit(AddOrEdit addOrEdit)
        {
            if (!this.ModelState.IsValid)
                return this.RedirectToAction("AddOrEdit");

            Data.Entities.Library library = addOrEdit.Id == null ? new Data.Entities.Library() : this.libraryRepository.GetById((int)addOrEdit.Id);

            this.CreateOrUpdateLocalizationsFor(library);

            if (addOrEdit.Id == null)
                this.libraryRepository.Create(library);

            else this.libraryRepository.Update(library);

            this.storage.SaveChanges();
            return this.RedirectToAction("Index");
        }
    }
}