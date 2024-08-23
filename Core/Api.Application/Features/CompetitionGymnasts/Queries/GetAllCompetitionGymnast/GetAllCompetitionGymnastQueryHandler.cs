using Api.Application.Interfaces.AutoMapper;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;

namespace Api.Application.Features.CompetitionGymnasts.Queries.GetAllCompetitionGymnast
{
        public class GetAllCompetitionGymanstQueryHandler : IRequestHandler<GetAllCompetitionGymnastQueryRequest, IList<GetAllCompetitionGymnastQueryResponse>>
        {
            private readonly IUnitOfWork unitOfWork;
            private IMapper mapper;

            public GetAllCompetitionGymanstQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this.unitOfWork = unitOfWork;
                this.mapper = mapper;

            }
            public async Task<IList<GetAllCompetitionGymnastQueryResponse>> Handle(GetAllCompetitionGymnastQueryRequest request, CancellationToken cancellationToken)
            {
                var competitiongymnasts = await unitOfWork.GetReadRepository<CompetitionGymnast>().GetAllAsync();

                List<GetAllCompetitionGymnastQueryResponse> response = new();


                var map = mapper.Map<GetAllCompetitionGymnastQueryResponse, CompetitionGymnast>(competitiongymnasts);
                return response;
            }
        }
    }

