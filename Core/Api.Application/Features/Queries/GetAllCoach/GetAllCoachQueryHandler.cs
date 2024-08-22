using Api.Application.Interfaces;
using Api.Application.Interfaces.AutoMapper;
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
        private IMapper mapper;

        public GetAllCoacQueryhHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            
        }
        public  async Task<IList<GetAllCoachQueryResponse>> Handle(GetAllCoachQueryRequest request, CancellationToken cancellationToken)
        {
            var coachs = await unitOfWork.GetReadRepository<Coach>().GetAllAsync();

            List<GetAllCoachQueryResponse> response = new();


            var map = mapper.Map<GetAllCoachQueryResponse, Coach>(coachs);
            return response;
        }
    }
}
