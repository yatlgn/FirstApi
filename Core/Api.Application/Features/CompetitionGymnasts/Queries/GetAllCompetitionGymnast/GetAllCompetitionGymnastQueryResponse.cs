using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CompetitionGymnasts.Queries.GetAllCompetitionGymnast
{
    public class GetAllCompetitionGymnastQueryResponse
    {
        public int Id { get; set; }
        public int GymnastId { get; set; }

        public int CompetitionId { get; set; }
        public Gymnast Gymnast { get; set; }
        public Competition Competition { get; set; }
    }
}
