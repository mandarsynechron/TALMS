using FluentValidation;

namespace TALMS.Application.TrainingRooms.Commands.Update
{
    public class UpdateTrainingRoomsCommandValidator : AbstractValidator<UpdateTrainingRoomsCommand>
    {
        public UpdateTrainingRoomsCommandValidator()
        {
            RuleFor(v=> v.RoomDescription).MaximumLength(255).NotEmpty();
        }
    }
}