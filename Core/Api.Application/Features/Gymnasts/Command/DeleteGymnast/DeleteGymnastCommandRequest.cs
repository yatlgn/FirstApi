using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Gymnasts.Command.DeleteGymnast
{
    public class DeleteGymnastCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
