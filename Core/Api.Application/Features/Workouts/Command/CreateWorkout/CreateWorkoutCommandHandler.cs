using Api.Application.Features.Coachs.Command.CreateCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Workouts.Command.CreateWorkout
{
    public class CreateWorkoutCommandHandler : IRequestHandler<CreateWorkoutCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        public CreateWorkoutCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task Handle(CreateWorkoutCommandRequest request, CancellationToken cancellationToken)
        {
            Workout workout = new(request.WorkoutHours, request.WorkoutDays, request.WorkoutType);

            await unitOfWork.GetWriteRepository<Workout>().AddAsync(workout);
            var result = await unitOfWork.SaveAsync();
        }
    }
}
