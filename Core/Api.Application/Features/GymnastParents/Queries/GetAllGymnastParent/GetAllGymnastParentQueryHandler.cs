using Api.Application.Interfaces.AutoMapper;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;

namespace Api.Application.Features.GymnastParents.Queries.GetAllGymnastParent
{

    public class GetAllGymnastParentQueryHandler : IRequestHandler<GetAllGymnastParentQueryRequest, IList<GetAllGymnastParentQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private IMapper mapper;

        public GetAllGymnastParentQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }
        public async Task<IList<GetAllGymnastParentQueryResponse>> Handle(GetAllGymnastParentQueryRequest request, CancellationToken cancellationToken)
        {
            var gymnastparents = await unitOfWork.GetReadRepository<GymnastParent>().GetAllAsync();

            List<GetAllGymnastParentQueryResponse> response = new();


            var map = mapper.Map<GetAllGymnastParentQueryResponse, GymnastParent>(gymnastparents);
            return response;
        }
    }
}

