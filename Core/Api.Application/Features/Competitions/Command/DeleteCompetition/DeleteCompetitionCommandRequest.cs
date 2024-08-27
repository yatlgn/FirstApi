using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Competitions.Command.DeleteCompetition
{
    public class DeleteCompetitionCommandRequest :IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
