using FluentValidation;

namespace TALMS.Application.Presentations.Commands.Create
{
    public class CreatePresentationCommandValidator : AbstractValidator<CreatePresentationCommand>
    {
        public CreatePresentationCommandValidator()
        {
            RuleFor(v=> v.DisplayText).MaximumLength(50).NotEmpty();
            RuleFor(v=> v.DisplaySubText).MaximumLength(50).NotEmpty();
            RuleFor(v=> v.LinkUrl).MaximumLength(300);
            RuleFor(v=> v.Color).MaximumLength(12);
            RuleFor(v=> v.Size).MaximumLength(10);
            RuleFor(v=> v.Type).MaximumLength(10);
            RuleFor(v=> v.CreatedBy).NotEmpty();
        }
    }
}