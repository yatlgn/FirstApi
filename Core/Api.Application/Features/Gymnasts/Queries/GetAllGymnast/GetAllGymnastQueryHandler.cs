using Api.Application.Interfaces.AutoMapper;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;

namespace Api.Application.Features.Gymnasts.Queries.GetAllGymnast
{
    public class GetAllGymnastQueryHandler : IRequestHandler<GetAllGymnastQueryRequest, IList<GetAllGymnastQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private IMapper mapper;

        public GetAllGymnastQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }
        public async Task<IList<GetAllGymnastQueryResponse>> Handle(GetAllGymnastQueryRequest request, CancellationToken cancellationToken)
        {
            var gymnasts = await unitOfWork.GetReadRepository<Gymnast>().GetAllAsync();

            List<GetAllGymnastQueryResponse> response = new();


            var map = mapper.Map<GetAllGymnastQueryResponse, Gymnast>(gymnasts);
            return response;
        }
    }
}
