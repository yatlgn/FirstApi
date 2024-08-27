using Api.Application.Features.Coachs.Command.DeleteCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Gymnasts.Command.DeleteGymnast
{
    public class DeleteGymnastCommandHandler : IRequestHandler<DeleteGymnastCommandRequest,Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        public DeleteGymnastCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

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
