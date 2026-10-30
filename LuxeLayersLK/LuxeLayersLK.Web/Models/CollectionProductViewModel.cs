namespace LuxeLayersLK.Web.Models
{
    public sealed class CollectionProductViewModel
    {
        public int Id { get; init; }

        public string Name { get; init; } = string.Empty;

        public decimal Price { get; init; }

        public string PrimaryImage { get; init; } = string.Empty;

        public string HoverImage { get; init; } = string.Empty;

        public string Badge { get; init; } = string.Empty;

        public string Material { get; init; } = string.Empty;

        public string StoneType { get; init; } = string.Empty;

        public string StyleLength { get; init; } = string.Empty;

        public string SizeFit { get; init; } = string.Empty;

        public string ChainOption { get; init; } = string.Empty;

        public string Gauge { get; init; } = string.Empty;

        public string Sizes { get; init; } = string.Empty;

        public int FeaturedOrder { get; init; }

        public int NewestOrder { get; init; }
    }
}