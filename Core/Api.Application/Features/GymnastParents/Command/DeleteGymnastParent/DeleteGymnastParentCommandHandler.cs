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

namespace Api.Application.Features.GymnastParents.Command.DeleteGymnastParent
{
    public class DeleteGymnastParentCommandHandler : BaseHandler, IRequestHandler<DeleteGymnastParentCommandRequest,Unit>
    {
       
        public DeleteGymnastParentCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
           

        }
        public async Task<Unit> Handle(DeleteGymnastParentCommandRequest request, CancellationToken cancellationToken)
        {
            var gymnastparent = await unitOfWork.GetReadRepository<GymnastParent>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            gymnastparent.IsDeleted = false;

            await unitOfWork.GetWriteRepository<GymnastParent>().UpdateAsync(gymnastparent);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}