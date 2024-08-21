using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Domain.Common;

namespace Api.Domain.Entities
{
    public enum Category
    {
        Tinyage,
        Youngage,
        Junior,
        Senior,
        Elite
    }
    public class Gymnast : EntityBase
    {
        public int GymnastId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMI { get; set; }
     
        public Category Category { get; set; }
        public ICollection<CompetitionGymnast> CompetitionGymnasts { get; set; }
        public ICollection<CoachGymnast>CoachGymnasts { get; set; }
        public ICollection<GymnastParent> GymnastParent { get; set; }
    }
}
