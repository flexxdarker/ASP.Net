using _02_MVC.Model.Data.Entities;
using FluentValidation;

namespace _02_MVC.Model.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator() {
            RuleFor(x => x.Name)
                .NotEmpty()
                .Matches("[A-Z].*").WithMessage("{PropertyName} must starts with uppercase letter.");
        }

    }
}
