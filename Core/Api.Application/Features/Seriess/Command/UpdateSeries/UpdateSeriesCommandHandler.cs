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

namespace Api.Application.Features.Seriess.Command.UpdateSeries
{
    public class UpdateSeriesCommandHandler : IRequestHandler<UpdateSeriesCommandRequest,Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public UpdateSeriesCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }
        public async Task <Unit>Handle(UpdateSeriesCommandRequest request, CancellationToken cancellationToken)
        {
            var series = await unitOfWork.GetReadRepository<Series>().GetAsync(x => x.Id == request.SeriesId && !x.IsDeleted);
            var map = mapper.Map<Series, UpdateSeriesCommandRequest>(request);

            return Unit.Value;
        }
    }
}
