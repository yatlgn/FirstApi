using Api.Application.Interfaces.AutoMapper;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;

namespace Api.Application.Features.Competitions.Queries.GetAllCompetition
{
    public class GetAllCompetitionQueryHandler : IRequestHandler<GetAllCompetitionQueryRequest, IList<GetAllCompetitionQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private IMapper mapper;

        public GetAllCompetitionQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }
        public async Task<IList<GetAllCompetitionQueryResponse>> Handle(GetAllCompetitionQueryRequest request, CancellationToken cancellationToken)
        {
            var competitions = await unitOfWork.GetReadRepository<Competition>().GetAllAsync();

            List<GetAllCompetitionQueryResponse> response = new();


            var map = mapper.Map<GetAllCompetitionQueryResponse, Competition>(competitions);
            return response;
        }
    }
}

