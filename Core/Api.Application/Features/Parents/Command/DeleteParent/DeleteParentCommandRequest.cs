using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Parents.Command.DeleteParent
{
    public class DeleteParentCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
