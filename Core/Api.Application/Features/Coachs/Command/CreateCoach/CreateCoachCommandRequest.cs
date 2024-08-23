using Api.Domain.Common;
using Api.Domain.Entities;
using MediatR;

namespace Api.Application.Features.Coachs.Command.CreateCoach
{
    public class CreateCoachCommandRequest : IRequest
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
