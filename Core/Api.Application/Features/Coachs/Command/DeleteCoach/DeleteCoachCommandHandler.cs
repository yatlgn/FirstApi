using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Coachs.Command.DeleteCoach
{
    public class DeleteCoachCommandHandler : IRequestHandler<DeleteCoachCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        public DeleteCoachCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            
        }
        public  async Task<Unit> Handle(DeleteCoachCommandRequest request, CancellationToken cancellationToken)
        {
            var coach = await unitOfWork.GetReadRepository<Coach>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            coach.IsDeleted = false;

            await unitOfWork.GetWriteRepository<Coach>().UpdateAsync(coach);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
