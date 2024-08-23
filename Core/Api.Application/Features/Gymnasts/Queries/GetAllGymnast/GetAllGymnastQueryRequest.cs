﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Gymnasts.Queries.GetAllGymnast
{
    public class GetAllGymnastQueryRequest : IRequest<IList<GetAllGymnastQueryResponse>>
    {
    }
}
