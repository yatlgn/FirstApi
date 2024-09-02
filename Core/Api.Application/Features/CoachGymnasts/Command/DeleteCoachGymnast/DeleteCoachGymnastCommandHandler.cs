using Api.Application.Bases;
using Api.Application.Features.Coachs.Command.DeleteCoach;
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

namespace Api.Application.Features.CoachGymnasts.Command.DeleteCoachGymnast
{
    public class DeleteCoachGymnastCommandHandler : BaseHandler, IRequestHandler<DeleteCoachGymnastCommandRequest, Unit>
    {
       
        public DeleteCoachGymnastCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            

        }
        public async Task<Unit> Handle(DeleteCoachGymnastCommandRequest request, CancellationToken cancellationToken)
        {
            var coachgymnast = await unitOfWork.GetReadRepository<CoachGymnast>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            coachgymnast.IsDeleted = false;

             await unitOfWork.GetWriteRepository<CoachGymnast>().UpdateAsync(coachgymnast);
            await unitOfWork.SaveAsync();

            return Unit.Value;

        }
    }
}
