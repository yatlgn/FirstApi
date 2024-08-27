using Api.Application.Features.Coachs.Command.DeleteCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CompetitionGymnasts.Command.DeleteCompetitionGymnast
{
    public class DeleteCompetitionGymnastCommandHandler : IRequestHandler<DeleteCompetitionGymnastCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        public DeleteCompetitionGymnastCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        public async Task<Unit> Handle(DeleteCompetitionGymnastCommandRequest request, CancellationToken cancellationToken)
        {
            var competitiongymnast = await unitOfWork.GetReadRepository<CompetitionGymnast>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            competitiongymnast.IsDeleted = false;

            await unitOfWork.GetWriteRepository<CompetitionGymnast>().UpdateAsync(competitiongymnast);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
