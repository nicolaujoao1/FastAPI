using FluentValidation;

namespace FastAPI.Features.Products.Create;

public class Request
{
    public string Name { get; set; } = default!;
    public long Quantity { get; set; } = default!;
    public decimal Amount { get; set; }
}
public class Response
{
    public string Message => $"{nameof(Product)} created!";

}
public class Validator : Validator<Request>
{
    public Validator()
    {

        RuleFor(x => x.Name)
             .NotEmpty().WithMessage("Name is required!");

        RuleFor(x => x.Quantity)
            .NotEmpty().WithMessage("Quantity is required!");
        
        
        RuleFor(x => x.Amount)
        .NotEmpty().WithMessage("Amount is required!");
    }
}
