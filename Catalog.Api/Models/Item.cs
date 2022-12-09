
namespace Catalog.Api.Models
{
    public record Item
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }       
        public decimal Price { get; set; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}