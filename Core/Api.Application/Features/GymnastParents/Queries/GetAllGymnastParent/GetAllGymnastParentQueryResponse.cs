﻿using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.GymnastParents.Queries.GetAllGymnastParent
{
    public class GetAllGymnastParentQueryResponse
    {
        public int Id { get; set; }
        public int GymnastId { get; set; }
        public int ParentId { get; set; }

        public Gymnast Gymnast { get; set; }
        public Parent Parent { get; set; }

    }
}
