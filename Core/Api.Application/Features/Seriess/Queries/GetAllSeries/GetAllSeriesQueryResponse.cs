using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Seriess.Queries.GetAllSeries
{
    public class GetAllSeriesQueryResponse
    {
        public int SeriesId { get; set; }
        public double TotalPoint { get; set; }
        public DateTime SeriesReceivingDate { get; set; }
        public double SeriesMinute { get; set; }
    }
}
