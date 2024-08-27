using Api.Application.Features.Coachs.Command.CreateCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Parents.Command.CreateParent
{

    public class CreateParentCommandHandler : IRequestHandler<CreateParentCommandRequest,Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        public CreateParentCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
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
