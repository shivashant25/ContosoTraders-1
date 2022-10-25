namespace TailwindTraders.Api.Core.Requests.Validators;

public class RemoveItemFromCartRequestValidator : AbstractValidator<RemoveItemFromCartRequest>
{
    public RemoveItemFromCartRequestValidator()
    {
        RuleFor(x => x.CartItem.CartItemId)
            .NotNull()
            .NotEmpty()
            .WithMessage("CartItemId cannot be null/empty.");
        RuleFor(x => x.CartItem.Email)
            .NotNull()
            .NotEmpty()
            .WithMessage("Email cannot be null/empty.");
    }
}