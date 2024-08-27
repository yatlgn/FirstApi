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

namespace Api.Application.Features.Parents.Command.UpdateParent
{
    public class UpdateParentCommandHandler : IRequestHandler<UpdateParentCommandRequest,Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public UpdateParentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }
        public async Task<Unit> Handle(UpdateParentCommandRequest request, CancellationToken cancellationToken)
        {
            var parent = await unitOfWork.GetReadRepository<Parent>().GetAsync(x => x.Id == request.ParentId && !x.IsDeleted);
            var map = mapper.Map<Parent, UpdateParentCommandRequest>(request);
            return Unit.Value;
        }
    }
}
