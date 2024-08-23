using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Gymnasts.Queries.GetAllGymnast
{
    public class GetAllGymnastQueryResponse
    {
        public int GymnastId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMI { get; set; }

        public Category Category { get; set; }
    }
}
