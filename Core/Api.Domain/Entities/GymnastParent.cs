using Api.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class GymnastParent : EntityBase
    {
        public GymnastParent()
        {

        }

        public GymnastParent(int ıd, int gymnastId, int parentId)
        {
            Id = ıd;
            GymnastId = gymnastId;
            ParentId = parentId;
        }

        public int Id { get; set; }
        public int GymnastId { get; set; }
        public int ParentId { get; set; }

        public Gymnast Gymnast { get; set; }
        public Parent Parent { get; set; }
    }
}
