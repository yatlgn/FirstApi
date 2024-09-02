using Api.Application.Bases;
using Api.Application.Features.Coachs.Command.CreateCoach;
using Api.Application.Interfaces;
using Api.Application.Interfaces.AutoMapper;
using Api.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Difficulties.Command.CreateDifficulty
{
    public class CreateDifficultyCommandHandler :BaseHandler, IRequestHandler<CreateDifficultyCommandRequest, Unit>
    {
        
        public CreateDifficultyCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
           
        }
        public async Task<Unit> Handle(CreateDifficultyCommandRequest request, CancellationToken cancellationToken)
        {
            Difficulty difficulty = new(request.DifficultyId, request.DifficultyName, request.DifficultyType, request.DifficultyPoint);

            await unitOfWork.GetWriteRepository<Difficulty>().AddAsync(difficulty);
            var result = await unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
