using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Coachs.Command.DeleteCoach
{
    public class DeleteCoachCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
