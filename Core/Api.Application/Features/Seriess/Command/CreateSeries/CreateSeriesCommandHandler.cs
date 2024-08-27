using Api.Application.Features.Coachs.Command.CreateCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Seriess.Command.CreateSeries
{
    public class CreateSeriesCommandHandler : IRequestHandler<CreateSeriesCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        public CreateSeriesCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
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

