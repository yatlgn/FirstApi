using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CompetitionGymnasts.Command.CreateCompetitionGymnast
{
    public class CreateCompetitionGymnastCommandRequest : IRequest<Unit>
    {

        public int Id { get; set; }
        public int GymnastId { get; set; }

        public int CompetitionId { get; set; }
        public Gymnast Gymnast { get; set; }
        public Competition Competition { get; set; }
    }
}
