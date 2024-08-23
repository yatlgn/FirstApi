using Api.Application.Interfaces.AutoMapper;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;

namespace Api.Application.Features.Difficulties.Queries.GetAllDifficulty
{
    public class GetAllDifficultyQueryHandler : IRequestHandler<GetAllDifficultyQueryRequest, IList<GetAllDifficultyQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private IMapper mapper;

        public GetAllDifficultyQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }
        public async Task<IList<GetAllDifficultyQueryResponse>> Handle(GetAllDifficultyQueryRequest request, CancellationToken cancellationToken)
        {
            var difficulties = await unitOfWork.GetReadRepository<Difficulty>().GetAllAsync();

            List<GetAllDifficultyQueryResponse> response = new();


            var map = mapper.Map<GetAllDifficultyQueryResponse, Difficulty>(difficulties);
            return response;
        }
    }
}
