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

namespace Api.Application.Features.Gymnasts.Command.UpdateGymnast
{
    public class UpdateGymnastCommandHandler : BaseHandler, IRequestHandler<UpdateGymnastCommandRequest,Unit>
    {
    
        public UpdateGymnastCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {


        }
        public async Task<Unit> Handle(UpdateGymnastCommandRequest request, CancellationToken cancellationToken)
        {
            var gymnast = await unitOfWork.GetReadRepository<Gymnast>().GetAsync(x => x.Id == request.GymnastId && !x.IsDeleted);
            var map = mapper.Map<Gymnast, UpdateGymnastCommandRequest>(request);

            return Unit.Value;
        }
    }
}
