using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Queries.GetAllCoach
{
    public class GetAllCoachQueryRequest : IRequest<IList<GetAllCoachQueryResponse>>
    {
    }
}
