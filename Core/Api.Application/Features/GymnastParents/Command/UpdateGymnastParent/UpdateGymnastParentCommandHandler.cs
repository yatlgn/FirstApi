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

namespace Api.Application.Features.GymnastParents.Command.UpdateGymnastParent
{
    public class UpdateGymnastParentCommandHandler : IRequestHandler<UpdateGymnastParentCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public UpdateGymnastParentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }
        public async Task<Unit> Handle(UpdateGymnastParentCommandRequest request, CancellationToken cancellationToken)
        {
            var gymnast = await unitOfWork.GetReadRepository<GymnastParent>().GetAsync(x => x.Id == request.GymnastId && !x.IsDeleted);
            var parent = await unitOfWork.GetReadRepository<GymnastParent>().GetAsync(x => x.Id == request.ParentId && !x.IsDeleted);
            var map = mapper.Map<Coach, UpdateCoachCommandRequest>(request);

            return Unit.Value;
        }
    }
}
