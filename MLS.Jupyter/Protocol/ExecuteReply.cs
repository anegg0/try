﻿using Newtonsoft.Json;

namespace MLS.Jupyter.Protocol
{
    public class ExecuteReply
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("execution_count", NullValueHandling = NullValueHandling.Ignore)]
        public int ExecutionCount { get; set; }

    }
}
