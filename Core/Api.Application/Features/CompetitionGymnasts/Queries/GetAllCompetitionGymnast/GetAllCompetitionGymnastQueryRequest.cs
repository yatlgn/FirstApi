using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CompetitionGymnasts.Queries.GetAllCompetitionGymnast
{
    public class GetAllCompetitionGymnastQueryRequest : IRequest<IList<GetAllCompetitionGymnastQueryResponse>>
    {
    }
}
