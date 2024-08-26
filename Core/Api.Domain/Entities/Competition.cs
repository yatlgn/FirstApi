using System;
using System.Collections.Generic;
using Api.Domain.Common;

namespace Api.Domain.Entities
{
    public enum CompetitionType
    {
        Interclub,
        Regional,
        Territorial,
        International
    }

    public class Competition : EntityBase
    {
     
        public Competition()
        {
            CompetitionGymnast = new List<CompetitionGymnast>();
        }

       
        public Competition(int competitionId, string competitionName, string competitionHall, CompetitionType competitionType, DateTime competitionDate)
        {
            CompetitionId = competitionId;
            CompetitionName = competitionName;
            CompetitionHall = competitionHall;
            CompetitionType = competitionType;
            CompetitionDate = competitionDate;
            CompetitionGymnast = new List<CompetitionGymnast>();
        }

        public int CompetitionId { get; set; }
        public string CompetitionName { get; set; }
        public string CompetitionHall { get; set; }
        public CompetitionType CompetitionType { get; set; }
        public DateTime CompetitionDate { get; set; }

        public ICollection<CompetitionGymnast> CompetitionGymnast { get; set; }
    }
}
