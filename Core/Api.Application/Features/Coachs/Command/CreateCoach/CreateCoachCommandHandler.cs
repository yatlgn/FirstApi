using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Api.Application.Features.Coachs.Command.CreateCoach
{
    public class CreateCoachCommandHandler : IRequestHandler<CreateCoachCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        public CreateCoachCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork; 
        }
        public async Task<Unit> Handle(CreateCoachCommandRequest request, CancellationToken cancellationToken)
        {
            Coach coach  = new (request.CoachId, request.Name, request.Surname, request.Gender, request.Branch, request.Brevet);
           
            await unitOfWork.GetWriteRepository<Coach>().AddAsync(coach);
            var result = await unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
