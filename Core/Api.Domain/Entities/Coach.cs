using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Domain.Common;

namespace Api.Domain.Entities
{
    public enum Branch
    {
        Gymnastics,
        Ballet,
        Dance,
        Fitness

    }
    public class Coach : EntityBase
    {
        public int CoachId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public Branch Branch { get; set; }
        public int Brevet { get; set; }
        public ICollection<CoachGymnast> CoachGymnast { get; set; }


    }
}
