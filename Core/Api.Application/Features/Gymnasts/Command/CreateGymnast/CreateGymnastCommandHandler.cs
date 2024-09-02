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

namespace Api.Application.Features.Gymnasts.Command.CreateGymnast
{
   
        public class CreateGymnastCommandHandler :BaseHandler, IRequestHandler<CreateGymnastCommandRequest,Unit>
    {
        public CreateGymnastCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<Unit> Handle(CreateGymnastCommandRequest request, CancellationToken cancellationToken)
            {
                Gymnast gymnast = new(request.GymnastId, request.Name, request.Surname, request.Birthdate, request.Height, request.Weight, request.BMI, request.Category);

                await unitOfWork.GetWriteRepository<Gymnast>().AddAsync(gymnast);
                var result = await unitOfWork.SaveAsync();

            return Unit.Value;
            }
        }
}
