using MediatR;

namespace Api.Application.Features.Difficulties.Queries.GetAllDifficulty
{
    public class GetAllDifficultyQueryRequest : IRequest<IList<GetAllDifficultyQueryResponse>>
    {
    }
}
