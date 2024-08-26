using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Parents.Command.UpdateParent
{
    public class UpdateParentCommandRequest : IRequest
    {

        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public string Job { get; set; }
        public int PhoneNum { get; set; }
        public ICollection<GymnastParent> GymnastParent { get; set; }
    }
}
