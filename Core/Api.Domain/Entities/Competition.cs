using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Domain.Common;

namespace Api.Domain.Entities
{
    public enum CompetitionType
    {
        Interclub,
        Regional,
        Territorial,
        İnternational
    }
    public class Competition : EntityBase
    {
        public int CompetitionId { get; set; }
        public string CompetitionName { get; set; }
        public string CompetitionHall { get; set; }
        public CompetitionType CompetitionType { get; set; }
        public DateTime CompetitionDate { get; set; }

        public ICollection<CompetitionGymnast>CompetitionGymnast { get; set;}
    }
}
