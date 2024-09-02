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

namespace Api.Application.Features.GymnastParents.Command.CreateGymnastParent
{
    
    
        public class CreateGymnastParentCommandHandler : BaseHandler ,IRequestHandler<CreateGymnastParentCommandRequest, Unit>
        {
           
            public CreateGymnastParentCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
               
            }
            public async Task<Unit> Handle(CreateGymnastParentCommandRequest request, CancellationToken cancellationToken)
            {
                GymnastParent gymnastparent = new(request.Id, request.GymnastId, request.ParentId);

                await unitOfWork.GetWriteRepository<GymnastParent>().AddAsync(gymnastparent);
                var result = await unitOfWork.SaveAsync();
            
                return Unit.Value;
            }
        }
}
