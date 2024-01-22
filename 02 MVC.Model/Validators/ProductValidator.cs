using _02_MVC.Model.Data.Entities;
using FluentValidation;

namespace _02_MVC.Model.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator() 
        {
            RuleFor(x=>x.Name)
                .NotEmpty()
                .MinimumLength(2)
                .Matches("[A-Z].*").WithMessage("{PropertyName} must starts with uppercase letter.");
            RuleFor(x => x.Description)
                 .Length(10, 50000)
                 .Matches("[A-Z].*").WithMessage("{PropertyName} must starts with uppercase letter.");
            RuleFor(x => x.Price)
                .NotEmpty()
                .GreaterThanOrEqualTo(0).WithMessage("{PropertyName} must be more than 0");
            RuleFor(x => x.Discount)
                .NotEmpty()
                .GreaterThanOrEqualTo(0).WithMessage("{PropertyName} must be more than 0");
            RuleFor(x => x.ImageUrl)
                .NotEmpty()
                .Must(LinkMustBeAUri).WithMessage("{PropertyName} must be a valid URL address");
            RuleFor(x=>x.Rating)
                .NotEmpty()
                .GreaterThanOrEqualTo(0).WithMessage("{PropertyName} must be more than 0");
        }
        private static bool LinkMustBeAUri(string link)
        {
            if (string.IsNullOrWhiteSpace(link))
            {
                return false;
            }

            //Courtesy of @Pure.Krome's comment and https://stackoverflow.com/a/25654227/563532
            Uri outUri;
            return Uri.TryCreate(link, UriKind.Absolute, out outUri)
                   && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps);
        }
    }
}
