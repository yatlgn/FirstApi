using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Domain.Common;

namespace Api.Domain.Entities
{
    public class CoachGymnast : EntityBase
    {

        public CoachGymnast()
        {

        }
        public CoachGymnast(int ıd, int gymnastId, int coachId)
        {
            Id = ıd;
            GymnastId = gymnastId;
            CoachId = coachId;
        }

        public int Id { get; set; }
        public int GymnastId { get; set; }

        public int CoachId { get; set; }
        public Gymnast Gymnast { get; set; }
        public Coach Coach { get; set; }
    }
}
