using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CoachGymnasts.Queries.GetAllCoachGymnast
{
    public class GetAllCoachGymnastQueryResponse
    {
        public int Id { get; set; }
        public int GymnastId { get; set; }

        public int CoachId { get; set; }
        public Gymnast Gymnast { get; set; }
        public Coach Coach { get; set; }
    }
}
