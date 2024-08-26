using Api.Application.Features.Coachs.Command.CreateCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CoachGymnasts.Command.CreateCoachGymanst
{
    public class CreateCoachGymnastCommandHandler : IRequestHandler<CreateCoachGymnastCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        public CreateCoachGymnastCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task Handle(CreateCoachGymnastCommandRequest request, CancellationToken cancellationToken)
        {
            CoachGymnast coachgymnast = new(request.Id, request.GymnastId, request.GymnastId);

            await unitOfWork.GetWriteRepository<CoachGymnast>().AddAsync(coachgymnast);
            var result = await unitOfWork.SaveAsync();
        }
    }
}
