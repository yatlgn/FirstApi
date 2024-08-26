using Api.Application.Features.Coachs.Command.CreateCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.GymnastParents.Command.CreateGymnastParent
{
    
    
        public class CreateGymnastParentCommandHandler : IRequestHandler<CreateGymnastParentCommandRequest>
        {
            private readonly IUnitOfWork unitOfWork;
            public CreateGymnastParentCommandHandler(IUnitOfWork unitOfWork)
            {
                this.unitOfWork = unitOfWork;
            }
            public async Task Handle(CreateGymnastParentCommandRequest request, CancellationToken cancellationToken)
            {
                GymnastParent gymnastparent = new(request.Id, request.GymnastId, request.ParentId);

                await unitOfWork.GetWriteRepository<GymnastParent>().AddAsync(gymnastparent);
                var result = await unitOfWork.SaveAsync();
            }
        }
}
