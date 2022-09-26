using System.Collections.Generic;

namespace Common.Health
{
    public class HealthCheckResponse
    {
        public string status { get; set; }
        public string key { get; set; }
        public string description { get; set; }
        public IEnumerable<string> tags { get; set; }
        public string exception { get; set; }
    }
}
