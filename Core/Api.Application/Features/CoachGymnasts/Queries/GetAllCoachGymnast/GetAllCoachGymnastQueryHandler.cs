using Api.Application.Interfaces.AutoMapper;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using Api.Application.Features.CoachGymnasts.Queries.GetAllCoachGymnast;

namespace Api.Application.Features.Queries.GetAllCoachGymnast
{
    public class GetAllCoachGymanstQueryHandler : IRequestHandler<GetAllCoachGymnastQueryRequest, IList<GetAllCoachGymnastQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private IMapper mapper;

        public GetAllCoachGymanstQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }
        public async Task<IList<GetAllCoachGymnastQueryResponse>> Handle(GetAllCoachGymnastQueryRequest request, CancellationToken cancellationToken)
        {
            var coachgymnasts = await unitOfWork.GetReadRepository<CoachGymnast>().GetAllAsync();

            List<GetAllCoachGymnastQueryResponse> response = new();


            var map = mapper.Map<GetAllCoachGymnastQueryResponse, CoachGymnast>(coachgymnasts);
            return response;
        }
    }
}
