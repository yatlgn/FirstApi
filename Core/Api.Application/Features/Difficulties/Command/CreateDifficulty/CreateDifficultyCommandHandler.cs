using Api.Application.Features.Coachs.Command.CreateCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Difficulties.Command.CreateDifficulty
{
    public class CreateDifficultyCommandHandler : IRequestHandler<CreateDifficultyCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        public CreateDifficultyCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task Handle(CreateDifficultyCommandRequest request, CancellationToken cancellationToken)
        {
            Difficulty difficulty = new(request.DifficultyId, request.DifficultyName, request.DifficultyType, request.DifficultyPoint);

            await unitOfWork.GetWriteRepository<Difficulty>().AddAsync(difficulty);
            var result = await unitOfWork.SaveAsync();
        }
    }
}
