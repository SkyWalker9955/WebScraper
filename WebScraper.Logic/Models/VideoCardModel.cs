using WebScraper.Logic.Interfaces;

namespace WebScraper.Logic.Models;

internal class VideoCardModel : IProduct
{
    public required string Name { get; set; }
    public required string Price { get; set; }
    public required string DateReleased { get; set; }
    public required string Description { get; set; }
    public string Type { get; set; } = "VideoCard";
}
