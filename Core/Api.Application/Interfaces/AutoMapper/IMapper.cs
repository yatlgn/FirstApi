using Api.Application.Features.CoachGymnasts.Command.UpdateCoachGymnast;
using Api.Application.Features.GymnastParents.Command.UpdateGymnastParent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Interfaces.AutoMapper
{
    public interface IMapper
    {
        TDestination Map<TDestination, TSource>(TSource source, string? ignore = null);

        IList<TDestination> Map<TDestination, TSource>(IList<TSource> source, string? ignore = null);

        TDestination Map<TDestination>(object source, string? ignore = null);
        IList <TDestination> Map<TDestination>(IList <object> source, string? ignore = null);
        object Map<T1, T2>(UpdateCoachGymnastCommandRequest request);
        object Map<T1, T2>(UpdateGymnastParentCommandRequest request);
    }
}
