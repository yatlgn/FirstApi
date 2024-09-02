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

namespace Api.Application.Features.Parents.Command.DeleteParent
{
    public class DeleteParentCommandHandler : BaseHandler, IRequestHandler<DeleteParentCommandRequest,Unit>
    {
   
        public DeleteParentCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {


        }
        public async Task<Unit> Handle(DeleteParentCommandRequest request, CancellationToken cancellationToken)
        {
            var parent = await unitOfWork.GetReadRepository<Parent>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            parent.IsDeleted = false;

            await unitOfWork.GetWriteRepository<Parent>().UpdateAsync(parent);
            await unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}

