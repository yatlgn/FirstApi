﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Common
{
    public class EntityBase : IEntityBase
    {
        public int Id { get; set; }
        public  DateTime CreateDate { get; set; }
        public  bool IsDeleted { get; set; }

    }
}
