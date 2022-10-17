namespace TailwindTraders.Api.Core.Requests.Validators;

public class DecrementStockCountRequestValidator : AbstractValidator<DecrementStockCountRequest>
{
    public DecrementStockCountRequestValidator()
    {
        RuleFor(x => x.ProductId)
            .GreaterThan(0);
    }
}