using Api.Application.Features.Coachs.Command.CreateCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CompetitionGymnasts.Command.CreateCompetitionGymnast
{
    public class CreateCompetitionGymnastCommandHandler : IRequestHandler<CreateCompetitionGymnastCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        public CreateCompetitionGymnastCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task Handle(CreateCompetitionGymnastCommandRequest request, CancellationToken cancellationToken)
        {
            CompetitionGymnast competitiongymnast = new(request.Id, request.GymnastId, request.CompetitionId);

            await unitOfWork.GetWriteRepository<CompetitionGymnast>().AddAsync(competitiongymnast);
            var result = await unitOfWork.SaveAsync();
        }
    }
}
