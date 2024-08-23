using MediatR;

namespace Api.Application.Features.CoachGymnasts.Queries.GetAllCoachGymnast
{
    public class GetAllCoachGymnastQueryRequest : IRequest<IList<GetAllCoachGymnastQueryResponse>>
    {
    }
}

