using FluentValidation;
using TraversalCoreMY.Entity.Concrete.Home;

namespace TraversalCoreMY.BL.ValidationRules
{
    public class HomeAboutValidatior : AbstractValidator<HomeAbout>
    {
        public HomeAboutValidatior()
        {
            RuleFor(x => x.MainTitle).NotEmpty().WithMessage("MainTitle boş bırakılamaz.").MaximumLength(100).WithMessage("MainTitle 100 karakterden uzun olamaz."); 
            
            RuleFor(x => x.MainDescription).NotEmpty().WithMessage("MainDescription boş bırakılamaz.").MaximumLength(500).WithMessage("MainDescription 500 karakterden uzun olamaz."); 
            
            RuleFor(x => x.SecondaryTitle).NotEmpty().WithMessage("SecondaryTitle boş bırakılamaz.").MaximumLength(100).WithMessage("SecondaryTitle 100 karakterden uzun olamaz."); 
            
            RuleFor(x => x.SecondaryDescription).NotEmpty().WithMessage("SecondaryDescription boş bırakılamaz.").MaximumLength(500).WithMessage("SecondaryDescription 500 karakterden uzun olamaz."); 
            
            RuleFor(x => x.IsActive).NotNull().WithMessage("IsActive alanı boş olamaz.");
        }
    }   
}
