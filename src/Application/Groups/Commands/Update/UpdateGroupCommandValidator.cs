using FluentValidation;

namespace TALMS.Application.Groups.Commands.Update
{
    public class UpdateGroupCommandValidator : AbstractValidator<UpdateGroupCommand>
    {
        public UpdateGroupCommandValidator()
        {
            RuleFor(v=> v.GroupName).MaximumLength(255).NotEmpty();
        }
    }
}