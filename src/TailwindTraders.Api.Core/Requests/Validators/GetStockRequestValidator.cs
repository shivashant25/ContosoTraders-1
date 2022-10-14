namespace TailwindTraders.Api.Core.Requests.Validators;

public class GetStockRequestValidator : AbstractValidator<GetStockRequest>
{
    public GetStockRequestValidator()
    {
        RuleFor(x => x.ProductId)
            .GreaterThan(0);
    }
}