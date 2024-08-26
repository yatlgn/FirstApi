using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CompetitionGymnasts.Command.UpdateCompetitionGymnast
{
    public class UpdateCompetitionGymnastCommandRequest :IRequest
    {

        public int Id { get; set; }
        public int GymnastId { get; set; }

        public int CompetitionId { get; set; }
        public Gymnast Gymnast { get; set; }
        public Competition Competition { get; set; }
    }
}
