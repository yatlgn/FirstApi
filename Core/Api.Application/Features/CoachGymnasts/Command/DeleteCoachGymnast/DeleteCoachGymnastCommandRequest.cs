using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CoachGymnasts.Command.DeleteCoachGymnast
{
    public class DeleteCoachGymnastCommandRequest : IRequest
    {
        public int Id { get; set; }
    }
}
