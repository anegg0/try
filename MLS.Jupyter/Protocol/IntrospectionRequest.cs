﻿using Newtonsoft.Json;

namespace MLS.Jupyter.Protocol
{
    public class IntrospectionRequest
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("cursor_pos")]
        public int CursorPos { get; set; }

        [JsonProperty("detail_level")]
        public int DetailLevel { get; set; }
    }
}