using DataAccess.Model.Data.Entities;
using BusinessLogic.DTOs;
using FluentValidation;

namespace DataAccess.Model.Validators
{
    public class CategoryValidator : AbstractValidator<CategoryDto>
    {
        public CategoryValidator() {
            RuleFor(x => x.Name)
                .NotEmpty()
                .Matches("[A-Z].*").WithMessage("{PropertyName} must starts with uppercase letter.");
        }

    }
}
