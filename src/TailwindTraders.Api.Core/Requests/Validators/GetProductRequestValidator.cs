namespace TailwindTraders.Api.Core.Requests.Validators;

public class GetProductRequestValidator : AbstractValidator<GetProductRequest>
{
    public GetProductRequestValidator()
    {
        RuleFor(x => x.ProductId)
            .GreaterThan(0);
    }
}