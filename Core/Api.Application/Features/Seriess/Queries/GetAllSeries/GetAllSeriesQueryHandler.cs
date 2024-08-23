using Api.Application.Interfaces.AutoMapper;
using Api.Application.Interfaces;
using MediatR;
using Api.Domain.Entities;

namespace Api.Application.Features.Seriess.Queries.GetAllSeries
{
    public class GetAllSeriesQueryHandler : IRequestHandler<GetAllSeriesQueryRequest, IList<GetAllSeriesQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private IMapper mapper;

        public GetAllSeriesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }
        public async Task<IList<GetAllSeriesQueryResponse>> Handle(GetAllSeriesQueryRequest request, CancellationToken cancellationToken)
        {
            var series = await unitOfWork.GetReadRepository<Series>().GetAllAsync();

            List<GetAllSeriesQueryResponse> response = new();


            var map = mapper.Map<GetAllSeriesQueryResponse, Series>(series);
            return response;
        }
    }
}
