namespace TailwindTraders.Api.Core.Requests.Validators;

public class UpdateCartItemQuantityRequestValidator : AbstractValidator<UpdateCartItemQuantityRequest>
{
    public UpdateCartItemQuantityRequestValidator()
    {
        RuleFor(x => x.CartItem.CartItemId)
            .NotNull()
            .WithMessage("CartItemId cannot be null/empty.");
        RuleFor(x => x.CartItem.Quantity)
            .NotNull()
            .WithMessage("Quantity cannot be null/empty.");
    }
}