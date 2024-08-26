using Api.Application.Features.CoachGymnasts.Command.UpdateCoachGymnast;
using Api.Application.Features.GymnastParents.Command.UpdateGymnastParent;
using Api.Application.Interfaces.AutoMapper;
using AutoMapper;
using AutoMapper.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMapper = AutoMapper.IMapper;

namespace Api.Mapper.AutoMapper
{
    public class Mapper : Application.Interfaces.AutoMapper.IMapper
    {
        public static List<TypePair> typePairs = new();
        private IMapper MapperContainer;

        public TDestination Map<TDestination, TSource>(TSource source, string? ignore = null)
        {
            Config<TDestination, TSource>(5, ignore);
            if (MapperContainer == null)
            {
                throw new InvalidOperationException("MapperContainer has not been initialized.");
            }
            return MapperContainer.Map<TSource, TDestination>(source);
        }

        public IList<TDestination> Map<TDestination, TSource>(IList<TSource> source, string? ignore = null)
        {
            Config<TDestination, TSource>(5, ignore);
            if (MapperContainer == null)
            {
                throw new InvalidOperationException("MapperContainer has not been initialized.");
            }
            return MapperContainer.Map<IList<TSource>, IList<TDestination>>(source);
        }

        public TDestination Map<TDestination>(object source, string? ignore = null)
        {
            Config<TDestination, object>(5, ignore);
            if (MapperContainer == null)
            {
                throw new InvalidOperationException("MapperContainer has not been initialized.");
            }
            return MapperContainer.Map<TDestination>(source);
        }

        public IList<TDestination> Map<TDestination>(IList<object> source, string? ignore = null)
        {
            Config<TDestination, IList<object>>(5, ignore);
            if (MapperContainer == null)
            {
                throw new InvalidOperationException("MapperContainer has not been initialized.");
            }
            return MapperContainer.Map<IList<TDestination>>(source);
        }

        public object Map<T1, T2>(UpdateCoachGymnastCommandRequest request)
        {
            throw new NotImplementedException();
        }

        public object Map<T1, T2>(UpdateGymnastParentCommandRequest request)
        {
            throw new NotImplementedException();
        }

        protected void Config<TDestination, TSource>(int depth = 5, string? ignore = null)
        {
            var typePair = new TypePair(typeof(TSource), typeof(TDestination));
            if (typePairs.Any(a => a.DestinationType == typePair.DestinationType && a.SourceType == typePair.SourceType) && ignore is null)
            {
                return;
            }

            typePairs.Add(typePair);

            var config = new MapperConfiguration(cfg =>
            {
                foreach (var item in typePairs)
                {
                    if (ignore is not null)
                        cfg.CreateMap(item.SourceType, item.DestinationType).MaxDepth(depth).ForMember(ignore, x => x.Ignore()).ReverseMap();
                    else
                        cfg.CreateMap(item.SourceType, item.DestinationType).MaxDepth(depth).ReverseMap();
                }
            });
            MapperContainer = config.CreateMapper();
        }
    }
}
