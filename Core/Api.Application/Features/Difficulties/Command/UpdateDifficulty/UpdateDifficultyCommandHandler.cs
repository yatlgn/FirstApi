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
using Api.Application.Bases;
using Microsoft.AspNetCore.Http;

namespace Api.Application.Features.Difficulties.Command.UpdateDifficulty
{
    public class UpdateDifficultyCommandHandler : BaseHandler, IRequestHandler<UpdateDifficultyCommandRequest,Unit>
    {
       
        public UpdateDifficultyCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {


        }
        public async Task<Unit> Handle(UpdateDifficultyCommandRequest request, CancellationToken cancellationToken)
        {
            var difficulty = await unitOfWork.GetReadRepository<Difficulty>().GetAsync(x => x.Id == request.DifficultyId && !x.IsDeleted);
            var map = mapper.Map<Difficulty, UpdateDifficultyCommandRequest>(request);

            return Unit.Value;
        }
    }
}
