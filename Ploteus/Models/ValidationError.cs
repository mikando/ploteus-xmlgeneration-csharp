using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploteus.Models
{
    public class ValidationError
    {
        [JsonProperty("type")]
        public EnmValidationErrorType Type { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
