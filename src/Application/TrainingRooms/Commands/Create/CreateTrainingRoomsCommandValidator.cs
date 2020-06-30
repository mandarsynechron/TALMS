using FluentValidation;

namespace TALMS.Application.TrainingRooms.Commands.Create
{
    public class CreateTrainingRoomsCommandValidator : AbstractValidator<CreateTrainingRoomsCommand>
    {
        public CreateTrainingRoomsCommandValidator()
        {
            RuleFor(v=> v.RoomDescription).MaximumLength(255).NotEmpty();
        }
    }
}