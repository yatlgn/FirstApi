using Api.Application.Features.Coachs.Command.CreateCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Gymnasts.Command.CreateGymnast
{
   
        public class GymnastCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<CreateGymnastCommandRequest,Unit>
        {
            private readonly IUnitOfWork unitOfWork = unitOfWork;

        public async Task<Unit> Handle(CreateGymnastCommandRequest request, CancellationToken cancellationToken)
            {
                Gymnast gymnast = new(request.GymnastId, request.Name, request.Surname, request.Birthdate, request.Height, request.Weight, request.BMI, request.Category);

                await unitOfWork.GetWriteRepository<Gymnast>().AddAsync(gymnast);
                var result = await unitOfWork.SaveAsync();

            return Unit.Value;
            }
        }
}
