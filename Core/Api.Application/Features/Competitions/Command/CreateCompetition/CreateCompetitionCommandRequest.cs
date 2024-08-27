using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Competitions.Command.CreateCompetition
{
    public class CreateCompetitionCommandRequest : IRequest<Unit>
    {
        public int CompetitionId { get; set; }
        public string CompetitionName { get; set; }
        public string CompetitionHall { get; set; }
        public CompetitionType CompetitionType { get; set; }
        public DateTime CompetitionDate { get; set; }

        public ICollection<CompetitionGymnast> CompetitionGymnast { get; set; }
    }
}

