using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Difficulties.Queries.GetAllDifficulty
{
    public class GetAllDifficultyQueryResponse
    {
        public string DifficultyName { get; set; }
        public DifficultyType DifficultyType { get; set; }
        public double DifficultyPoint { get; set; }
    }
}

