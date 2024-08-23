using Api.Application.Interfaces.AutoMapper;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;

namespace Api.Application.Features.Workouts.Queries.GetAllWorkout
{
    public class GetAllWorkoutQueryHandler : IRequestHandler<GetAllWorkoutQueryRequest, IList<GetAllWorkoutQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private IMapper mapper;

        public GetAllWorkoutQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }
        public async Task<IList<GetAllWorkoutQueryResponse>> Handle(GetAllWorkoutQueryRequest request, CancellationToken cancellationToken)
        {
            var workouts = await unitOfWork.GetReadRepository<Workout>().GetAllAsync();

            List<GetAllWorkoutQueryResponse> response = new();


            var map = mapper.Map<GetAllWorkoutQueryResponse, Workout>(workouts);
            return response;
        }
    }
}