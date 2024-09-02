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

namespace Api.Application.Features.GymnastParents.Command.UpdateGymnastParent
{
    public class UpdateGymnastParentCommandHandler :BaseHandler, IRequestHandler<UpdateGymnastParentCommandRequest, Unit>
    {
        
        public UpdateGymnastParentCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {


        }
        public async Task<Unit> Handle(UpdateGymnastParentCommandRequest request, CancellationToken cancellationToken)
        {
            var gymnast = await unitOfWork.GetReadRepository<GymnastParent>().GetAsync(x => x.Id == request.GymnastId && !x.IsDeleted);
            var parent = await unitOfWork.GetReadRepository<GymnastParent>().GetAsync(x => x.Id == request.ParentId && !x.IsDeleted);
            var map = mapper.Map<Coach, UpdateCoachCommandRequest>(request);

            return Unit.Value;
        }
    }
}
