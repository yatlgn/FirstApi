using Api.Application.Bases;
using Api.Application.Interfaces;
using Api.Application.Interfaces.AutoMapper;
using Api.Domain.Entities;
using MediatR;
using MediatR.Pipeline;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Api.Application.Features.Coachs.Command.CreateCoach
{
    public class CreateCoachCommandHandler : BaseHandler, IRequestHandler<CreateCoachCommandRequest, Unit>
    {
        
        public CreateCoachCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        
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
