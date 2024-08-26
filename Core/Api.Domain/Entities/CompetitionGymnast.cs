using Api.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class CompetitionGymnast : EntityBase
    {
        public CompetitionGymnast()
        {

        }
        public CompetitionGymnast(int ıd, int gymnastId, int competitionId)
        {
            Id = ıd;
            GymnastId = gymnastId;
            CompetitionId = competitionId;
        }

        public int Id { get; set; }
        public int GymnastId { get; set; }

        public int CompetitionId { get; set; }
        public Gymnast Gymnast { get; set; }
        public Competition  Competition { get; set; }
    }
}
