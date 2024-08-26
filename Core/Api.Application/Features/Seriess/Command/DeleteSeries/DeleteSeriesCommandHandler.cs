using Api.Application.Features.Coachs.Command.DeleteCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Seriess.Command.DeleteSeries
{
    public class DeleteSeriesCommandHandler : IRequestHandler<DeleteSeriesCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        public DeleteSeriesCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        public async Task Handle(DeleteSeriesCommandRequest request, CancellationToken cancellationToken)
        {
            var series = await unitOfWork.GetReadRepository<Series>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            series.IsDeleted = false;

            await unitOfWork.GetWriteRepository<Series>().UpdateAsync(series);
            await unitOfWork.SaveAsync();
        }
    }
}
