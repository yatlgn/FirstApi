﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CompetitionGymnasts.Command.DeleteCompetitionGymnast
{
    public class DeleteCompetitionGymnastCommandRequest :IRequest
    {
        public int Id { get; set; }
    }
}
