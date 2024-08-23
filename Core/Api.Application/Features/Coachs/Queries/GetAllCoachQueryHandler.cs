using Api.Application.Features.CompetitionGymnasts.Queries.GetAllCompetitionGymnast;
using Api.Application.Interfaces.AutoMapper;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Coachs.Queries
{

            public class GetAllCoachQueryHandler : IRequestHandler<GetAllCoachQueryRequest, IList<GetAllCoachQueryResponse>>
            {
                private readonly IUnitOfWork unitOfWork;
                private IMapper mapper;

                public GetAllCoachQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
                {
                    this.unitOfWork = unitOfWork;
                    this.mapper = mapper;

                }
                public async Task<IList<GetAllCoachQueryResponse>> Handle(GetAllCoachQueryRequest request, CancellationToken cancellationToken)
                {
                    var coachs = await unitOfWork.GetReadRepository<Coach>().GetAllAsync();

                    List<GetAllCoachQueryResponse> response = new();


                    var map = mapper.Map<GetAllCoachQueryResponse, Coach>(coachs);
                    return response;
                }
            }
        }

