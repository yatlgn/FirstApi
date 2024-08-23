using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Parents.Queries.GetAllParent
{
    public class GetAllParentQueryResponse
    {
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public string Job { get; set; }
        public int PhoneNum { get; set; }
    }
}
