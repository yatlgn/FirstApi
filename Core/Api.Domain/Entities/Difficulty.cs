using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Domain.Common;

namespace Api.Domain.Entities
{
    public enum DifficultyType
    {
        Jumps,
        Balances,
        Rotations

    }
    public class Difficulty : EntityBase
    {
        public string DifficultyName { get; set; }
        public DifficultyType DifficultyType { get; set; }
        public double DifficultyPoint { get; set; }
    }
}
