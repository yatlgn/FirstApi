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

namespace Api.Application.Features.Gymnasts.Command.UpdateGymnast
{
    public class UpdateGymnastCommandHandler : IRequestHandler<UpdateGymnastCommandRequest,Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public UpdateGymnastCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }
        public async Task<Unit> Handle(UpdateGymnastCommandRequest request, CancellationToken cancellationToken)
        {
            var gymnast = await unitOfWork.GetReadRepository<Gymnast>().GetAsync(x => x.Id == request.GymnastId && !x.IsDeleted);
            var map = mapper.Map<Gymnast, UpdateGymnastCommandRequest>(request);

            return Unit.Value;
        }
    }
}
