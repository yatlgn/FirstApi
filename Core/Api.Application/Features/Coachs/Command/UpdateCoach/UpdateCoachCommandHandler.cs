using Api.Application.Interfaces;
using Api.Application.Interfaces.AutoMapper;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Coachs.Command.UpdateCoach
{
    public class UpdateCoachCommandHandler : IRequestHandler<UpdateCoachCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public UpdateCoachCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            
        }
        public async Task Handle(UpdateCoachCommandRequest request, CancellationToken cancellationToken)
        {
            var coach = await unitOfWork.GetReadRepository<Coach>().GetAsync(x => x.Id == request.CoachId && !x.IsDeleted);
            var map = mapper.Map<Coach, UpdateCoachCommandRequest>(request);
        }
    }
}
