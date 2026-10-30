namespace LuxeLayersLK.Web.Models
{
    public sealed class CollectionPageViewModel
    {
        public string Title { get; init; } = string.Empty;

        public string Subtitle { get; init; } = string.Empty;

        public string HeroImage { get; init; } = string.Empty;

        public string ParentCategory { get; init; } = string.Empty;

        public List<CollectionProductViewModel> Products { get; init; } = new();
    }
}