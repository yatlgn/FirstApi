using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Seriess.Command.DeleteSeries
{
    public class DeleteSeriesCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
