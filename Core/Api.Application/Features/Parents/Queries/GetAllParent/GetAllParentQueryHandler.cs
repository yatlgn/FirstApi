using Api.Application.Interfaces.AutoMapper;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;

namespace Api.Application.Features.Parents.Queries.GetAllParent
{
    public class GetAllParentQueryHandler : IRequestHandler<GetAllParentQueryRequest, IList<GetAllParentQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private IMapper mapper;

        public GetAllParentQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }
        public async Task<IList<GetAllParentQueryResponse>> Handle(GetAllParentQueryRequest request, CancellationToken cancellationToken)
        {
            var parents = await unitOfWork.GetReadRepository<Parent>().GetAllAsync();

            List<GetAllParentQueryResponse> response = new();


            var map = mapper.Map<GetAllParentQueryResponse, Parent>(parents);
            return response;
        }
    }
}
