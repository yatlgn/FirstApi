using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class CompetitionGymnast
    {
        public int Id { get; set; }
        public Gymnast GymnastId { get; set; }

        public Competitions CompetitionId { get; set; }
    }
}
