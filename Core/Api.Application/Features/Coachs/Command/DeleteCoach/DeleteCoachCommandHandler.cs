using Api.Application.Bases;
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

namespace Api.Application.Features.Coachs.Command.DeleteCoach
{
    public class DeleteCoachCommandHandler :BaseHandler, IRequestHandler<DeleteCoachCommandRequest, Unit>
    {
        
        public DeleteCoachCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {

            
        }
        public  async Task<Unit> Handle(DeleteCoachCommandRequest request, CancellationToken cancellationToken)
        {
            var coach = await unitOfWork.GetReadRepository<Coach>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            coach.IsDeleted = false;

            await unitOfWork.GetWriteRepository<Coach>().UpdateAsync(coach);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
