using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Queries.GetAllCoach
{
    public class GetAllCoacQueryhHandler : IRequestHandler<GetAllCoachQueryRequest, IList<GetAllCoachQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        public GetAllCoacQueryhHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            
        }
        public  async Task<IList<GetAllCoachQueryResponse>> Handle(GetAllCoachQueryRequest request, CancellationToken cancellationToken)
        {
            var coachs = await unitOfWork.GetReadRepository<Coach>().GetAllAsync();

            List<GetAllCoachQueryResponse> response = new();
            return response;
        }
    }
}
