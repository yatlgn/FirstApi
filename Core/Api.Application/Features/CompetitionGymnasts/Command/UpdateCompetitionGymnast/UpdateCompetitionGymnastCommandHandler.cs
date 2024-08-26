using Api.Application.Features.Coachs.Command.UpdateCoach;
using Api.Application.Interfaces.AutoMapper;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CompetitionGymnasts.Command.UpdateCompetitionGymnast
{
    public class UpdateCompetitionGymnastCommandHandler : IRequestHandler<UpdateCompetitionGymnastCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public UpdateCompetitionGymnastCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }
        public async Task Handle(UpdateCompetitionGymnastCommandRequest request, CancellationToken cancellationToken)
        {
            var competition = await unitOfWork.GetReadRepository<CompetitionGymnast>().GetAsync(x => x.Id == request.CompetitionId && !x.IsDeleted);
            var gymnast = await unitOfWork.GetReadRepository<CompetitionGymnast>().GetAsync(x => x.Id == request.GymnastId && !x.IsDeleted);
            var map = mapper.Map<CompetitionGymnast, UpdateCompetitionGymnastCommandRequest>(request);
        }
    }
}
