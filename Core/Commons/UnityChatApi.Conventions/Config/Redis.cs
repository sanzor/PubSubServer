﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace UnityChatApi.Conventions {
    [Serializable]
    public class Redis {
        [JsonPropertyName("con")]
        public string Con { get; set; }
    }
}
