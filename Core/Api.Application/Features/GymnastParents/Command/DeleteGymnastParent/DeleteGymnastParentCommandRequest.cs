using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.GymnastParents.Command.DeleteGymnastParent
{
    public class DeleteGymnastParentCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
