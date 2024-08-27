using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Difficulties.Command.UpdateDifficulty
{
    public class UpdateDifficultyCommandRequest : IRequest<Unit>
    {
        public string DifficultyName { get; set; }
        public DifficultyType DifficultyType { get; set; }
        public double DifficultyPoint { get; set; }
        public int DifficultyId { get; internal set; }
    }
}
