
namespace FastAPI.Features.Products.Create;

public class Mapper : Mapper<Request, Response, Product>
{
    public override async Task<Product> ToEntityAsync(Request r, CancellationToken ct = default) => new()
    {
        Id = Guid.NewGuid(),
        Name = r.Name,
        Quantity = r.Quantity,
        Amount = r.Amount,
    };
    //{

    //    return base.ToEntityAsync(r, ct);
    //}
}
