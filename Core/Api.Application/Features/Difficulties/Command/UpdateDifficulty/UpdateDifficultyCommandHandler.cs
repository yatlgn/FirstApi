using Api.Application.Features.Coachs.Command.UpdateCoach;
using Api.Application.Interfaces.AutoMapper;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Difficulties.Command.UpdateDifficulty
{
    public class UpdateDifficultyCommandHandler : IRequestHandler<UpdateDifficultyCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public UpdateDifficultyCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }
        public async Task Handle(UpdateDifficultyCommandRequest request, CancellationToken cancellationToken)
        {
            var difficulty = await unitOfWork.GetReadRepository<Difficulty>().GetAsync(x => x.Id == request.DifficultyId && !x.IsDeleted);
            var map = mapper.Map<Difficulty, UpdateDifficultyCommandRequest>(request);
        }
    }
}
