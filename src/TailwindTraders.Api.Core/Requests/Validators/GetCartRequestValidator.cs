namespace TailwindTraders.Api.Core.Requests.Validators;

public class GetCartRequestValidator : AbstractValidator<GetCartRequest>
{
    public GetCartRequestValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .NotNull()
            .WithMessage("Email cannot be null/empty.");
        RuleFor(x => x.Email)
            .EmailAddress()
            .WithMessage("Incorrect format for Email.");
    }
}