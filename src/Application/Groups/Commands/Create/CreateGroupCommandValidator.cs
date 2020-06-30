using FluentValidation;

namespace TALMS.Application.Groups.Commands.Create
{
    public class CreateGroupCommandValidator : AbstractValidator<CreateGroupCommand>
    {
        public CreateGroupCommandValidator()
        {
            RuleFor(v=> v.GroupName).MaximumLength(255).NotEmpty();
        }
    }
}