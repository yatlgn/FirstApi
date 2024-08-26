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
        public Parent()
        {
        }
        public Parent(int parentId, string name, string surname, bool gender, string job, int phoneNum)
        {
            ParentId = parentId;
            Name = name;
            Surname = surname;
            Gender = gender;
            Job = job;
            PhoneNum = phoneNum;
        }

        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public string Job { get; set; }
        public int PhoneNum { get; set; }
        public ICollection<GymnastParent> GymnastParent { get; set; }
        
    }
}
