using Api.Application.Bases;
using Api.Application.Features.Coachs.Command.DeleteCoach;
using Api.Application.Interfaces;
using Api.Application.Interfaces.AutoMapper;
using Api.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Seriess.Command.DeleteSeries
{
    public class DeleteSeriesCommandHandler :BaseHandler, IRequestHandler<DeleteSeriesCommandRequest, Unit>
    {
      
        public DeleteSeriesCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            
        }
        public async Task<Unit> Handle(DeleteSeriesCommandRequest request, CancellationToken cancellationToken)
        {
            var series = await unitOfWork.GetReadRepository<Series>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            series.IsDeleted = false;

            await unitOfWork.GetWriteRepository<Series>().UpdateAsync(series);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
