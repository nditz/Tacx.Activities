using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tacx.Activities.Api.Models
{
    public class ActivityDto
    {
        public int ActivityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Distance { get; set; }
        public double Duration { get; set; }
        public double AvgSpeed { get; set; }
    }
}
