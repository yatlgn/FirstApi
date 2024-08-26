using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Difficulties.Command.DeleteDifficulty
{
    public class DeleteDifficultyCommandRequest : IRequest
    {
        public int Id { get; set; }
    }
}
