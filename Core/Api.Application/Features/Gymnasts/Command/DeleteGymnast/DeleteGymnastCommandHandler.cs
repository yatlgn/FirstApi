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

namespace Api.Application.Features.Gymnasts.Command.DeleteGymnast
{
    public class DeleteGymnastCommandHandler : BaseHandler, IRequestHandler<DeleteGymnastCommandRequest,Unit>
    {
        
        public DeleteGymnastCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
           

        }
        public async Task<Unit> Handle(DeleteGymnastCommandRequest request, CancellationToken cancellationToken)
        {
            var gymnast = await unitOfWork.GetReadRepository<Gymnast>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            gymnast.IsDeleted = false;

            await unitOfWork.GetWriteRepository<Gymnast>().UpdateAsync(gymnast);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
