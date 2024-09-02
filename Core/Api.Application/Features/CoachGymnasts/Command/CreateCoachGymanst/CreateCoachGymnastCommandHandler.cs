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

namespace Api.Application.Features.CoachGymnasts.Command.CreateCoachGymanst
{
    public class CreateCoachGymnastCommandHandler :BaseHandler,  IRequestHandler<CreateCoachGymnastCommandRequest, Unit>
    {
        public CreateCoachGymnastCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
           
        }
        public async Task<Unit> Handle(CreateCoachGymnastCommandRequest request, CancellationToken cancellationToken)
        {
            CoachGymnast coachgymnast = new(request.Id, request.GymnastId, request.GymnastId);

            await unitOfWork.GetWriteRepository<CoachGymnast>().AddAsync(coachgymnast);
            var result = await unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
