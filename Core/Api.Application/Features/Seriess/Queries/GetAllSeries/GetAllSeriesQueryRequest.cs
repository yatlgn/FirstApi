using MediatR;

namespace Api.Application.Features.Seriess.Queries.GetAllSeries
{
    public class GetAllSeriesQueryRequest : IRequest<IList<GetAllSeriesQueryResponse>>
    {
    }
}
