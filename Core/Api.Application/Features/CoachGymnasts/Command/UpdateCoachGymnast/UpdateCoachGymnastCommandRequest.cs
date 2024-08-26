using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CoachGymnasts.Command.UpdateCoachGymnast
{
    public class UpdateCoachGymnastCommandRequest : IRequest
    {
        public int Id { get; set; }
        public int GymnastId { get; set; }

        public int CoachId { get; set; }
        public Gymnast Gymnast { get; set; }
        public Coach Coach { get; set; }
    }
}
