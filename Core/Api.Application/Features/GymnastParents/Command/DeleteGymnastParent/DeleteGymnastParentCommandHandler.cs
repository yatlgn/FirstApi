using Api.Application.Features.Coachs.Command.DeleteCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.GymnastParents.Command.DeleteGymnastParent
{
    public class DeleteGymnastParentCommandHandler : IRequestHandler<DeleteGymnastParentCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        public DeleteGymnastParentCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        public async Task Handle(DeleteGymnastParentCommandRequest request, CancellationToken cancellationToken)
        {
            var gymnastparent = await unitOfWork.GetReadRepository<GymnastParent>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            gymnastparent.IsDeleted = false;

            await unitOfWork.GetWriteRepository<GymnastParent>().UpdateAsync(gymnastparent);
            await unitOfWork.SaveAsync();
        }
    }
}