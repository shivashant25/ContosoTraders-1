namespace TailwindTraders.Api.Core.Requests.Validators;

public class AddItemToCartRequestValidator : AbstractValidator<AddItemToCartRequest>
{
    public AddItemToCartRequestValidator()
    {
        RuleFor(x => x.CartItem.CartItemId)
            .NotEmpty()
            .NotNull()
            .WithMessage("CartItemId cannot be empty/null");
    }
}