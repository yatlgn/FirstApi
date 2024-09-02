﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        public DateTime RefreshTokenExpiryTime { get; set; }
        public string RefreshToken { get; set; }
    }
}
