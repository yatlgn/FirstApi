using Api.Application.Features.Coachs.Command.DeleteCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Parents.Command.DeleteParent
{
    public class DeleteParentCommandHandler : IRequestHandler<DeleteParentCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        public DeleteParentCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        public async Task Handle(DeleteParentCommandRequest request, CancellationToken cancellationToken)
        {
            var parent = await unitOfWork.GetReadRepository<Parent>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            parent.IsDeleted = false;

            await unitOfWork.GetWriteRepository<Parent>().UpdateAsync(parent);
            await unitOfWork.SaveAsync();
        }
    }
}

