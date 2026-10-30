using LuxeLayersLK.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuxeLayersLK.Web.Controllers
{
    [Route("women")]
    public sealed class WomenController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            var model = new CollectionPageViewModel
            {
                Title = "Women's Jewellery",

                Subtitle =
                    "Discover timeless jewellery designed to celebrate every expression of your personal style.",

                HeroImage = "/assets/images/home/category-women.jpg",

                ParentCategory = "Women",

                Products = new List<CollectionProductViewModel>
        {
            // RINGS
            new()
            {
                Id = 701,
                Name = "Ceylon Sapphire Halo Ring",
                Price = 42000,
                PrimaryImage = "/assets/images/home/stones/sapphire-jewellery.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "Best Seller",
                Material = "silver",
                StoneType = "sapphire",
                FeaturedOrder = 1,
                NewestOrder = 8
            },

            // NECKLACES
            new()
            {
                Id = 702,
                Name = "Aurora Layered Gold Necklace",
                Price = 28500,
                PrimaryImage = "/assets/images/home/category-necklaces.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "New",
                Material = "gold-plated",
                StoneType = "no-stone",
                FeaturedOrder = 2,
                NewestOrder = 1
            },

            // EARRINGS
            new()
            {
                Id = 703,
                Name = "Emerald Dew Drop Earrings",
                Price = 36000,
                PrimaryImage = "/assets/images/home/stones/emerald-jewellery.jpg",
                HoverImage = "/assets/images/home/category-earrings.jpg",
                Badge = "",
                Material = "silver",
                StoneType = "emerald",
                FeaturedOrder = 3,
                NewestOrder = 7
            },

            // ANKLETS
            new()
            {
                Id = 704,
                Name = "Minimalist Gold Chain Anklet",
                Price = 12500,
                PrimaryImage = "/assets/images/home/collection-gold.jpg",
                HoverImage = "/assets/images/home/category-anklets.jpg",
                Badge = "Best Seller",
                Material = "gold-plated",
                StoneType = "no-stone",
                FeaturedOrder = 4,
                NewestOrder = 6
            },

            // BANGLES
            new()
            {
                Id = 705,
                Name = "Diamond Light Open Cuff",
                Price = 68000,
                PrimaryImage = "/assets/images/home/stones/diamond-jewellery.jpg",
                HoverImage = "/assets/images/home/category-bangles.jpg",
                Badge = "Best Seller",
                Material = "silver",
                StoneType = "diamond",
                FeaturedOrder = 5,
                NewestOrder = 5
            },

            // PENDANTS
            new()
            {
                Id = 706,
                Name = "Ruby Flame Gold Pendant",
                Price = 39500,
                PrimaryImage = "/assets/images/home/stones/ruby-jewellery.jpg",
                HoverImage = "/assets/images/home/category-pendants.jpg",
                Badge = "New",
                Material = "gold-plated",
                StoneType = "ruby",
                FeaturedOrder = 6,
                NewestOrder = 2
            },

            // NOSE RINGS
            new()
            {
                Id = 707,
                Name = "Diamond Light Nose Stud",
                Price = 18500,
                PrimaryImage = "/assets/images/home/stones/diamond-jewellery.jpg",
                HoverImage = "/assets/images/home/category-nose-rings.jpg",
                Badge = "New",
                Material = "silver",
                StoneType = "diamond",
                FeaturedOrder = 7,
                NewestOrder = 3
            },

            // RING
            new()
            {
                Id = 708,
                Name = "Rosé Minimal Ring",
                Price = 9800,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "",
                Material = "rose-gold",
                StoneType = "no-stone",
                FeaturedOrder = 8,
                NewestOrder = 11
            },

            // NECKLACE
            new()
            {
                Id = 709,
                Name = "Moonstone Matinee Necklace",
                Price = 26000,
                PrimaryImage = "/assets/images/home/category-necklaces.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "",
                Material = "silver",
                StoneType = "semi-precious",
                FeaturedOrder = 9,
                NewestOrder = 10
            },

            // EARRINGS
            new()
            {
                Id = 710,
                Name = "Golden Pearl Drop Earrings",
                Price = 16800,
                PrimaryImage = "/assets/images/home/collection-gold.jpg",
                HoverImage = "/assets/images/home/category-earrings.jpg",
                Badge = "",
                Material = "gold-plated",
                StoneType = "semi-precious",
                FeaturedOrder = 10,
                NewestOrder = 9
            },

            // ANKLET
            new()
            {
                Id = 711,
                Name = "Rosé Layered Chain Anklet",
                Price = 14500,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-anklets.jpg",
                Badge = "New",
                Material = "rose-gold",
                StoneType = "no-stone",
                FeaturedOrder = 11,
                NewestOrder = 4
            },

            // BANGLE
            new()
            {
                Id = 712,
                Name = "Emerald Orbit Open Cuff",
                Price = 49000,
                PrimaryImage = "/assets/images/home/stones/emerald-jewellery.jpg",
                HoverImage = "/assets/images/home/category-bangles.jpg",
                Badge = "Few Left",
                Material = "silver",
                StoneType = "emerald",
                FeaturedOrder = 12,
                NewestOrder = 13
            },

            // PENDANT
            new()
            {
                Id = 713,
                Name = "Tourmaline Rosé Halo Pendant",
                Price = 27500,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-pendants.jpg",
                Badge = "",
                Material = "rose-gold",
                StoneType = "semi-precious",
                FeaturedOrder = 13,
                NewestOrder = 12
            },

            // NOSE RING
            new()
            {
                Id = 714,
                Name = "Minimalist Gold Nose Hoop",
                Price = 7500,
                PrimaryImage = "/assets/images/home/collection-gold.jpg",
                HoverImage = "/assets/images/home/category-nose-rings.jpg",
                Badge = "Best Seller",
                Material = "gold-plated",
                StoneType = "no-stone",
                FeaturedOrder = 14,
                NewestOrder = 14
            }
        }
            };

            return View(model);
        }
        [HttpGet("rings")]
        public IActionResult Rings()
        {
            var model = new CollectionPageViewModel
            {
                Title = "Women's Rings",

                Subtitle =
                    "Discover handcrafted silver, gold, and rose-gold rings designed to celebrate her personal style.",

                HeroImage = "/assets/images/hero-main.jpg",

                ParentCategory = "Women",

                Products = new List<CollectionProductViewModel>
                {
                    new()
                    {
                        Id = 1,
                        Name = "The Ceylon Sapphire Halo Ring",
                        Price = 45000,
                        PrimaryImage = "/assets/images/home/stones/sapphire-jewellery.jpg",
                        HoverImage = "/assets/images/home/category-rings.jpg",
                        Badge = "Best Seller",
                        Material = "silver",
                        StoneType = "sapphire",
                        Sizes = "5,6,7,8",
                        FeaturedOrder = 1,
                        NewestOrder = 5
                    },

                    new()
                    {
                        Id = 2,
                        Name = "Aurora Gold Signet Ring",
                        Price = 18500,
                        PrimaryImage = "/assets/images/home/collection-gold.jpg",
                        HoverImage = "/assets/images/home/category-women.jpg",
                        Badge = "New",
                        Material = "gold-plated",
                        StoneType = "no-stone",
                        Sizes = "6,7,8,9",
                        FeaturedOrder = 2,
                        NewestOrder = 1
                    },

                    new()
                    {
                        Id = 3,
                        Name = "Rosé Whisper Band",
                        Price = 12500,
                        PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                        HoverImage = "/assets/images/home/category-bracelets.jpg",
                        Badge = "",
                        Material = "rose-gold",
                        StoneType = "no-stone",
                        Sizes = "5,6,7,8,9",
                        FeaturedOrder = 3,
                        NewestOrder = 7
                    },

                    new()
                    {
                        Id = 4,
                        Name = "Emerald Dew Statement Ring",
                        Price = 52000,
                        PrimaryImage = "/assets/images/home/stones/emerald-jewellery.jpg",
                        HoverImage = "/assets/images/home/category-rings.jpg",
                        Badge = "Few Left",
                        Material = "silver",
                        StoneType = "emerald",
                        Sizes = "6,7,8",
                        FeaturedOrder = 4,
                        NewestOrder = 8
                    },

                    new()
                    {
                        Id = 5,
                        Name = "Ruby Crown Gold Ring",
                        Price = 48500,
                        PrimaryImage = "/assets/images/home/stones/ruby-jewellery.jpg",
                        HoverImage = "/assets/images/home/category-women.jpg",
                        Badge = "New",
                        Material = "gold-plated",
                        StoneType = "ruby",
                        Sizes = "5,6,7",
                        FeaturedOrder = 5,
                        NewestOrder = 2
                    },

                    new()
                    {
                        Id = 6,
                        Name = "Diamond Light Solitaire Ring",
                        Price = 68000,
                        PrimaryImage = "/assets/images/home/stones/diamond-jewellery.jpg",
                        HoverImage = "/assets/images/home/category-rings.jpg",
                        Badge = "Best Seller",
                        Material = "silver",
                        StoneType = "diamond",
                        Sizes = "5,6,7,8",
                        FeaturedOrder = 6,
                        NewestOrder = 4
                    },

                    new()
                    {
                        Id = 7,
                        Name = "Moonstone Bloom Ring",
                        Price = 22500,
                        PrimaryImage = "/assets/images/home/category-rings.jpg",
                        HoverImage = "/assets/images/home/category-women.jpg",
                        Badge = "",
                        Material = "silver",
                        StoneType = "semi-precious",
                        Sizes = "6,7,8,9",
                        FeaturedOrder = 7,
                        NewestOrder = 6
                    },

                    new()
                    {
                        Id = 8,
                        Name = "Minimal Sterling Silver Stack Ring",
                        Price = 8900,
                        PrimaryImage = "/assets/images/home/category-rings.jpg",
                        HoverImage = "/assets/images/home/brand-story.jpg",
                        Badge = "New",
                        Material = "silver",
                        StoneType = "no-stone",
                        Sizes = "5,6,7,8,9",
                        FeaturedOrder = 8,
                        NewestOrder = 3
                    },

                    new()
                    {
                        Id = 9,
                        Name = "Tourmaline Petal Ring",
                        Price = 27500,
                        PrimaryImage = "/assets/images/home/category-rings.jpg",
                        HoverImage = "/assets/images/home/category-women.jpg",
                        Badge = "",
                        Material = "rose-gold",
                        StoneType = "semi-precious",
                        Sizes = "5,6,7",
                        FeaturedOrder = 9,
                        NewestOrder = 10
                    },

                    new()
                    {
                        Id = 10,
                        Name = "Sapphire Orbit Silver Ring",
                        Price = 32000,
                        PrimaryImage = "/assets/images/home/stones/sapphire-jewellery.jpg",
                        HoverImage = "/assets/images/home/category-rings.jpg",
                        Badge = "Few Left",
                        Material = "silver",
                        StoneType = "sapphire",
                        Sizes = "7,8,9",
                        FeaturedOrder = 10,
                        NewestOrder = 11
                    },

                    new()
                    {
                        Id = 11,
                        Name = "Golden Promise Band",
                        Price = 24000,
                        PrimaryImage = "/assets/images/home/collection-gold.jpg",
                        HoverImage = "/assets/images/home/category-women.jpg",
                        Badge = "",
                        Material = "gold-plated",
                        StoneType = "no-stone",
                        Sizes = "5,6,7,8,9",
                        FeaturedOrder = 11,
                        NewestOrder = 9
                    },

                    new()
                    {
                        Id = 12,
                        Name = "Rose Halo Semi-Precious Ring",
                        Price = 15000,
                        PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                        HoverImage = "/assets/images/home/category-rings.jpg",
                        Badge = "New",
                        Material = "rose-gold",
                        StoneType = "semi-precious",
                        Sizes = "5,6,7,8",
                        FeaturedOrder = 12,
                        NewestOrder = 12
                    }
                }
            };

            return View(model);
        }

        [HttpGet("necklaces")]
        public IActionResult Necklaces()
        {
            var model = new CollectionPageViewModel
            {
                Title = "Women's Necklaces",

                Subtitle =
                    "Elevate your everyday look with handcrafted chains, pendants, and statement pieces.",

                HeroImage = "/assets/images/home/category-necklaces.jpg",

                ParentCategory = "Women",

                Products = new List<CollectionProductViewModel>
        {
            new()
            {
                Id = 101,
                Name = "The Ceylon Sapphire Teardrop Pendant",
                Price = 52000,
                PrimaryImage = "/assets/images/home/stones/sapphire-jewellery.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "Best Seller",
                Material = "silver",
                StoneType = "sapphire",
                StyleLength = "pendant",
                FeaturedOrder = 1,
                NewestOrder = 5
            },

            new()
            {
                Id = 102,
                Name = "Aurora Layered Gold Necklace",
                Price = 28500,
                PrimaryImage = "/assets/images/home/category-necklaces.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "New",
                Material = "gold-plated",
                StoneType = "no-stone",
                StyleLength = "layered",
                FeaturedOrder = 2,
                NewestOrder = 1
            },

            new()
            {
                Id = 103,
                Name = "Rosé Whisper Choker",
                Price = 14500,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "",
                Material = "rose-gold",
                StoneType = "no-stone",
                StyleLength = "choker",
                FeaturedOrder = 3,
                NewestOrder = 7
            },

            new()
            {
                Id = 104,
                Name = "Emerald Dew Princess Necklace",
                Price = 48000,
                PrimaryImage = "/assets/images/home/stones/emerald-jewellery.jpg",
                HoverImage = "/assets/images/home/category-necklaces.jpg",
                Badge = "Few Left",
                Material = "silver",
                StoneType = "emerald",
                StyleLength = "princess",
                FeaturedOrder = 4,
                NewestOrder = 8
            },

            new()
            {
                Id = 105,
                Name = "Ruby Flame Gold Pendant",
                Price = 42500,
                PrimaryImage = "/assets/images/home/stones/ruby-jewellery.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "New",
                Material = "gold-plated",
                StoneType = "ruby",
                StyleLength = "pendant",
                FeaturedOrder = 5,
                NewestOrder = 2
            },

            new()
            {
                Id = 106,
                Name = "Diamond Light Solitaire Necklace",
                Price = 78000,
                PrimaryImage = "/assets/images/home/stones/diamond-jewellery.jpg",
                HoverImage = "/assets/images/home/category-necklaces.jpg",
                Badge = "Best Seller",
                Material = "silver",
                StoneType = "diamond",
                StyleLength = "princess",
                FeaturedOrder = 6,
                NewestOrder = 4
            },

            new()
            {
                Id = 107,
                Name = "Moonstone Matinee Necklace",
                Price = 26000,
                PrimaryImage = "/assets/images/home/category-necklaces.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "",
                Material = "silver",
                StoneType = "semi-precious",
                StyleLength = "matinee",
                FeaturedOrder = 7,
                NewestOrder = 6
            },

            new()
            {
                Id = 108,
                Name = "Minimal Sterling Silver Chain",
                Price = 9900,
                PrimaryImage = "/assets/images/home/category-necklaces.jpg",
                HoverImage = "/assets/images/home/brand-story.jpg",
                Badge = "New",
                Material = "silver",
                StoneType = "no-stone",
                StyleLength = "princess",
                FeaturedOrder = 8,
                NewestOrder = 3
            },

            new()
            {
                Id = 109,
                Name = "Tourmaline Layered Necklace Set",
                Price = 32000,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "",
                Material = "rose-gold",
                StoneType = "semi-precious",
                StyleLength = "layered",
                FeaturedOrder = 9,
                NewestOrder = 10
            },

            new()
            {
                Id = 110,
                Name = "Sapphire Orbit Choker",
                Price = 29500,
                PrimaryImage = "/assets/images/home/stones/sapphire-jewellery.jpg",
                HoverImage = "/assets/images/home/category-necklaces.jpg",
                Badge = "Few Left",
                Material = "silver",
                StoneType = "sapphire",
                StyleLength = "choker",
                FeaturedOrder = 10,
                NewestOrder = 11
            },

            new()
            {
                Id = 111,
                Name = "Golden Promise Pendant",
                Price = 24000,
                PrimaryImage = "/assets/images/home/collection-gold.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "",
                Material = "gold-plated",
                StoneType = "no-stone",
                StyleLength = "pendant",
                FeaturedOrder = 11,
                NewestOrder = 9
            },

            new()
            {
                Id = 112,
                Name = "Amethyst Bloom Necklace",
                Price = 18000,
                PrimaryImage = "/assets/images/home/category-necklaces.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "New",
                Material = "rose-gold",
                StoneType = "semi-precious",
                StyleLength = "princess",
                FeaturedOrder = 12,
                NewestOrder = 12
            }
        }
            };

            return View(model);
        }

        [HttpGet("anklets")]
        public IActionResult Anklets()
        {
            var model = new CollectionPageViewModel
            {
                Title = "Women's Anklets",

                Subtitle =
                    "Delicate chains and timeless designs crafted for every step.",

                HeroImage = "/assets/images/home/category-anklets.jpg",

                ParentCategory = "Women",

                Products = new List<CollectionProductViewModel>
        {
            new()
            {
                Id = 201,
                Name = "The Minimalist Gold Chain Anklet",
                Price = 12500,
                PrimaryImage = "/assets/images/home/collection-gold.jpg",
                HoverImage = "/assets/images/home/category-anklets.jpg",
                Badge = "Best Seller",
                Material = "gold-plated",
                StoneType = "no-stone",
                StyleLength = "delicate",
                SizeFit = "adjustable",
                FeaturedOrder = 1,
                NewestOrder = 5
            },

            new()
            {
                Id = 202,
                Name = "Silver Moon Delicate Anklet",
                Price = 7900,
                PrimaryImage = "/assets/images/home/category-anklets.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "New",
                Material = "silver",
                StoneType = "no-stone",
                StyleLength = "delicate",
                SizeFit = "standard",
                FeaturedOrder = 2,
                NewestOrder = 1
            },

            new()
            {
                Id = 203,
                Name = "Rosé Layered Chain Anklet",
                Price = 14500,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-anklets.jpg",
                Badge = "",
                Material = "rose-gold",
                StoneType = "no-stone",
                StyleLength = "layered",
                SizeFit = "adjustable",
                FeaturedOrder = 3,
                NewestOrder = 7
            },

            new()
            {
                Id = 204,
                Name = "Sapphire Charm Silver Anklet",
                Price = 22000,
                PrimaryImage = "/assets/images/home/stones/sapphire-jewellery.jpg",
                HoverImage = "/assets/images/home/category-anklets.jpg",
                Badge = "Few Left",
                Material = "silver",
                StoneType = "sapphire",
                StyleLength = "charm",
                SizeFit = "custom",
                FeaturedOrder = 4,
                NewestOrder = 8
            },

            new()
            {
                Id = 205,
                Name = "Golden Star Charm Anklet",
                Price = 13800,
                PrimaryImage = "/assets/images/home/collection-gold.jpg",
                HoverImage = "/assets/images/home/category-anklets.jpg",
                Badge = "New",
                Material = "gold-plated",
                StoneType = "no-stone",
                StyleLength = "charm",
                SizeFit = "adjustable",
                FeaturedOrder = 5,
                NewestOrder = 2
            },

            new()
            {
                Id = 206,
                Name = "Zircon Light Rose-Gold Anklet",
                Price = 18500,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-anklets.jpg",
                Badge = "Best Seller",
                Material = "rose-gold",
                StoneType = "zircon",
                StyleLength = "delicate",
                SizeFit = "standard",
                FeaturedOrder = 6,
                NewestOrder = 4
            },

            new()
            {
                Id = 207,
                Name = "Moonstone Beaded Anklet",
                Price = 16500,
                PrimaryImage = "/assets/images/home/category-anklets.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "",
                Material = "silver",
                StoneType = "semi-precious",
                StyleLength = "beaded",
                SizeFit = "adjustable",
                FeaturedOrder = 7,
                NewestOrder = 6
            },

            new()
            {
                Id = 208,
                Name = "Everyday Sterling Silver Anklet",
                Price = 6900,
                PrimaryImage = "/assets/images/home/category-anklets.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "New",
                Material = "silver",
                StoneType = "no-stone",
                StyleLength = "delicate",
                SizeFit = "standard",
                FeaturedOrder = 8,
                NewestOrder = 3
            },

            new()
            {
                Id = 209,
                Name = "Tourmaline Beaded Anklet",
                Price = 19500,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-anklets.jpg",
                Badge = "",
                Material = "rose-gold",
                StoneType = "semi-precious",
                StyleLength = "beaded",
                SizeFit = "custom",
                FeaturedOrder = 9,
                NewestOrder = 10
            },

            new()
            {
                Id = 210,
                Name = "Sapphire Orbit Layered Anklet",
                Price = 24500,
                PrimaryImage = "/assets/images/home/stones/sapphire-jewellery.jpg",
                HoverImage = "/assets/images/home/category-anklets.jpg",
                Badge = "Few Left",
                Material = "silver",
                StoneType = "sapphire",
                StyleLength = "layered",
                SizeFit = "adjustable",
                FeaturedOrder = 10,
                NewestOrder = 11
            },

            new()
            {
                Id = 211,
                Name = "Golden Pearl Charm Anklet",
                Price = 14900,
                PrimaryImage = "/assets/images/home/collection-gold.jpg",
                HoverImage = "/assets/images/home/category-anklets.jpg",
                Badge = "",
                Material = "gold-plated",
                StoneType = "semi-precious",
                StyleLength = "charm",
                SizeFit = "adjustable",
                FeaturedOrder = 11,
                NewestOrder = 9
            },

            new()
            {
                Id = 212,
                Name = "Rosé Zircon Layered Anklet",
                Price = 17500,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-anklets.jpg",
                Badge = "New",
                Material = "rose-gold",
                StoneType = "zircon",
                StyleLength = "layered",
                SizeFit = "custom",
                FeaturedOrder = 12,
                NewestOrder = 12
            }
        }
            };

            return View(model);
        }

        [HttpGet("earrings")]
        public IActionResult Earrings()
        {
            var model = new CollectionPageViewModel
            {
                Title = "Women's Earrings",

                Subtitle =
                    "From classic studs to statement drops, discover pieces designed to illuminate your face.",

                HeroImage = "/assets/images/home/category-earrings.jpg",

                ParentCategory = "Women",

                Products = new List<CollectionProductViewModel>
        {
            new()
            {
                Id = 301,
                Name = "The Ceylon Sapphire Halo Studs",
                Price = 28500,
                PrimaryImage = "/assets/images/home/stones/sapphire-jewellery.jpg",
                HoverImage = "/assets/images/home/category-earrings.jpg",
                Badge = "Best Seller",
                Material = "silver",
                StoneType = "sapphire",
                StyleLength = "studs",
                FeaturedOrder = 1,
                NewestOrder = 5
            },

            new()
            {
                Id = 302,
                Name = "Aurora Gold Hoop Earrings",
                Price = 14500,
                PrimaryImage = "/assets/images/home/collection-gold.jpg",
                HoverImage = "/assets/images/home/category-earrings.jpg",
                Badge = "New",
                Material = "gold-plated",
                StoneType = "no-stone",
                StyleLength = "hoops",
                FeaturedOrder = 2,
                NewestOrder = 1
            },

            new()
            {
                Id = 303,
                Name = "Rosé Whisper Huggies",
                Price = 9800,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "",
                Material = "rose-gold",
                StoneType = "no-stone",
                StyleLength = "huggies",
                FeaturedOrder = 3,
                NewestOrder = 7
            },

            new()
            {
                Id = 304,
                Name = "Emerald Dew Drop Earrings",
                Price = 36000,
                PrimaryImage = "/assets/images/home/stones/emerald-jewellery.jpg",
                HoverImage = "/assets/images/home/category-earrings.jpg",
                Badge = "Few Left",
                Material = "silver",
                StoneType = "emerald",
                StyleLength = "drop-dangle",
                FeaturedOrder = 4,
                NewestOrder = 8
            },

            new()
            {
                Id = 305,
                Name = "Ruby Flame Gold Studs",
                Price = 32000,
                PrimaryImage = "/assets/images/home/stones/ruby-jewellery.jpg",
                HoverImage = "/assets/images/home/category-earrings.jpg",
                Badge = "New",
                Material = "gold-plated",
                StoneType = "ruby",
                StyleLength = "studs",
                FeaturedOrder = 5,
                NewestOrder = 2
            },

            new()
            {
                Id = 306,
                Name = "Diamond Light Solitaire Earrings",
                Price = 58000,
                PrimaryImage = "/assets/images/home/stones/diamond-jewellery.jpg",
                HoverImage = "/assets/images/home/category-earrings.jpg",
                Badge = "Best Seller",
                Material = "silver",
                StoneType = "diamond",
                StyleLength = "studs",
                FeaturedOrder = 6,
                NewestOrder = 4
            },

            new()
            {
                Id = 307,
                Name = "Moonstone Bloom Drop Earrings",
                Price = 18500,
                PrimaryImage = "/assets/images/home/category-earrings.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "",
                Material = "silver",
                StoneType = "semi-precious",
                StyleLength = "drop-dangle",
                FeaturedOrder = 7,
                NewestOrder = 6
            },

            new()
            {
                Id = 308,
                Name = "Minimal Sterling Silver Huggies",
                Price = 7500,
                PrimaryImage = "/assets/images/home/category-earrings.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "New",
                Material = "silver",
                StoneType = "no-stone",
                StyleLength = "huggies",
                FeaturedOrder = 8,
                NewestOrder = 3
            },

            new()
            {
                Id = 309,
                Name = "Tourmaline Rosé Ear Cuff",
                Price = 17500,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-earrings.jpg",
                Badge = "",
                Material = "rose-gold",
                StoneType = "semi-precious",
                StyleLength = "ear-cuffs",
                FeaturedOrder = 9,
                NewestOrder = 10
            },

            new()
            {
                Id = 310,
                Name = "Sapphire Orbit Hoop Earrings",
                Price = 24500,
                PrimaryImage = "/assets/images/home/stones/sapphire-jewellery.jpg",
                HoverImage = "/assets/images/home/category-earrings.jpg",
                Badge = "Few Left",
                Material = "silver",
                StoneType = "sapphire",
                StyleLength = "hoops",
                FeaturedOrder = 10,
                NewestOrder = 11
            },

            new()
            {
                Id = 311,
                Name = "Golden Pearl Drop Earrings",
                Price = 16800,
                PrimaryImage = "/assets/images/home/collection-gold.jpg",
                HoverImage = "/assets/images/home/category-earrings.jpg",
                Badge = "",
                Material = "gold-plated",
                StoneType = "semi-precious",
                StyleLength = "drop-dangle",
                FeaturedOrder = 11,
                NewestOrder = 9
            },

            new()
            {
                Id = 312,
                Name = "Rosé Minimal Ear Cuffs",
                Price = 11500,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-earrings.jpg",
                Badge = "New",
                Material = "rose-gold",
                StoneType = "no-stone",
                StyleLength = "ear-cuffs",
                FeaturedOrder = 12,
                NewestOrder = 12
            }
        }
            };

            return View(model);
        }
        [HttpGet("bangles")]
        public IActionResult Bangles()
        {
            var model = new CollectionPageViewModel
            {
                Title = "Women's Bangles",

                Subtitle =
                    "From sleek minimalist bands to intricate statement pieces, discover wristwear designed to stack or shine alone.",

                HeroImage = "/assets/images/home/category-bangles.jpg",

                ParentCategory = "Women",

                Products = new List<CollectionProductViewModel>
        {
            new()
            {
                Id = 401,
                Name = "The Classic Gold Cuff",
                Price = 27500,
                PrimaryImage = "/assets/images/home/collection-gold.jpg",
                HoverImage = "/assets/images/home/category-bangles.jpg",
                Badge = "Best Seller",
                Material = "gold-plated",
                StoneType = "no-stone",
                StyleLength = "open-cuff",
                SizeFit = "adjustable",
                FeaturedOrder = 1,
                NewestOrder = 5
            },

            new()
            {
                Id = 402,
                Name = "Minimal Sterling Silver Bangle",
                Price = 12500,
                PrimaryImage = "/assets/images/home/category-bangles.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "New",
                Material = "silver",
                StoneType = "no-stone",
                StyleLength = "solid",
                SizeFit = "medium",
                FeaturedOrder = 2,
                NewestOrder = 1
            },

            new()
            {
                Id = 403,
                Name = "Rosé Whisper Stacking Set",
                Price = 28500,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-bangles.jpg",
                Badge = "",
                Material = "rose-gold",
                StoneType = "no-stone",
                StyleLength = "stacking",
                SizeFit = "medium",
                FeaturedOrder = 3,
                NewestOrder = 7
            },

            new()
            {
                Id = 404,
                Name = "Ceylon Sapphire Stone-Set Bangle",
                Price = 52000,
                PrimaryImage = "/assets/images/home/stones/sapphire-jewellery.jpg",
                HoverImage = "/assets/images/home/category-bangles.jpg",
                Badge = "Few Left",
                Material = "silver",
                StoneType = "sapphire",
                StyleLength = "stone-set",
                SizeFit = "small",
                FeaturedOrder = 4,
                NewestOrder = 8
            },

            new()
            {
                Id = 405,
                Name = "Ruby Flame Gold Bangle",
                Price = 46500,
                PrimaryImage = "/assets/images/home/stones/ruby-jewellery.jpg",
                HoverImage = "/assets/images/home/category-bangles.jpg",
                Badge = "New",
                Material = "gold-plated",
                StoneType = "ruby",
                StyleLength = "stone-set",
                SizeFit = "medium",
                FeaturedOrder = 5,
                NewestOrder = 2
            },

            new()
            {
                Id = 406,
                Name = "Diamond Light Open Cuff",
                Price = 68000,
                PrimaryImage = "/assets/images/home/stones/diamond-jewellery.jpg",
                HoverImage = "/assets/images/home/category-bangles.jpg",
                Badge = "Best Seller",
                Material = "silver",
                StoneType = "diamond",
                StyleLength = "open-cuff",
                SizeFit = "adjustable",
                FeaturedOrder = 6,
                NewestOrder = 4
            },

            new()
            {
                Id = 407,
                Name = "Moonstone Bloom Bangle",
                Price = 26000,
                PrimaryImage = "/assets/images/home/category-bangles.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "",
                Material = "silver",
                StoneType = "semi-precious",
                StyleLength = "stone-set",
                SizeFit = "large",
                FeaturedOrder = 7,
                NewestOrder = 6
            },

            new()
            {
                Id = 408,
                Name = "Everyday Silver Solid Bangle",
                Price = 9800,
                PrimaryImage = "/assets/images/home/category-bangles.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "New",
                Material = "silver",
                StoneType = "no-stone",
                StyleLength = "solid",
                SizeFit = "small",
                FeaturedOrder = 8,
                NewestOrder = 3
            },

            new()
            {
                Id = 409,
                Name = "Tourmaline Rosé Stacking Bangles",
                Price = 34000,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-bangles.jpg",
                Badge = "",
                Material = "rose-gold",
                StoneType = "semi-precious",
                StyleLength = "stacking",
                SizeFit = "medium",
                FeaturedOrder = 9,
                NewestOrder = 10
            },

            new()
            {
                Id = 410,
                Name = "Emerald Orbit Open Cuff",
                Price = 49000,
                PrimaryImage = "/assets/images/home/stones/emerald-jewellery.jpg",
                HoverImage = "/assets/images/home/category-bangles.jpg",
                Badge = "Few Left",
                Material = "silver",
                StoneType = "emerald",
                StyleLength = "open-cuff",
                SizeFit = "adjustable",
                FeaturedOrder = 10,
                NewestOrder = 11
            },

            new()
            {
                Id = 411,
                Name = "Golden Harmony Stacking Set",
                Price = 29500,
                PrimaryImage = "/assets/images/home/collection-gold.jpg",
                HoverImage = "/assets/images/home/category-bangles.jpg",
                Badge = "",
                Material = "gold-plated",
                StoneType = "no-stone",
                StyleLength = "stacking",
                SizeFit = "large",
                FeaturedOrder = 11,
                NewestOrder = 9
            },

            new()
            {
                Id = 412,
                Name = "Rosé Gemstone Solid Bangle",
                Price = 22500,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-bangles.jpg",
                Badge = "New",
                Material = "rose-gold",
                StoneType = "semi-precious",
                StyleLength = "solid",
                SizeFit = "small",
                FeaturedOrder = 12,
                NewestOrder = 12
            }
        }
            };

            return View(model);
        }

        [HttpGet("pendants")]
        public IActionResult Pendants()
        {
            var model = new CollectionPageViewModel
            {
                Title = "Women's Pendants",

                Subtitle =
                    "Discover captivating centerpieces designed to sit close to the heart, perfect for layering or shining alone.",

                HeroImage = "/assets/images/home/category-pendants.jpg",

                ParentCategory = "Women",

                Products = new List<CollectionProductViewModel>
        {
            new()
            {
                Id = 501,
                Name = "The Emerald Cut Sapphire Pendant",
                Price = 48500,
                PrimaryImage = "/assets/images/home/stones/sapphire-jewellery.jpg",
                HoverImage = "/assets/images/home/category-pendants.jpg",
                Badge = "Best Seller",
                Material = "silver",
                StoneType = "sapphire",
                StyleLength = "solitaire",
                ChainOption = "includes-chain",
                FeaturedOrder = 1,
                NewestOrder = 5
            },

            new()
            {
                Id = 502,
                Name = "Golden Initial Letter Pendant",
                Price = 12500,
                PrimaryImage = "/assets/images/home/collection-gold.jpg",
                HoverImage = "/assets/images/home/category-pendants.jpg",
                Badge = "New",
                Material = "gold-plated",
                StoneType = "no-stone",
                StyleLength = "initial-letter",
                ChainOption = "pendant-only",
                FeaturedOrder = 2,
                NewestOrder = 1
            },

            new()
            {
                Id = 503,
                Name = "Rosé Vintage Bloom Pendant",
                Price = 19500,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "",
                Material = "rose-gold",
                StoneType = "semi-precious",
                StyleLength = "vintage",
                ChainOption = "includes-chain",
                FeaturedOrder = 3,
                NewestOrder = 7
            },

            new()
            {
                Id = 504,
                Name = "Emerald Halo Silver Pendant",
                Price = 42000,
                PrimaryImage = "/assets/images/home/stones/emerald-jewellery.jpg",
                HoverImage = "/assets/images/home/category-pendants.jpg",
                Badge = "Few Left",
                Material = "silver",
                StoneType = "emerald",
                StyleLength = "halo",
                ChainOption = "pendant-only",
                FeaturedOrder = 4,
                NewestOrder = 8
            },

            new()
            {
                Id = 505,
                Name = "Ruby Flame Gold Solitaire Pendant",
                Price = 39500,
                PrimaryImage = "/assets/images/home/stones/ruby-jewellery.jpg",
                HoverImage = "/assets/images/home/category-pendants.jpg",
                Badge = "New",
                Material = "gold-plated",
                StoneType = "ruby",
                StyleLength = "solitaire",
                ChainOption = "includes-chain",
                FeaturedOrder = 5,
                NewestOrder = 2
            },

            new()
            {
                Id = 506,
                Name = "Diamond Light Halo Pendant",
                Price = 68000,
                PrimaryImage = "/assets/images/home/stones/diamond-jewellery.jpg",
                HoverImage = "/assets/images/home/category-pendants.jpg",
                Badge = "Best Seller",
                Material = "silver",
                StoneType = "diamond",
                StyleLength = "halo",
                ChainOption = "includes-chain",
                FeaturedOrder = 6,
                NewestOrder = 4
            },

            new()
            {
                Id = 507,
                Name = "Moonstone Vintage Pendant",
                Price = 22000,
                PrimaryImage = "/assets/images/home/category-pendants.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "",
                Material = "silver",
                StoneType = "semi-precious",
                StyleLength = "vintage",
                ChainOption = "pendant-only",
                FeaturedOrder = 7,
                NewestOrder = 6
            },

            new()
            {
                Id = 508,
                Name = "Minimal Sterling Silver Locket",
                Price = 9500,
                PrimaryImage = "/assets/images/home/category-pendants.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "New",
                Material = "silver",
                StoneType = "no-stone",
                StyleLength = "locket",
                ChainOption = "pendant-only",
                FeaturedOrder = 8,
                NewestOrder = 3
            },

            new()
            {
                Id = 509,
                Name = "Tourmaline Rosé Halo Pendant",
                Price = 27500,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-pendants.jpg",
                Badge = "",
                Material = "rose-gold",
                StoneType = "semi-precious",
                StyleLength = "halo",
                ChainOption = "includes-chain",
                FeaturedOrder = 9,
                NewestOrder = 10
            },

            new()
            {
                Id = 510,
                Name = "Sapphire Heritage Locket",
                Price = 52000,
                PrimaryImage = "/assets/images/home/stones/sapphire-jewellery.jpg",
                HoverImage = "/assets/images/home/category-pendants.jpg",
                Badge = "Few Left",
                Material = "silver",
                StoneType = "sapphire",
                StyleLength = "locket",
                ChainOption = "includes-chain",
                FeaturedOrder = 10,
                NewestOrder = 11
            },

            new()
            {
                Id = 511,
                Name = "Golden Letter M Pendant",
                Price = 11500,
                PrimaryImage = "/assets/images/home/collection-gold.jpg",
                HoverImage = "/assets/images/home/category-pendants.jpg",
                Badge = "",
                Material = "gold-plated",
                StoneType = "no-stone",
                StyleLength = "initial-letter",
                ChainOption = "pendant-only",
                FeaturedOrder = 11,
                NewestOrder = 9
            },

            new()
            {
                Id = 512,
                Name = "Rosé Amethyst Solitaire Pendant",
                Price = 24500,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-pendants.jpg",
                Badge = "New",
                Material = "rose-gold",
                StoneType = "semi-precious",
                StyleLength = "solitaire",
                ChainOption = "includes-chain",
                FeaturedOrder = 12,
                NewestOrder = 12
            }
        }
            };

            return View(model);
        }

        [HttpGet("nose-rings")]
        public IActionResult NoseRings()
        {
            var model = new CollectionPageViewModel
            {
                Title = "Women's Nose Rings",

                Subtitle =
                    "Delicate hoops and brilliant studs crafted for understated, everyday elegance.",

                HeroImage = "/assets/images/home/category-nose-rings.jpg",

                ParentCategory = "Women",

                Products = new List<CollectionProductViewModel>
        {
            new()
            {
                Id = 601,
                Name = "The Minimalist Gold Hoop",
                Price = 7500,
                PrimaryImage = "/assets/images/home/collection-gold.jpg",
                HoverImage = "/assets/images/home/category-nose-rings.jpg",
                Badge = "Best Seller",
                Material = "gold-plated",
                StoneType = "no-stone",
                StyleLength = "hoop",
                Gauge = "20g",
                FeaturedOrder = 1,
                NewestOrder = 5
            },

            new()
            {
                Id = 602,
                Name = "Diamond Light Nose Stud",
                Price = 18500,
                PrimaryImage = "/assets/images/home/stones/diamond-jewellery.jpg",
                HoverImage = "/assets/images/home/category-nose-rings.jpg",
                Badge = "New",
                Material = "silver",
                StoneType = "diamond",
                StyleLength = "stud",
                Gauge = "22g",
                FeaturedOrder = 2,
                NewestOrder = 1
            },

            new()
            {
                Id = 603,
                Name = "Rosé Whisper L-Bend Stud",
                Price = 4800,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-nose-rings.jpg",
                Badge = "",
                Material = "rose-gold",
                StoneType = "no-stone",
                StyleLength = "l-bend",
                Gauge = "20g",
                FeaturedOrder = 3,
                NewestOrder = 7
            },

            new()
            {
                Id = 604,
                Name = "Ceylon Sapphire Nose Pin",
                Price = 14500,
                PrimaryImage = "/assets/images/home/stones/sapphire-jewellery.jpg",
                HoverImage = "/assets/images/home/category-nose-rings.jpg",
                Badge = "Few Left",
                Material = "silver",
                StoneType = "sapphire",
                StyleLength = "stud",
                Gauge = "22g",
                FeaturedOrder = 4,
                NewestOrder = 8
            },

            new()
            {
                Id = 605,
                Name = "Golden Corkscrew Nose Stud",
                Price = 8500,
                PrimaryImage = "/assets/images/home/collection-gold.jpg",
                HoverImage = "/assets/images/home/category-nose-rings.jpg",
                Badge = "New",
                Material = "gold-plated",
                StoneType = "zircon",
                StyleLength = "corkscrew",
                Gauge = "20g",
                FeaturedOrder = 5,
                NewestOrder = 2
            },

            new()
            {
                Id = 606,
                Name = "Zircon Halo Silver Nose Stud",
                Price = 9800,
                PrimaryImage = "/assets/images/home/category-nose-rings.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "Best Seller",
                Material = "silver",
                StoneType = "zircon",
                StyleLength = "stud",
                Gauge = "22g",
                FeaturedOrder = 6,
                NewestOrder = 4
            },

            new()
            {
                Id = 607,
                Name = "Rosé Fine Septum Ring",
                Price = 12500,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-nose-rings.jpg",
                Badge = "",
                Material = "rose-gold",
                StoneType = "no-stone",
                StyleLength = "septum",
                Gauge = "18g",
                FeaturedOrder = 7,
                NewestOrder = 6
            },

            new()
            {
                Id = 608,
                Name = "Everyday Sterling Silver Hoop",
                Price = 3900,
                PrimaryImage = "/assets/images/home/category-nose-rings.jpg",
                HoverImage = "/assets/images/home/category-women.jpg",
                Badge = "New",
                Material = "silver",
                StoneType = "no-stone",
                StyleLength = "hoop",
                Gauge = "20g",
                FeaturedOrder = 8,
                NewestOrder = 3
            },

            new()
            {
                Id = 609,
                Name = "Sapphire Rosé L-Bend Stud",
                Price = 11800,
                PrimaryImage = "/assets/images/home/stones/sapphire-jewellery.jpg",
                HoverImage = "/assets/images/home/category-nose-rings.jpg",
                Badge = "",
                Material = "rose-gold",
                StoneType = "sapphire",
                StyleLength = "l-bend",
                Gauge = "22g",
                FeaturedOrder = 9,
                NewestOrder = 10
            },

            new()
            {
                Id = 610,
                Name = "Diamond Orbit Septum Ring",
                Price = 22000,
                PrimaryImage = "/assets/images/home/stones/diamond-jewellery.jpg",
                HoverImage = "/assets/images/home/category-nose-rings.jpg",
                Badge = "Few Left",
                Material = "silver",
                StoneType = "diamond",
                StyleLength = "septum",
                Gauge = "18g",
                FeaturedOrder = 10,
                NewestOrder = 11
            },

            new()
            {
                Id = 611,
                Name = "Golden Plain Nose Pin",
                Price = 4500,
                PrimaryImage = "/assets/images/home/collection-gold.jpg",
                HoverImage = "/assets/images/home/category-nose-rings.jpg",
                Badge = "",
                Material = "gold-plated",
                StoneType = "no-stone",
                StyleLength = "stud",
                Gauge = "22g",
                FeaturedOrder = 11,
                NewestOrder = 9
            },

            new()
            {
                Id = 612,
                Name = "Rosé Zircon Corkscrew Stud",
                Price = 9200,
                PrimaryImage = "/assets/images/home/collection-rose-gold.jpg",
                HoverImage = "/assets/images/home/category-nose-rings.jpg",
                Badge = "New",
                Material = "rose-gold",
                StoneType = "zircon",
                StyleLength = "corkscrew",
                Gauge = "20g",
                FeaturedOrder = 12,
                NewestOrder = 12
            }
        }
            };

            return View(model);
        }
    }
}