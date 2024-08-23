using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Coachs.Command.UpdateCoach
{
    public class UpdateCoachCommandRequest : IRequest
    {
        public int CoachId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public Branch Branch { get; set; }
        public int Brevet { get; set; }
        public ICollection<CoachGymnast> CoachGymnast { get; set; }
    }
}
