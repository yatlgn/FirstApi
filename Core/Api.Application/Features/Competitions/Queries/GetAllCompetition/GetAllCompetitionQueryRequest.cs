using MediatR;

namespace Api.Application.Features.Competitions.Queries.GetAllCompetition
{
    public class GetAllCompetitionQueryRequest : IRequest<IList<GetAllCompetitionQueryResponse>>
    {
    }
}
