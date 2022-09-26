using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Health
{

    // The aggregation of all health check responses, even if one is unhealthy, 'Status' will be unhealthy.
    public class HealthCheckResult
    {
        public string status { get; set; }
        public IEnumerable<HealthCheckResponse> entries { get; set; }
        public string totalDuration { get; set; }
    }
}
