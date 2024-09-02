using Api.Application.Bases;
using Api.Application.Features.Coachs.Command.CreateCoach;
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

namespace Api.Application.Features.Seriess.Command.CreateSeries
{
    public class CreateSeriesCommandHandler :BaseHandler, IRequestHandler<CreateSeriesCommandRequest, Unit>
    {
       
        public CreateSeriesCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }
        public async Task<Unit> Handle(CreateSeriesCommandRequest request, CancellationToken cancellationToken)
        {
            Series series = new(request.SeriesId, request.SeriesMinute, request.TotalPoint, request.SeriesReceivingDate);

            await unitOfWork.GetWriteRepository<Series>().AddAsync(series);
            var result = await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}

