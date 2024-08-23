﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Parents.Queries.GetAllParent
{
    public class GetAllParentQueryRequest : IRequest<IList<GetAllParentQueryResponse>>
    {
    }
}
