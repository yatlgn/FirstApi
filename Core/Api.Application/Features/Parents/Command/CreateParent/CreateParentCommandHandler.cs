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

namespace Api.Application.Features.Parents.Command.CreateParent
{

    public class CreateParentCommandHandler :BaseHandler, IRequestHandler<CreateParentCommandRequest,Unit>
    {
        
        public CreateParentCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            
        }
        public async Task<Unit> Handle(CreateParentCommandRequest request, CancellationToken cancellationToken)
        {
            Parent parent = new(request.ParentId, request.Name, request.Surname, request.Gender, request.Job, request.PhoneNum);

            await unitOfWork.GetWriteRepository<Parent>().AddAsync(parent);
            var result = await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
