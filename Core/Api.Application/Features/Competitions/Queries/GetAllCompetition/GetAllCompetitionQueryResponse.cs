using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Competitions.Queries.GetAllCompetition
{
    public class GetAllCompetitionQueryResponse
    {
        public int CompetitionId { get; set; }
        public string CompetitionName { get; set; }
        public string CompetitionHall { get; set; }
        public CompetitionType CompetitionType { get; set; }
        public DateTime CompetitionDate { get; set; }
    }
}
