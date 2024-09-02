using Api.Application.Features.Coachs.Command.UpdateCoach;
using Api.Application.Interfaces.AutoMapper;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Application.Bases;
using Microsoft.AspNetCore.Http;

namespace Api.Application.Features.Seriess.Command.UpdateSeries
{
    public class UpdateSeriesCommandHandler :BaseHandler, IRequestHandler<UpdateSeriesCommandRequest,Unit>
    {
      
        public UpdateSeriesCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {


        }
        public async Task <Unit>Handle(UpdateSeriesCommandRequest request, CancellationToken cancellationToken)
        {
            var series = await unitOfWork.GetReadRepository<Series>().GetAsync(x => x.Id == request.SeriesId && !x.IsDeleted);
            var map = mapper.Map<Series, UpdateSeriesCommandRequest>(request);

            return Unit.Value;
        }
    }
}
