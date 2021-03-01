


namespace AspNetCoreContentLocalization.ViewModels.Shared
{
  public class Book : ViewModelBase
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
  }
}