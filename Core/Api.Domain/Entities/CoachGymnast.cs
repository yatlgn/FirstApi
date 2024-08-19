using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Domain.Common;

namespace Api.Domain.Entities
{
    public class CoachGymnast : EntityBase
    {
        public int Id { get; set; }
        public Gymnast GymnastId { get; set; }
        public Coach CoachId { get; set; }
    }
}
