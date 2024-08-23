using MediatR;

namespace Api.Application.Features.GymnastParents.Queries.GetAllGymnastParent
{
    public class GetAllGymnastParentQueryRequest : IRequest<IList<GetAllGymnastParentQueryResponse>>
    {
    }
}
