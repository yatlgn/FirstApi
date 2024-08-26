using Api.Application.Features.Coachs.Command.DeleteCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CoachGymnasts.Command.DeleteCoachGymnast
{
    public class DeleteCoachGymnastCommandHandler : IRequestHandler<DeleteCoachGymnastCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        public DeleteCoachGymnastCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        public async Task Handle(DeleteCoachGymnastCommandRequest request, CancellationToken cancellationToken)
        {
            var coachgymnast = await unitOfWork.GetReadRepository<CoachGymnast>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            coachgymnast.IsDeleted = false;

            await unitOfWork.GetWriteRepository<CoachGymnast>().UpdateAsync(coachgymnast);
            await unitOfWork.SaveAsync();
        }
    }
}
