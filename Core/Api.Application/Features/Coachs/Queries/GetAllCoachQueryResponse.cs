using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Coachs.Queries
{
    public class GetAllCoachQueryResponse
    {
        public int CoachId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public Branch Branch { get; set; }
        public int Brevet { get; set; }
    }
}
