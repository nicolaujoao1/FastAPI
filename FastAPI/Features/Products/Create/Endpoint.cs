namespace FastAPI.Features.Products.Create;

public class Endpoint : Endpoint<Request, Response, Mapper>
{
    public override void Configure()
    {
        Post("/products/create");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request r, CancellationToken c)
    {
        Response response = await Data.CreateAsync(await Map.ToEntityAsync(r, c));

        await SendAsync(response);
    }
}
