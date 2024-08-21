using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Domain.Common;

namespace Api.Domain.Entities
{
    public class Parent : EntityBase
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
