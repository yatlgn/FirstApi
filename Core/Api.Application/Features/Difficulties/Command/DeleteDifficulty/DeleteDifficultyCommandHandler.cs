﻿using Api.Application.Features.Coachs.Command.DeleteCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Difficulties.Command.DeleteDifficulty
{
    public class DeleteDifficultyCommandHandler : IRequestHandler<DeleteDifficultyCommandRequest,Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        public DeleteDifficultyCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        public async Task<Unit> Handle(DeleteDifficultyCommandRequest request, CancellationToken cancellationToken)
        {
            var difficulty = await unitOfWork.GetReadRepository<Difficulty>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            difficulty.IsDeleted = false;

            await unitOfWork.GetWriteRepository<Difficulty>().UpdateAsync(difficulty);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
