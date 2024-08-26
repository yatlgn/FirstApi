using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Domain.Common;

namespace Api.Domain.Entities
{
    public class Series : EntityBase
    { 
        public Series() 
        { 
        }
        public Series(int seriesId, double seriesMinute, double totalPoint, DateTime seriesReceivingDate)
        {
            SeriesId = seriesId;
            SeriesMinute = seriesMinute;
            TotalPoint = totalPoint;
            SeriesReceivingDate = seriesReceivingDate;
        }

       
        public int SeriesId { get; set; }
        public double TotalPoint { get; set; }
        public DateTime SeriesReceivingDate { get; set; }
        public double SeriesMinute { get; set; }
    }
}
