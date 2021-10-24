using System.Collections.Generic;

namespace FinalProject1.Configuration
{
    public class Response
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}